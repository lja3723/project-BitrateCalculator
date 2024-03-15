using System;
using System.Windows.Forms;
using Bitrate_Calculator.src;


/*
 * [[ Naming 정리 ]]
 * 
 * Bitrate: 그냥 Bitrate라고 하면 Video의 Bitrate를 의미
 * Audio Bitrate: Audio의 Bitrate
 * 
 * 
 * <접두사> 
 * Bitrate~            : "영상 비트레이트"  부분과 관련된 요소
 * ConvertResolution~  : "해상도 변환"      부분과 관련된 요소
 * Main~               : "프로그램 메인 폼" 부분과 관련된 요소
 * OriginVidInfo~      : "원본 영상 파일 정보" 부분과 관련된 요소
 * OutSizeBasedBitrate : "출력 영상 크기 기준 영상 비트레이트 계산" 부분과 관련된 요소
 * 
 * Layout~          : 레이아웃을 구성하는 요소
 * ValuePrintLabel~ : 값 출력 목적의 라벨
 */

namespace Bitrate_Calculator
{
    public partial class Main_Form : Form
    {
        #region 프로그램 Initializing
        private ChildFormManager childFormManager;
        private StatusStripManager statusStripManager;

        public Main_Form()
        {
            InitializeComponent();

            childFormManager = new ChildFormManager();
            statusStripManager = new StatusStripManager(Main_timer, ValuePrintLabel_Main_status);
        }

        //영상 비트레이트 소수점 정밀도
        private string BitrateDecimalPointStr = "0";
        private int BitrateDecimalPointInt = 0;

        //용량 소수점 정밀도
        private string CapacityDecimalPointStr = "0";
        private int CapacityDecimalPointInt = 0;

        private void Main_Form_Load(object sender, EventArgs e)
        {
            //용량 소수점 정밀도 초기화
            ValuePrintLabel_Bitrate_예상출력영상크기.Text = CapacityDecimalPointStr;
            ValuePrintLabel_Bitrate_최대영상비트레이트.Text = BitrateDecimalPointStr;
            ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Text = BitrateDecimalPointStr;
            ValuePrintLabel_ConvertResolution_변환예상크기.Text = CapacityDecimalPointStr;

            //텍스트박스 크기 초기화
            int textBoxHeight = 30;
            double textBoxWidth = 9.8;
            double textBoxWidthAdd = 10;

            ConvertResolution_textBox_변환기준.Height = textBoxHeight;
            OutSizeBasedBitrate_textBox_원하는출력영상크기.Height = textBoxHeight;
            OriginVidInfo_textBox_초당프레임.Height = textBoxHeight;
            OriginVidInfo_textBox_분.Height = textBoxHeight;
            OriginVidInfo_textBox_시간.Height = textBoxHeight;
            OriginVidInfo_textBox_오디오비트레이트.Height = textBoxHeight;
            OriginVidInfo_textBox_초.Height = textBoxHeight;
            OriginVidInfo_textBox_화면해상도_가로.Height = textBoxHeight;
            OriginVidInfo_textBox_화면해상도_세로.Height = textBoxHeight;

            ConvertResolution_textBox_변환기준.Width = (int)Math.Round(ConvertResolution_textBox_변환기준.MaxLength * textBoxWidth + textBoxWidthAdd);
            OutSizeBasedBitrate_textBox_원하는출력영상크기.Width = (int)Math.Round(OutSizeBasedBitrate_textBox_원하는출력영상크기.MaxLength * textBoxWidth + textBoxWidthAdd);
            OriginVidInfo_textBox_초당프레임.Width = (int)Math.Round(OriginVidInfo_textBox_초당프레임.MaxLength * textBoxWidth + textBoxWidthAdd);
            OriginVidInfo_textBox_분.Width = (int)Math.Round(OriginVidInfo_textBox_분.MaxLength * textBoxWidth + textBoxWidthAdd);
            OriginVidInfo_textBox_시간.Width = (int)Math.Round(OriginVidInfo_textBox_시간.MaxLength * textBoxWidth + textBoxWidthAdd);
            OriginVidInfo_textBox_오디오비트레이트.Width = (int)Math.Round(OriginVidInfo_textBox_오디오비트레이트.MaxLength * textBoxWidth + textBoxWidthAdd);
            OriginVidInfo_textBox_초.Width = (int)Math.Round(OriginVidInfo_textBox_초.MaxLength * textBoxWidth + textBoxWidthAdd);
            OriginVidInfo_textBox_화면해상도_가로.Width = (int)Math.Round(OriginVidInfo_textBox_화면해상도_가로.MaxLength * textBoxWidth + textBoxWidthAdd);
            OriginVidInfo_textBox_화면해상도_세로.Width = (int)Math.Round(OriginVidInfo_textBox_화면해상도_세로.MaxLength * textBoxWidth + textBoxWidthAdd);

            statusStripManager.ShowMessage("프로그램을 사용해 주셔서 감사합니다. 이 곳에 알림이 표시됩니다.", 5800);
        }
        #endregion
        


        #region SetDecimalPoint 관련 메서드
        //DecimalPoint 값을 설정한다.
        public void SetDecimalPoint(int BitrateDecimalPointInt, int CapacityDecimalPointInt)
        {
            this.BitrateDecimalPointInt = BitrateDecimalPointInt;
            BitrateDecimalPointStr = "0";
            if (this.BitrateDecimalPointInt > 0)
            {
                BitrateDecimalPointStr += ".";
                for (int i = 0; i < this.BitrateDecimalPointInt; i++)
                    BitrateDecimalPointStr += "0";
            }

            this.CapacityDecimalPointInt = CapacityDecimalPointInt;
            CapacityDecimalPointStr = "0";
            if (this.CapacityDecimalPointInt > 0)
            {
                CapacityDecimalPointStr += ".";
                for (int i = 0; i < this.CapacityDecimalPointInt; i++)
                    CapacityDecimalPointStr += "0";
            }
        }

        //BitrateDecimalPointStr 값을 얻음
        public int GetBitrateDecimalPoint()
        {
            return BitrateDecimalPointInt;
        }

        //CapacityDecimalPoint 값을 얻음
        public int GetCapacityDecimalPoint()
        {
            return CapacityDecimalPointInt;
        }

        //표시 상태 업데이트
        public void UpdateFormMainState()
        {
            UpdateBitrateState();
            CalcBitrateWithConvertedResolution();
            UpdateHopeBitrateState();      
        }
        #endregion



        #region 구현 메서드
        //문자열 또는 문자가 지정된 범위 안에 있는 지 검사
        private bool IsRanged(string str, int min, int max)
        {
            long num = Convert.ToInt64(str);
            if (min <= num && num <= max)
                return true;
            else
                return false;
        }
        private bool IsRanged(char ch, int min, int max)
        {
            if (min + '0' <= ch && ch <= max + '0')
                return true;
            else
                return false;
        }

        //영상 용량 계산
        private decimal CalcCapacity(decimal bitrate, string fileSizeCapacity, string bitrateCapacity)
        {
            decimal capacity = 0;
            
            //모두 비어있지 않으면 계산
            if (
                OriginVidInfo_textBox_오디오비트레이트.Text != "" &&
                OriginVidInfo_textBox_시간.Text != "" &&
                OriginVidInfo_textBox_분.Text != "" &&
                OriginVidInfo_textBox_초.Text != ""
                )
            {
                long hours = Convert.ToInt64(OriginVidInfo_textBox_시간.Text);
                long mins = Convert.ToInt64(OriginVidInfo_textBox_분.Text);
                long seconds = Convert.ToInt64(OriginVidInfo_textBox_초.Text);
                long totalSeconds = hours * 60 * 60 + mins * 60 + seconds;
                if (totalSeconds == 0)
                    return 0;

                decimal audioBitrate = Convert.ToInt64(OriginVidInfo_textBox_오디오비트레이트.Text);

                if (bitrateCapacity.Equals("Kbps"))
                {
                    if (fileSizeCapacity.Equals("MB"))
                        capacity = (audioBitrate + bitrate) / 8192 * totalSeconds;
                    else if (fileSizeCapacity.Equals("GB"))
                        capacity = (audioBitrate + bitrate) / (8192 * 1024) * totalSeconds;
                }
                else if (bitrateCapacity.Equals("Mbps"))
                {
                    if (fileSizeCapacity.Equals("MB"))
                        capacity = (audioBitrate + bitrate * 1024) / 8192 * totalSeconds;
                    else if (fileSizeCapacity.Equals("GB"))
                        capacity = (audioBitrate + bitrate * 1024) / (8192 * 1024) * totalSeconds;
                }
            }
            return capacity;
        }

        //변환 해상도 기준 동영상 용량 계산
        private void CalcBitrateWithConvertedResolution()
        {
            if (
                !ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text.Equals("0") && !ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text.Equals("0") &&
                !ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text.Equals("MAX") && !ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text.Equals("MAX")
                )
            {
                decimal newBitrate = CalcBitrate(ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text, ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text, Bitrate_comboBox_최대영상비트레이트.Text);
                decimal newCapacity = CalcCapacity(newBitrate, ConvertResolution_comboBox_변환예상크기.Text, Bitrate_comboBox_최대영상비트레이트.Text);
                ValuePrintLabel_ConvertResolution_변환예상크기.Text = GetUnitSeparatedDigit(Convert.ToString(newCapacity.ToString(CapacityDecimalPointStr)));
            }
            else
                ValuePrintLabel_ConvertResolution_변환예상크기.Text = GetUnitSeparatedDigit(CapacityDecimalPointStr);
        }

        //영상 비트레이트 계산
        private decimal CalcBitrate(string strWidth, string strHeight, string bitrateCapacity)
        {
            decimal bitrate = 0;
            
            //모두 비어있지 않으면 계산
            if (
                strWidth != "" && strHeight != "" &&
                OriginVidInfo_textBox_초당프레임.Text != ""
                )
            {
                //CodecValue를 할당
                decimal CodecValue = CodecsConvert.ToValue(OriginVidInfo_comboBox_적용코덱.Text);                

                long width = Convert.ToInt64(strWidth);
                long height = Convert.ToInt64(strHeight);
                long FPS = Convert.ToInt64(OriginVidInfo_textBox_초당프레임.Text);
                if (bitrateCapacity.Equals("Kbps"))
                    bitrate = CodecValue / 1024 * width * height * FPS;
                else if (bitrateCapacity.Equals("Mbps"))
                    bitrate = CodecValue / 1024 / 1024 * width * height * FPS;
            }
            return bitrate;
        }

        //출력 영상 크기 기준 영상 비트레이트 계산
        private decimal CalcHopeBitrate(string fileSizeCapacity, string bitrateCapacity)
        {
            decimal hopeBitrate = 0;

            //모두 비어있지 않을 경우 계산
            if (
                fileSizeCapacity != "" &&
                OutSizeBasedBitrate_textBox_원하는출력영상크기.Text != "" &&
                OriginVidInfo_textBox_오디오비트레이트.Text != "" &&
                OriginVidInfo_textBox_시간.Text != "" &&
                OriginVidInfo_textBox_분.Text != "" &&
                OriginVidInfo_textBox_초.Text != ""
                )
            {
                long hours = Convert.ToInt64(OriginVidInfo_textBox_시간.Text);
                long mins = Convert.ToInt64(OriginVidInfo_textBox_분.Text);
                long seconds = Convert.ToInt64(OriginVidInfo_textBox_초.Text);
                long totalSeconds = hours * 60 * 60 + mins * 60 + seconds;
                if (totalSeconds == 0)
                    return 0;

                decimal audioBitrate = Convert.ToInt64(OriginVidInfo_textBox_오디오비트레이트.Text);
                long hopeCapacity = Convert.ToInt64(OutSizeBasedBitrate_textBox_원하는출력영상크기.Text);
                if (fileSizeCapacity.Equals("MB"))
                    hopeBitrate = (8192.0m / totalSeconds * hopeCapacity) - audioBitrate;
                else if (fileSizeCapacity.Equals("GB"))
                    hopeBitrate = ((decimal)hopeCapacity / totalSeconds * 8192 * 1024) - audioBitrate;

                if (bitrateCapacity.Equals("Mbps"))
                    hopeBitrate /= 1024;          

                if (hopeBitrate < 0)
                    return 0;
            }

            return hopeBitrate;
        }

        //해상도 변환
        private void ConvertResolution()
        {
            //비어있지 않을 경우 계산
            if (!ConvertResolution_textBox_변환기준.Text.Equals(""))
            {
                long currentWidth = Convert.ToInt64(ValuePrintLabel_ConvertResolution_현재해상도_가로.Text);
                long currentHeight = Convert.ToInt64(ValuePrintLabel_ConvertResolution_현재해상도_세로.Text);
                const int MAXRANGE = 9999;

                //가로 기준 해상도 변환
                if (ConvertResolution_comboBox_기준.Text.Equals("가로"))
                {

                    if (currentWidth == 0)
                        return;
                    long newWidth = Convert.ToInt64(ConvertResolution_textBox_변환기준.Text);
                    decimal newHeight = newWidth / (decimal)currentWidth * currentHeight;

                    //변환된 세로가 최대 범위 초과시
                    if (newHeight > MAXRANGE)
                    {
                        ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text = Convert.ToString(newWidth);
                        ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text = "MAX";
                        ToolStripMenuItem_해상도변환적용.Enabled = false;
                        ConvertResolution_button_적용.Enabled = false;

                        statusStripManager.ShowErrorMessage("변환 예상 해상도의 세로 길이가 최대 범위(" + MAXRANGE + ")를 벗어납니다.");
                        return;
                    }

                    ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text = Convert.ToString(newWidth);
                    ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text = Convert.ToString(Math.Round(newHeight));
                }

                //세로 기준 해상도 변환
                if (ConvertResolution_comboBox_기준.Text.Equals("세로"))
                {
                    if (currentHeight == 0)
                        return;
                    long newHeight = Convert.ToInt64(ConvertResolution_textBox_변환기준.Text);
                    decimal newWidth = currentWidth / (decimal)currentHeight * newHeight;

                    //변환된 가로가 최대 범위 초과시
                    if (newWidth > MAXRANGE)
                    {
                        ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text = "MAX";
                        ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text = Convert.ToString(newHeight);
                        ToolStripMenuItem_해상도변환적용.Enabled = false;
                        ConvertResolution_button_적용.Enabled = false;

                        statusStripManager.ShowErrorMessage("변환 예상 해상도의 가로 길이가 최대 범위(" + MAXRANGE + ")를 벗어납니다.");
                        return;
                    }

                    ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text = Convert.ToString(Math.Round(newWidth));
                    ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text = Convert.ToString(newHeight);
                }
            }
            else
            {
                ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text = "0";
                ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text = "0";
            }
        }

        //bitrate 상태 업데이트
        private void UpdateBitrateState()
        {
            decimal bitrate = CalcBitrate(OriginVidInfo_textBox_화면해상도_가로.Text, OriginVidInfo_textBox_화면해상도_세로.Text, Bitrate_comboBox_최대영상비트레이트.Text);
            ValuePrintLabel_Bitrate_최대영상비트레이트.Text = GetUnitSeparatedDigit(Convert.ToString(bitrate.ToString(BitrateDecimalPointStr)));
            decimal capacity = CalcCapacity(Convert.ToDecimal(RemoveDigitSeparator(ValuePrintLabel_Bitrate_최대영상비트레이트.Text)), Bitrate_comboBox_예상출력영상크기.Text, Bitrate_comboBox_최대영상비트레이트.Text);
            ValuePrintLabel_Bitrate_예상출력영상크기.Text = GetUnitSeparatedDigit(Convert.ToString(capacity.ToString(CapacityDecimalPointStr)));
        }

        //원하는 비트레이트 상태 업데이트
        private void UpdateHopeBitrateState()
        {
            decimal hopeBitrate = CalcHopeBitrate(OutSizeBasedBitrate_comboBox_원하는출력영상크기.Text, OutSizeBasedBitrate_comboBox_예상영상비트레이트.Text);
            ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Text = GetUnitSeparatedDigit(Convert.ToString(hopeBitrate.ToString(BitrateDecimalPointStr)));
        }

        //문자열 실수 숫자에 콤마 넣기
        private string GetUnitSeparatedDigit(string number)
        {

            if (number.IndexOf(".") == -1)
                for (int i = number.Length - 3; i > 0; i -= 3)
                    number = number.Insert(i, ",");
            else
                for (int i = number.IndexOf(".") - 3; i > 0; i -= 3)
                    number = number.Insert(i, ",");

            return number;
        }

        //문자열 실수 숫자에 콤마 제거
        private string RemoveDigitSeparator(string number)
        {
            string tmpString = number;
            tmpString = tmpString.Replace(",", "");
            return tmpString;
        }
        #endregion



        #region 단축키
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            object sender = null;
            EventArgs e = null;
            if (keyData == (Keys.Control | Keys.R))
            {
                if (ToolStripMenuItem_모두초기화.Enabled == true)
                    ClearAll(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                if (ToolStripMenuItem_원본영상파일정보초기화.Enabled == true)
                    Clear원본영상파일정보(sender, e);
                return true;
            }

            else if (keyData == (Keys.Control | Keys.S))
            {
                if (ToolStripMenuItem_해상도변환적용.Enabled == true)
                    Apply해상도변환(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D))
            {
                Copy최대영상비트레이트(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.F))
            {
                Copy예상영상비트레이트(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.A))
            {
                SelectAll(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.X))
            {
                CutX(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.C))
            {
                CopyC(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.V))
            {
                PasteV(sender, e);
                return true;
            }
            else if (keyData == Keys.Return)
            {
                if (!(ActiveControl is Button))
                    do
                        SelectNextControl(ActiveControl, true, true, true, true);
                    while (ActiveControl is Button);
                else if (ActiveControl == ConvertResolution_button_적용)
                    Apply해상도변환(sender, e);
                else if (ActiveControl == OriginVidInfo_button_초기화)
                    Clear원본영상파일정보(sender, e);
                else if (ActiveControl == Main_button_모두초기화)
                    ClearAll(sender, e);
                else if (ActiveControl == Main_button_제작자)
                    CreateChildForm_제작자(sender, e);
                else if (ActiveControl == Main_button_종료)
                    ExitProgram(sender, e);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion



        #region 에러
        //입력할 수 없을 때 발생하는 에러
        private void CannotPutError(object e)
        {
            KeyEventArgs eKeyEventArgs;
            KeyPressEventArgs eKeyPressEventArgs;
            if (e is KeyEventArgs)
            {
                eKeyEventArgs = (KeyEventArgs)e;
                eKeyEventArgs.Handled = true;
            }
            else if (e is KeyPressEventArgs)
            {
                eKeyPressEventArgs = (KeyPressEventArgs)e;
                eKeyPressEventArgs.Handled = true;
            }

            statusStripManager.ShowErrorMessage("입력할 수 없습니다.");
        }

        //입력값이 숫자가 아닐 때 발생하는 에러
        private void PutIsOnlyDigitError(KeyPressEventArgs e)
        {
            e.Handled = true;
            statusStripManager.ShowErrorMessage("숫자만 입력할 수 있습니다.");
        }

        //입력값의 수치 범위가 초과할 때 발생하는 에러
        private void OverRangedError(string kindOfValue, int min, int max)
        {
            statusStripManager.ShowErrorMessage(min + " 이상 " + max + " 이하의 " + kindOfValue + "만 입력할 수 있습니다.");
        }

        //입력값의 길이 범위가 초과할 때 발생하는 에러
        private void OverMaxLengthError(object sender)
        {
            TextBox textBox = (TextBox)sender;
            statusStripManager.ShowErrorMessage("입력 한도는 " + textBox.MaxLength + "자리입니다.");
        }
        #endregion



        #region Key입력 이벤트

        //쓰기 가능한 컨트롤에 대한 시스템 문자 입력 처리
        private void WritableControlKeyDown(object sender, KeyEventArgs e)
        {
            //TextBox에 대한 처리
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;

                
                //Delete키 입력을 처리한다.
                if (textBox.Text.Length > 0)
                {
                    int column = textBox.SelectionStart;
                    string tmpStr1, tmpStr2;

                    if (e.KeyCode == Keys.Delete)
                    {
                        if (column == 0)
                        {
                            tmpStr1 = textBox.Text.Remove(column, 1);
                            if (tmpStr1.Equals(""))
                                return;
                            else
                                tmpStr2 = Convert.ToString(Convert.ToInt64(tmpStr1));

                            if (!tmpStr1.Equals(tmpStr2))
                            {
                                CannotPutError(e);
                            }
                        }
                    }
                }
            }

            //ComboBox에 대한 처리
            if (sender is ComboBox)
            {
                ComboBox comboBox = (ComboBox)sender;

                //Delete키 입력 처리
                if (e.KeyCode == Keys.Delete)
                    e.Handled = true;
            }
        }

        //텍스트박스에 대한 일반 문자 입력 처리
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            //현재 키보드 이벤트 문자가 숫자 또는 백스페이스가 아니면 숫자입력아님에러 발생
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                PutIsOnlyDigitError(e);
                return;
            }
            
            /* 텍스트박스의 텍스트 길이가 0보다 클 때의 처리
             * 현재 텍스트박스의 텍스트를 임시 저장하는 임시 스트링 변수 tmpTextBoxText를 선언 후
             * tmpTextBox에 입력된 키에 해당하는 TextBox의 변화를 미리 적용시킨다.
             * tmpConvertedStr에 tmpTextBox를 Convert.ToInt64 시킨 문자열을 저장하여
             * tmpTextBox와 tmpConvertStr을 비교, 같으면 적용, 다르면 에러를 발생시킨다. */
            if (textBox.Text.Length > 0)
            {
                //column = 키보드 커서의 위치 (가장 왼쪽 = 0, 가장 오른쪽 = TextBox.Text.Length)
                int column = textBox.SelectionStart;
                string tmpTextBoxText, tmpConvertedStr;
                tmpTextBoxText = textBox.Text;

                //백스페이스 키와 관련된 처리
                if (textBox.SelectionLength != 0)
                    tmpTextBoxText = tmpTextBoxText.Remove(column, textBox.SelectionLength);


                if (e.KeyChar != '\b')
                    tmpTextBoxText = tmpTextBoxText.Insert(column, Convert.ToString(e.KeyChar));
                else
                    if (column != 0)
                        tmpTextBoxText = tmpTextBoxText.Remove(column - 1, 1);
                if (tmpTextBoxText.Equals(""))
                    tmpTextBoxText = "0";

                tmpConvertedStr = Convert.ToString(Convert.ToInt64(tmpTextBoxText));


                //tmpConvertStr의 길이가 textBox의 길이보다 클 경우 입력한도넘김에러 발생
                if (tmpConvertedStr.Length > textBox.MaxLength)
                {
                    OverMaxLengthError(sender);
                    e.Handled = true;
                    return;
                }

                //두 임시 문자열이 같지 않으면 입력 불가 에러 발생
                if (!tmpTextBoxText.Equals(tmpConvertedStr))
                {
                    CannotPutError(e);
                    return;
                }
                else
                {
                    //이벤트 발생 컨트롤이 분 또는 초인 지 판별
                    bool isMinTxtBoxOrSecTxtBox = false;
                    if (
                        textBox == OriginVidInfo_textBox_분 ||
                        textBox == OriginVidInfo_textBox_초
                        )
                    {
                        isMinTxtBoxOrSecTxtBox = true;
                    }

                    if (isMinTxtBoxOrSecTxtBox)
                    {
                        if (!IsRanged(tmpConvertedStr, 0, 59))
                        {
                            OverRangedError("정수", 0, 59);
                            e.Handled = true;
                            return;
                        }
                    }

                    if (textBox == OriginVidInfo_textBox_시간)
                    {
                        if (!IsRanged(tmpConvertedStr, 0, 24 * 30))
                        {
                            OverRangedError("정수", 0, 24 * 30);
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
        }

        //콤보박스에 대한 모든 문자 입력 처리
        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion



        #region TextChanged 이벤트
  
        private void ControlTextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            ToolStripMenuItem_모두초기화.Enabled = true;
            Main_button_모두초기화.Enabled = true;



            //최대 영상 비트레이트를 계산하는 데 필요한 컨트롤이 변경되었는 지 확인
            bool isCtrlToClcMVB = control == OriginVidInfo_textBox_화면해상도_가로 || control == OriginVidInfo_textBox_화면해상도_세로 || control == OriginVidInfo_textBox_초당프레임 || control == OriginVidInfo_comboBox_적용코덱 || control == Bitrate_comboBox_최대영상비트레이트;
            //최대 영상 비트레이트에 해당하는 영상 용량을 계산하는 데 필요한 컨트롤이 변경되었는 지 확인
            bool isCtrlToClcCapacityOfMaxVB = control == OriginVidInfo_textBox_시간 || control == OriginVidInfo_textBox_분 || control == OriginVidInfo_textBox_초 || control == OriginVidInfo_textBox_오디오비트레이트 || control == Bitrate_comboBox_예상출력영상크기 || control == OutSizeBasedBitrate_comboBox_예상영상비트레이트;
            //OutSizeBasedBitrate 컨트롤이 변경되었는 지 확인
            bool isOutSizeBasedBitrateCtrl = control == OutSizeBasedBitrate_textBox_원하는출력영상크기 || control == OutSizeBasedBitrate_comboBox_원하는출력영상크기;
            if (isCtrlToClcMVB || isCtrlToClcCapacityOfMaxVB || isOutSizeBasedBitrateCtrl)
            {
                UpdateBitrateState();
                UpdateHopeBitrateState();
                    if (control != Bitrate_comboBox_예상출력영상크기 && control != OutSizeBasedBitrate_comboBox_예상영상비트레이트 && !isOutSizeBasedBitrateCtrl)
                    {
                        ToolStripMenuItem_원본영상파일정보초기화.Enabled = true;
                        OriginVidInfo_button_초기화.Enabled = true;
                    }               
            }



            //OriginVidInfo 화면 해상도 컨트롤리 변경되었는 지 확인
            bool isOriginVidInfo화면해상도 = control == OriginVidInfo_textBox_화면해상도_가로 || control == OriginVidInfo_textBox_화면해상도_세로;
            //OriginVidInfo 화면 해상도 컨트롤이 변경되었으면 ConvertResolution 현재 해상도를 같게 맞춤
            if (isOriginVidInfo화면해상도)
            {
                if (control == OriginVidInfo_textBox_화면해상도_가로)
                {
                    if (!control.Text.Equals(""))
                        ValuePrintLabel_ConvertResolution_현재해상도_가로.Text = control.Text;
                    else if (control.Text.Equals(""))
                        ValuePrintLabel_ConvertResolution_현재해상도_가로.Text = "0";
                }

                if (control == OriginVidInfo_textBox_화면해상도_세로)
                {
                    if (!control.Text.Equals(""))
                        ValuePrintLabel_ConvertResolution_현재해상도_세로.Text = control.Text;
                    else if (control.Text.Equals(""))
                        ValuePrintLabel_ConvertResolution_현재해상도_세로.Text = "0";
                }
            }
            //ConvertResolution 컨트롤의 편집 가능한 컨트롤이 변경되었는 지 확인
            bool isConvertResolutionWritableCtrl = control == ConvertResolution_comboBox_기준 || control == ConvertResolution_textBox_변환기준 || control == ConvertResolution_comboBox_변환예상크기;
            //ConvertResolution 변환예상해상도 Label이 변경되었는 지 확인
            bool isConvertResolution변환예상해상도Label = control == ValuePrintLabel_ConvertResolution_변환예상해상도_가로 || control == ValuePrintLabel_ConvertResolution_변환예상해상도_세로;
            //ConvertResolution 컨트롤이 변경되었는 지 확인
            bool isConvertResolutionCtrl = isConvertResolutionWritableCtrl || isConvertResolution변환예상해상도Label;
            if (isConvertResolutionCtrl || isOriginVidInfo화면해상도)
            {
                if (!isOriginVidInfo화면해상도)
                    CalcBitrateWithConvertedResolution();
                if (!isConvertResolution변환예상해상도Label)
                    ConvertResolution();
                if (isConvertResolution변환예상해상도Label)
                {
                    ToolStripMenuItem_해상도변환적용.Enabled = true;
                    ConvertResolution_button_적용.Enabled = true;
                    if (control == ValuePrintLabel_ConvertResolution_현재해상도_가로)
                        if (ValuePrintLabel_ConvertResolution_현재해상도_가로.Text.Equals("0"))
                            ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text = "0";
                    if (control == ValuePrintLabel_ConvertResolution_현재해상도_세로)
                        if (ValuePrintLabel_ConvertResolution_현재해상도_세로.Text.Equals("0"))
                            ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text = "0";
                }
            }
        }

        #endregion



        #region 비트레이트 값 복사
        private void Copy최대영상비트레이트(object sender, EventArgs e)
        {
            Clipboard.SetText(RemoveDigitSeparator(ValuePrintLabel_Bitrate_최대영상비트레이트.Text));
            statusStripManager.ShowMessage("최대 영상 비트레이트가 복사되었습니다.");
        }

        private void Copy예상영상비트레이트(object sender, EventArgs e)
        {
            Clipboard.SetText(RemoveDigitSeparator(ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Text));
            statusStripManager.ShowMessage("예상 영상 비트레이트가 복사되었습니다.");
        }
        #endregion



        #region 프로그램 기능
        private void Clear원본영상파일정보(object sender, EventArgs e)
        {
            OriginVidInfo_textBox_초당프레임.Text = "";
            OriginVidInfo_textBox_시간.Text = "";
            OriginVidInfo_textBox_분.Text = "";
            OriginVidInfo_textBox_초.Text = "";
            OriginVidInfo_textBox_화면해상도_가로.Text = "";
            OriginVidInfo_textBox_화면해상도_세로.Text = "";
            OriginVidInfo_textBox_오디오비트레이트.Text = "";
            OriginVidInfo_comboBox_적용코덱.Text = "H.264";

            ToolStripMenuItem_원본영상파일정보초기화.Enabled = false;
            OriginVidInfo_button_초기화.Enabled = false;


            statusStripManager.ShowMessage("원본 영상 파일 정보가 초기화되었습니다.");
        }

        private void ClearAll(object sender, EventArgs e)
        {
            Clear원본영상파일정보(sender, e);
            Bitrate_comboBox_예상출력영상크기.Text = "MB";
            Bitrate_comboBox_최대영상비트레이트.Text = "Kbps";
            OutSizeBasedBitrate_comboBox_원하는출력영상크기.Text = "MB";
            OutSizeBasedBitrate_textBox_원하는출력영상크기.Text = "";
            OutSizeBasedBitrate_comboBox_예상영상비트레이트.Text = "Kbps";
            ConvertResolution_comboBox_기준.Text = "가로";
            ConvertResolution_textBox_변환기준.Text = "";
            ValuePrintLabel_ConvertResolution_현재해상도_가로.Text = "0";
            ValuePrintLabel_ConvertResolution_현재해상도_세로.Text = "0";
            ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text = "0";
            ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text = "0";
            ConvertResolution_comboBox_변환예상크기.Text = "MB";

            ToolStripMenuItem_모두초기화.Enabled = false;
            Main_button_모두초기화.Enabled = false;
            ConvertResolution_button_적용.Enabled = false;
            ToolStripMenuItem_해상도변환적용.Enabled = false;

            statusStripManager.ShowMessage("모두 초기화되었습니다.");
        }

        private void Apply해상도변환(object sender, EventArgs e)
        {
            if (ConvertResolution_comboBox_기준.Text.Equals("가로"))
            {
                OriginVidInfo_textBox_화면해상도_세로.Text = ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text;
                OriginVidInfo_textBox_화면해상도_가로.Text = ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text;

            }
            else if (ConvertResolution_comboBox_기준.Text.Equals("세로"))
            {
                OriginVidInfo_textBox_화면해상도_가로.Text = ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text;
                OriginVidInfo_textBox_화면해상도_세로.Text = ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text;
            }
            ConvertResolution_textBox_변환기준.Text = "";

            ToolStripMenuItem_해상도변환적용.Enabled = false;
            ConvertResolution_button_적용.Enabled = false;

            statusStripManager.ShowMessage("변환된 해상도가 적용되었습니다.");
        }




        private void SelectAll(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                TextBox textBox = (TextBox)ActiveControl;
                textBox.SelectionStart = 0;
                textBox.SelectionLength = textBox.Text.Length;
            }
        }

        private void CutX(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                TextBox textBox = (TextBox)ActiveControl;
                textBox.Cut();
            }
        }

        private void CopyC(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                TextBox textBox = (TextBox)ActiveControl;
                textBox.Copy();
            }
        }

        private void PasteV(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                TextBox textBox = (TextBox)ActiveControl;

                //클립보드의 내용을 임시로 저장하는 스트링 변수 선언
                string tmpClipboardStr = Clipboard.GetText();

                //클립보드의 내용이 모두 숫자인 지 확인하는 플래그 선언
                bool isClipBoardStrOnlyDigit = true;

                //클립보드 내용이 모두 숫자인 지 확인.
                for (int i = 0; i < tmpClipboardStr.Length; i++)
                {
                    if (!char.IsDigit(tmpClipboardStr[i]))
                    {
                        isClipBoardStrOnlyDigit = false;
                        break;
                    }
                }

                //클립보드가 모두 숫자의 나열로 이루어져 있으면
                if (isClipBoardStrOnlyDigit)
                {
                    //column : 텍스트박스의 키보드 커서 위치 
                    int column = textBox.SelectionStart;

                    //클립보드의 숫자의 나열을 정확한 자연수의 표현으로 변환한 문자열을
                    //임시로 담는 변수 tmpStr 선언
                    //예) 002011 => 2011
                    string tmpStr = Convert.ToString(Convert.ToInt64(tmpClipboardStr));

                    //만약 현재 선택된 텍스트박스가 분 또는 초일 때 0~59에서 벗어나면
                    //범위 초과 에러 발생 후 메서드 종료
                    if (textBox == OriginVidInfo_textBox_분 || textBox == OriginVidInfo_textBox_초)
                    {
                        if (!IsRanged(tmpStr, 0, 59))
                        {
                            OverRangedError("정수", 0, 59);
                            return;
                        }
                    }

                    //만약 tmpStr길이 + 현재 텍스트박스의 텍스트 길이 > 텍스트박스 최대 길이라면
                    //문자열 길이 초과 에러 발생 후 메서드 종료
                    if (tmpStr.Length + textBox.Text.Length > textBox.MaxLength)
                    {
                        OverMaxLengthError(textBox);
                        return;
                    }


                    //클립보드의 내용을 텍스트박스의 텍스트의 현재 column 위치에 삽입
                    textBox.Text = textBox.Text.Insert(column, tmpStr);
                    textBox.SelectionStart = column + tmpStr.Length;
                    textBox.SelectionLength = 0;
                }
                else //클립보드에 하나라도 숫자가 아닌 값이 있으면 삽입 불가 에러 발생
                {
                    CannotPutError(e);
                }
            }
        }




        private void ExitProgram(object sender, EventArgs e)
        {
            Close();
        }
        #endregion



        #region 자식 폼 관리
        private void CreateChildForm_프로그램정보(object sender, EventArgs e)
        {
            childFormManager.Show_프로그램_정보(this);
        }

        private void CreateChildForm_제작자(object sender, EventArgs e)
        {
            childFormManager.Show_제작자_및_도움(this);
        }

        private void CreateChildForm_표시소수점정밀도설정(object sender, EventArgs e)
        {
            childFormManager.Show_소수점_설정(this);
        }
        #endregion
    }
}
