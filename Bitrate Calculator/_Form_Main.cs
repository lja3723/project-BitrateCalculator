using System;
using System.Windows.Forms;

namespace Bitrate_Calculator
{
    public partial class _Form_Main : Form
    {
        /*
         * 프로그램 Initializing
         */
        public _Form_Main()
        {
            InitializeComponent();
        }

        //영상 비트레이트 소수점 정밀도
        private string VBDecimalPointStr = "0";
        private int VBDecimalPointInt = 0;

        //용량 소수점 정밀도
        private string CpctDecimalPointStr = "0";
        private int CpctDecimalPointInt = 0;

        private void _Form_Main_Load(object sender, EventArgs e)
        {
            //용량 소수점 정밀도 초기화
            VB_label__ShowValue_예상_출력_영상_크기.Text = CpctDecimalPointStr;
            VB_label__ShowValue_최대_영상_비트레이트.Text = VBDecimalPointStr;
            CVBOC_label__ShowValue_영상_비트레이트.Text = VBDecimalPointStr;
            CS_label__ShowValue_변환_예상_파일_크기.Text = CpctDecimalPointStr;

            //텍스트박스 크기 초기화
            int textBoxHeight = 30;
            double textBoxWidth = 9.8;
            double textBoxWidthAdd = 10;

            CS_textBox_기준_픽셀.Height = textBoxHeight;
            CVBOC_textBox_원하는_출력_영상_크기.Height = textBoxHeight;
            DFI_textBox_FPS.Height = textBoxHeight;
            DFI_textBox_분.Height = textBoxHeight;
            DFI_textBox_시간.Height = textBoxHeight;
            DFI_textBox_오디오_비트레이트.Height = textBoxHeight;
            DFI_textBox_초.Height = textBoxHeight;
            DFI_textBox_화면_해상도_가로.Height = textBoxHeight;
            DFI_textBox_화면_해상도_세로.Height = textBoxHeight;

            CS_textBox_기준_픽셀.Width = (int)Math.Round(CS_textBox_기준_픽셀.MaxLength * textBoxWidth + textBoxWidthAdd);
            CVBOC_textBox_원하는_출력_영상_크기.Width = (int)Math.Round(CVBOC_textBox_원하는_출력_영상_크기.MaxLength * textBoxWidth + textBoxWidthAdd);
            DFI_textBox_FPS.Width = (int)Math.Round(DFI_textBox_FPS.MaxLength * textBoxWidth + textBoxWidthAdd);
            DFI_textBox_분.Width = (int)Math.Round(DFI_textBox_분.MaxLength * textBoxWidth + textBoxWidthAdd);
            DFI_textBox_시간.Width = (int)Math.Round(DFI_textBox_시간.MaxLength * textBoxWidth + textBoxWidthAdd);
            DFI_textBox_오디오_비트레이트.Width = (int)Math.Round(DFI_textBox_오디오_비트레이트.MaxLength * textBoxWidth + textBoxWidthAdd);
            DFI_textBox_초.Width = (int)Math.Round(DFI_textBox_초.MaxLength * textBoxWidth + textBoxWidthAdd);
            DFI_textBox_화면_해상도_가로.Width = (int)Math.Round(DFI_textBox_화면_해상도_가로.MaxLength * textBoxWidth + textBoxWidthAdd);
            DFI_textBox_화면_해상도_세로.Width = (int)Math.Round(DFI_textBox_화면_해상도_세로.MaxLength * textBoxWidth + textBoxWidthAdd);

            _Form_Main_toolStripStatusLabel.Text = "프로그램을 사용해 주셔서 감사합니다. 이 곳에 알림이 표시됩니다.";
            TimerStart(5800);
        }



        /*
         * SetDecimalPoint 관련 메서드
         */
        //DecimalPoint 값을 설정한다.
        public void SetDecimalPoint(int VBDecimalPointInt, int CpctDecimalPointInt)
        {
            this.VBDecimalPointInt = VBDecimalPointInt;
            VBDecimalPointStr = "0";
            if (this.VBDecimalPointInt > 0)
            {
                VBDecimalPointStr += ".";
                for (int i = 0; i < this.VBDecimalPointInt; i++)
                    VBDecimalPointStr += "0";
            }

            this.CpctDecimalPointInt = CpctDecimalPointInt;
            CpctDecimalPointStr = "0";
            if (this.CpctDecimalPointInt > 0)
            {
                CpctDecimalPointStr += ".";
                for (int i = 0; i < this.CpctDecimalPointInt; i++)
                    CpctDecimalPointStr += "0";
            }
        }

        //VBDecimalPointStr 값을 얻음
        public int GetVBDecimalPoint()
        {
            return VBDecimalPointInt;
        }

        //CpctDecimalPoint 값을 얻음
        public int GetCpctDecimalPoint()
        {
            return CpctDecimalPointInt;
        }

        //표시 상태 업데이트
        public void UpdateFormMainState()
        {
            UpdateVBState();
            CalcVBWithConvertedResolution();
            UpdateHopeVBState();      
        }
        


        /*
         * 구현 메서드
         */
        //
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
        private decimal CalcCapacity(decimal VB, string fileSizeCapacity, string VBCapacity)
        {
            decimal capacity = 0;
            
            //모두 비어있지 않으면 계산
            if (
                DFI_textBox_오디오_비트레이트.Text != "" &&
                DFI_textBox_시간.Text != "" &&
                DFI_textBox_분.Text != "" &&
                DFI_textBox_초.Text != ""
                )
            {
                long hours = Convert.ToInt64(DFI_textBox_시간.Text);
                long mins = Convert.ToInt64(DFI_textBox_분.Text);
                long seconds = Convert.ToInt64(DFI_textBox_초.Text);
                long totalSeconds = hours * 60 * 60 + mins * 60 + seconds;
                if (totalSeconds == 0)
                    return 0;

                //AB: AudioBitrate
                decimal AB = Convert.ToInt64(DFI_textBox_오디오_비트레이트.Text);

                if (VBCapacity.Equals("Kbps"))
                {
                    if (fileSizeCapacity.Equals("MB"))
                        capacity = (AB + VB) / 8192 * totalSeconds;
                    else if (fileSizeCapacity.Equals("GB"))
                        capacity = (AB + VB) / (8192 * 1024) * totalSeconds;
                }
                else if (VBCapacity.Equals("Mbps"))
                {
                    if (fileSizeCapacity.Equals("MB"))
                        capacity = (AB + VB * 1024) / 8192 * totalSeconds;
                    else if (fileSizeCapacity.Equals("GB"))
                        capacity = (AB + VB * 1024) / (8192 * 1024) * totalSeconds;
                }
            }
            return capacity;
        }

        //변환 해상도 기준 동영상 용량 계산
        private void CalcVBWithConvertedResolution()
        {
            if (
                !CS_label__ShowValue_변환_예상_해상도_가로.Text.Equals("0") && !CS_label__ShowValue_변환_예상_해상도_세로.Text.Equals("0") &&
                !CS_label__ShowValue_변환_예상_해상도_가로.Text.Equals("MAX") && !CS_label__ShowValue_변환_예상_해상도_세로.Text.Equals("MAX")
                )
            {
                decimal newVB = CalcVB(CS_label__ShowValue_변환_예상_해상도_가로.Text, CS_label__ShowValue_변환_예상_해상도_세로.Text, VB_comboBox_Bitrate_단위.Text);
                decimal newCapacity = CalcCapacity(newVB, CS_comboBox_변환_예상_크기_단위.Text, VB_comboBox_Bitrate_단위.Text);
                CS_label__ShowValue_변환_예상_파일_크기.Text = AddCmaInNum(Convert.ToString(newCapacity.ToString(CpctDecimalPointStr)));
            }
            else
                CS_label__ShowValue_변환_예상_파일_크기.Text = AddCmaInNum(CpctDecimalPointStr);
        }

        //영상 비트레이트 계산
        private decimal CalcVB(string strWidth, string strHeight, string VBCapacity)
        {
            decimal VB = 0;
            
            //모두 비어있지 않으면 계산
            if (
                strWidth != "" && strHeight != "" &&
                DFI_textBox_FPS.Text != ""
                )
            {
                decimal CodecValue = 0;

                //CodecValue를 할당
                if (
                    DFI_comboBox_적용_코덱.Text.Equals("MPEG-2") ||
                    DFI_comboBox_적용_코덱.Text.Equals("Xvid") ||
                    DFI_comboBox_적용_코덱.Text.Equals("DviX")
                    )
                    CodecValue = 0.27m;
                else if (
                    DFI_comboBox_적용_코덱.Text.Equals("H.263") ||
                    DFI_comboBox_적용_코덱.Text.Equals("H.264") ||
                    DFI_comboBox_적용_코덱.Text.Equals("X264") ||
                    DFI_comboBox_적용_코덱.Text.Equals("MPEG-4")
                    )
                    CodecValue = 0.17m;

                long width = Convert.ToInt64(strWidth);
                long height = Convert.ToInt64(strHeight);
                long FPS = Convert.ToInt64(DFI_textBox_FPS.Text);
                if (VBCapacity.Equals("Kbps"))
                    VB = CodecValue / 1024 * width * height * FPS;
                else if (VBCapacity.Equals("Mbps"))
                    VB = CodecValue / 1024 / 1024 * width * height * FPS;
            }
            return VB;
        }

        //출력 영상 크기 기준 영상 비트레이트 계산
        private decimal CalcHopeVB(string fileSizeCapacity, string VBCapacity)
        {
            decimal hopeVB = 0;

            //모두 비어있지 않을 경우 계산
            if (
                fileSizeCapacity != "" &&
                CVBOC_textBox_원하는_출력_영상_크기.Text != "" &&
                DFI_textBox_오디오_비트레이트.Text != "" &&
                DFI_textBox_시간.Text != "" &&
                DFI_textBox_분.Text != "" &&
                DFI_textBox_초.Text != ""
                )
            {
                long hours = Convert.ToInt64(DFI_textBox_시간.Text);
                long mins = Convert.ToInt64(DFI_textBox_분.Text);
                long seconds = Convert.ToInt64(DFI_textBox_초.Text);
                long totalSeconds = hours * 60 * 60 + mins * 60 + seconds;
                if (totalSeconds == 0)
                    return 0;

                //AB: AudioBitrate
                decimal AB = Convert.ToInt64(DFI_textBox_오디오_비트레이트.Text);
                long hopeCapacity = Convert.ToInt64(CVBOC_textBox_원하는_출력_영상_크기.Text);
                if (fileSizeCapacity.Equals("MB"))
                    hopeVB = (8192.0m / totalSeconds * hopeCapacity) - AB;
                else if (fileSizeCapacity.Equals("GB"))
                    hopeVB = ((decimal)hopeCapacity / totalSeconds * 8192 * 1024) - AB;

                if (VBCapacity.Equals("Mbps"))
                    hopeVB /= 1024;          

                if (hopeVB < 0)
                    return 0;
            }

            return hopeVB;
        }

        //해상도 변환
        private void ConvertResolution()
        {
            //비어있지 않을 경우 계산
            if (!CS_textBox_기준_픽셀.Text.Equals(""))
            {
                long currentWidth = Convert.ToInt64(CS_label__ShowValue_현재_해상도_가로.Text);
                long currentHeight = Convert.ToInt64(CS_label__ShowValue_현재_해상도_세로.Text);
                const int MAXRANGE = 9999;

                //가로 기준 해상도 변환
                if (CS_comboBox_기준.Text.Equals("가로"))
                {

                    if (currentWidth == 0)
                        return;
                    long newWidth = Convert.ToInt64(CS_textBox_기준_픽셀.Text);
                    decimal newHeight = newWidth / (decimal)currentWidth * currentHeight;

                    //변환된 세로가 최대 범위 초과시
                    if (newHeight > MAXRANGE)
                    {
                        CS_label__ShowValue_변환_예상_해상도_가로.Text = Convert.ToString(newWidth);
                        CS_label__ShowValue_변환_예상_해상도_세로.Text = "MAX";
                        _Form_Main_toolStripStatusLabel.Text = "변환 예상 해상도의 세로 길이가 최대 범위(" + MAXRANGE + ")를 벗어납니다.";
                        _Form_Main_해상도변환적용ToolStripMenuItem.Enabled = false;
                        CS_button_적용.Enabled = false;
                        System.Media.SystemSounds.Asterisk.Play(); ;
                        TimerStart();
                        return;
                    }

                    CS_label__ShowValue_변환_예상_해상도_가로.Text = Convert.ToString(newWidth);
                    CS_label__ShowValue_변환_예상_해상도_세로.Text = Convert.ToString(Math.Round(newHeight));
                }

                //세로 기준 해상도 변환
                if (CS_comboBox_기준.Text.Equals("세로"))
                {
                    if (currentHeight == 0)
                        return;
                    long newHeight = Convert.ToInt64(CS_textBox_기준_픽셀.Text);
                    decimal newWidth = currentWidth / (decimal)currentHeight * newHeight;

                    //변환된 가로가 최대 범위 초과시
                    if (newWidth > MAXRANGE)
                    {
                        CS_label__ShowValue_변환_예상_해상도_가로.Text = "MAX";
                        CS_label__ShowValue_변환_예상_해상도_세로.Text = Convert.ToString(newHeight);
                        _Form_Main_toolStripStatusLabel.Text = "변환 예상 해상도의 가로 길이가 최대 범위(" + MAXRANGE + ")를 벗어납니다.";
                        _Form_Main_해상도변환적용ToolStripMenuItem.Enabled = false;
                        CS_button_적용.Enabled = false;
                        System.Media.SystemSounds.Asterisk.Play(); ;
                        TimerStart();
                        return;
                    }

                    CS_label__ShowValue_변환_예상_해상도_가로.Text = Convert.ToString(Math.Round(newWidth));
                    CS_label__ShowValue_변환_예상_해상도_세로.Text = Convert.ToString(newHeight);
                }
            }
            else
            {
                CS_label__ShowValue_변환_예상_해상도_가로.Text = "0";
                CS_label__ShowValue_변환_예상_해상도_세로.Text = "0";
            }
        }

        //VB 상태 업데이트
        private void UpdateVBState()
        {
            decimal VB = CalcVB(DFI_textBox_화면_해상도_가로.Text, DFI_textBox_화면_해상도_세로.Text, VB_comboBox_Bitrate_단위.Text);
            VB_label__ShowValue_최대_영상_비트레이트.Text = AddCmaInNum(Convert.ToString(VB.ToString(VBDecimalPointStr)));
            decimal capacity = CalcCapacity(Convert.ToDecimal(RmvCmaInNum(VB_label__ShowValue_최대_영상_비트레이트.Text)), VB_comboBox_예상_출력_영상_크기_단위.Text, VB_comboBox_Bitrate_단위.Text);
            VB_label__ShowValue_예상_출력_영상_크기.Text = AddCmaInNum(Convert.ToString(capacity.ToString(CpctDecimalPointStr)));
        }

        //원하는 비트레이트 상태 업데이트
        private void UpdateHopeVBState()
        {
            decimal hopeVB = CalcHopeVB(CVBOC_comboBox_원하는_출력물_크기_단위.Text, CVBOC_comboBox_Bitrate_단위.Text);
            CVBOC_label__ShowValue_영상_비트레이트.Text = AddCmaInNum(Convert.ToString(hopeVB.ToString(VBDecimalPointStr)));
        }

        //문자열 실수 숫자에 콤마 넣기
        private string AddCmaInNum(string number)
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
        private string RmvCmaInNum(string number)
        {
            string tmpString = number;
            tmpString = tmpString.Replace(",", "");
            return tmpString;
        }



        /*
         * 단축키
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            object sender = null;
            EventArgs e = null;
            if (keyData == (Keys.Control | Keys.R))
            {
                if (_Form_Main_모두초기화ToolStripMenuItem.Enabled == true)
                    모두초기화ToolStripMenuItem_Click(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                if (_Form_Main_원본영상파일정보초기화ToolStripMenuItem.Enabled == true)
                    원본영상파일정보초기화ToolStripMenuItem_Click(sender, e);
                return true;
            }

            else if (keyData == (Keys.Control | Keys.S))
            {
                if (_Form_Main_해상도변환적용ToolStripMenuItem.Enabled == true)
                    해상도변환적용ToolStripMenuItem_Click(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D))
            {
                VB_label__ShowValue_최대_영상_비트레이트_Click(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.F))
            {
                CVBOC_label_ShowValue_영상_비트레이트_Click(sender, e);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.A))
            {
                SelectAll();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.X))
            {
                CutX();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.C))
            {
                CopyC();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.V))
            {
                PasteV();
                return true;
            }
            else if (keyData == Keys.Return)
            {
                if (!(ActiveControl is Button))
                    do
                        SelectNextControl(ActiveControl, true, true, true, true);
                    while (ActiveControl is Button);
                else if (ActiveControl == CS_button_적용)
                    CS_button_적용_Click(sender, e);
                else if (ActiveControl == DFI_button_초기화)
                    DFI_button_초기화_Click(sender, e);
                else if (ActiveControl == _Form_Main_button_모두_초기화)
                    _Form_Main_button_모두_초기화_Click(sender, e);
                else if (ActiveControl == _Form_Main_button_제작자)
                    _Form_Main_button_제작자_Click(sender, e);
                else if (ActiveControl == _Form_Main_button_종료)
                    _Form_Main_button_종료_Click(sender, e);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SelectAll()
        {
            if (ActiveControl is TextBox)
            {
                TextBox textBox = (TextBox)ActiveControl;
                textBox.SelectionStart = 0;
                textBox.SelectionLength = textBox.Text.Length;
            }
        }

        private void CutX()
        {
            if (ActiveControl is TextBox)
            {
                TextBox textBox = (TextBox)ActiveControl;
                textBox.Cut();
            }
        }

        private void CopyC()
        {
            if (ActiveControl is TextBox)
            {
                TextBox textBox = (TextBox)ActiveControl;
                textBox.Copy();
            }
        }

        private void PasteV()
        {
            EventArgs e = null;

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
                    if (textBox == DFI_textBox_분 || textBox == DFI_textBox_초)
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



        /*
         * 타이머
         */
        //statusStrip에 알림이 표시되는 static 시간(ms)
        private int timerInterval = 2755;

        private void TimerStart()
        {
            if (_Form_Main_timer.Enabled == true)
                _Form_Main_timer.Stop();
            _Form_Main_timer.Interval = timerInterval;
            _Form_Main_timer.Tick += new EventHandler(timer_Tick);
            _Form_Main_timer.Start();
        }

        private void TimerStart(int customTimerInterVal)
        {
            if (_Form_Main_timer.Enabled == true)
                _Form_Main_timer.Stop();
            _Form_Main_timer.Interval = customTimerInterVal;
            _Form_Main_timer.Tick += new EventHandler(timer_Tick);
            _Form_Main_timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _Form_Main_toolStripStatusLabel.Text = " ";
            _Form_Main_timer.Stop();
        }



        /*
         * 에러
         */
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
            _Form_Main_toolStripStatusLabel.Text = "입력할 수 없습니다.";
            System.Media.SystemSounds.Asterisk.Play();
            TimerStart();
        }

        //입력값이 숫자가 아닐 때 발생하는 에러
        private void PutIsOnlyDigitError(KeyPressEventArgs e)
        {
            _Form_Main_toolStripStatusLabel.Text = "숫자만 입력할 수 있습니다.";
            System.Media.SystemSounds.Asterisk.Play();
            e.Handled = true;
            TimerStart();
        }

        //입력값의 수치 범위가 초과할 때 발생하는 에러
        private void OverRangedError(string kindOfValue, int min, int max)
        {
            _Form_Main_toolStripStatusLabel.Text = min + " 이상 " + max + " 이하의 " + kindOfValue + "만 입력할 수 있습니다.";
            System.Media.SystemSounds.Asterisk.Play();
            TimerStart();
        }

        //입력값의 길이 범위가 초과할 때 발생하는 에러
        private void OverMaxLengthError(object sender)
        {
            TextBox textBox = (TextBox)sender;
            _Form_Main_toolStripStatusLabel.Text = "입력 한도는 " + textBox.MaxLength + "자리입니다.";
            System.Media.SystemSounds.Asterisk.Play();
            TimerStart();
        }



        /*
         * Key입력 이벤트
         */
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
                        textBox == DFI_textBox_분 ||
                        textBox == DFI_textBox_초
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

                    if (textBox == DFI_textBox_시간)
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



        /*
         * TextChanged 이벤트
         */
        private void ControlTextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            _Form_Main_모두초기화ToolStripMenuItem.Enabled = true;
            _Form_Main_button_모두_초기화.Enabled = true;



            //최대 영상 비트레이트를 계산하는 데 필요한 컨트롤이 변경되었는 지 확인
            bool isCtrlToClcMVB = control == DFI_textBox_화면_해상도_가로 || control == DFI_textBox_화면_해상도_세로 || control == DFI_textBox_FPS || control == DFI_comboBox_적용_코덱 || control == VB_comboBox_Bitrate_단위;
            //최대 영상 비트레이트에 해당하는 영상 용량을 계산하는 데 필요한 컨트롤이 변경되었는 지 확인
            bool isCtrlToClcCpctOfMaxVB = control == DFI_textBox_시간 || control == DFI_textBox_분 || control == DFI_textBox_초 || control == DFI_textBox_오디오_비트레이트 || control == VB_comboBox_예상_출력_영상_크기_단위 || control == CVBOC_comboBox_Bitrate_단위;
            //CVBOC 컨트롤이 변경되었는 지 확인
            bool isCVBOCCtrl = control == CVBOC_textBox_원하는_출력_영상_크기 || control == CVBOC_comboBox_원하는_출력물_크기_단위;
            if (isCtrlToClcMVB || isCtrlToClcCpctOfMaxVB || isCVBOCCtrl)
            {
                UpdateVBState();
                UpdateHopeVBState();
                    if (control != VB_comboBox_예상_출력_영상_크기_단위 && control != CVBOC_comboBox_Bitrate_단위 && !isCVBOCCtrl)
                    {
                        _Form_Main_원본영상파일정보초기화ToolStripMenuItem.Enabled = true;
                        DFI_button_초기화.Enabled = true;
                    }               
            }



            //DFI 화면 해상도 컨트롤리 변경되었는 지 확인
            bool isDFI화면해상도 = control == DFI_textBox_화면_해상도_가로 || control == DFI_textBox_화면_해상도_세로;
            //DFI 화면 해상도 컨트롤이 변경되었으면 CS 현재 해상도를 같게 맞춤
            if (isDFI화면해상도)
            {
                if (control == DFI_textBox_화면_해상도_가로)
                {
                    if (!control.Text.Equals(""))
                        CS_label__ShowValue_현재_해상도_가로.Text = control.Text;
                    else if (control.Text.Equals(""))
                        CS_label__ShowValue_현재_해상도_가로.Text = "0";
                }

                if (control == DFI_textBox_화면_해상도_세로)
                {
                    if (!control.Text.Equals(""))
                        CS_label__ShowValue_현재_해상도_세로.Text = control.Text;
                    else if (control.Text.Equals(""))
                        CS_label__ShowValue_현재_해상도_세로.Text = "0";
                }
            }
            //CS 컨트롤의 편집 가능한 컨트롤이 변경되었는 지 확인
            bool isCSWritableCtrl = control == CS_comboBox_기준 || control == CS_textBox_기준_픽셀 || control == CS_comboBox_변환_예상_크기_단위;
            //CS 변환예상해상도 Label이 변경되었는 지 확인
            bool isCS변환예상해상도Label = control == CS_label__ShowValue_변환_예상_해상도_가로 || control == CS_label__ShowValue_변환_예상_해상도_세로;
            //CS 컨트롤이 변경되었는 지 확인
            bool isCSCtrl = isCSWritableCtrl || isCS변환예상해상도Label;
            if (isCSCtrl || isDFI화면해상도)
            {
                if (!isDFI화면해상도)
                    CalcVBWithConvertedResolution();
                if (!isCS변환예상해상도Label)
                    ConvertResolution();
                if (isCS변환예상해상도Label)
                {
                    _Form_Main_해상도변환적용ToolStripMenuItem.Enabled = true;
                    CS_button_적용.Enabled = true;
                    if (control == CS_label__ShowValue_현재_해상도_가로)
                        if (CS_label__ShowValue_현재_해상도_가로.Text.Equals("0"))
                            CS_label__ShowValue_변환_예상_해상도_가로.Text = "0";
                    if (control == CS_label__ShowValue_현재_해상도_세로)
                        if (CS_label__ShowValue_현재_해상도_세로.Text.Equals("0"))
                            CS_label__ShowValue_변환_예상_해상도_세로.Text = "0";
                }
            }
        }



        /*
         * Enter 이벤트
         */
        private void ControlEnter(object sender, EventArgs e)
        {
            SelectAll();
        }



        /*
         * 버튼
         */
        private void CS_button_적용_Click(object sender, EventArgs e)
        {
            해상도변환적용ToolStripMenuItem_Click(sender, e);
        }

        private void _Form_Main_button_제작자_Click(object sender, EventArgs e)
        {
            제작자ToolStripMenuItem_Click(sender, e);
        }

        private void DFI_button_초기화_Click(object sender, EventArgs e)
        {
            원본영상파일정보초기화ToolStripMenuItem_Click(sender, e);
        }

        private void _Form_Main_button_모두_초기화_Click(object sender, EventArgs e)
        {
            모두초기화ToolStripMenuItem_Click(sender, e);
        }

        private void _Form_Main_button_종료_Click(object sender, EventArgs e)
        {
            종료ToolStripMenuItem_Click(sender, e);
        }



        /*
         * ToolStrip
         */
        private void 원본영상파일정보초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DFI_textBox_FPS.Text = "";
            DFI_textBox_시간.Text = "";
            DFI_textBox_분.Text = "";
            DFI_textBox_초.Text = "";
            DFI_textBox_화면_해상도_가로.Text = "";
            DFI_textBox_화면_해상도_세로.Text = "";
            DFI_textBox_오디오_비트레이트.Text = "";
            DFI_comboBox_적용_코덱.Text = "H.264";
            _Form_Main_toolStripStatusLabel.Text = "원본 영상 파일 정보가 초기화되었습니다.";
            TimerStart();
            _Form_Main_원본영상파일정보초기화ToolStripMenuItem.Enabled = false;
            DFI_button_초기화.Enabled = false;
        }

        private void 모두초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            원본영상파일정보초기화ToolStripMenuItem_Click(sender, e);
            VB_comboBox_예상_출력_영상_크기_단위.Text = "MB";
            VB_comboBox_Bitrate_단위.Text = "Kbps";
            CVBOC_comboBox_원하는_출력물_크기_단위.Text = "MB";
            CVBOC_textBox_원하는_출력_영상_크기.Text = "";
            CVBOC_comboBox_Bitrate_단위.Text = "Kbps";
            CS_comboBox_기준.Text = "가로";
            CS_textBox_기준_픽셀.Text = "";
            CS_label__ShowValue_현재_해상도_가로.Text = "0";
            CS_label__ShowValue_현재_해상도_세로.Text = "0";
            CS_label__ShowValue_변환_예상_해상도_가로.Text = "0";
            CS_label__ShowValue_변환_예상_해상도_세로.Text = "0";
            CS_comboBox_변환_예상_크기_단위.Text = "MB";
            _Form_Main_toolStripStatusLabel.Text = "모두 초기화되었습니다.";
            TimerStart();
            _Form_Main_모두초기화ToolStripMenuItem.Enabled = false;
            _Form_Main_button_모두_초기화.Enabled = false;
            CS_button_적용.Enabled = false;
            _Form_Main_해상도변환적용ToolStripMenuItem.Enabled = false;
        }

        private void 해상도변환적용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CS_comboBox_기준.Text.Equals("가로"))
            {
                DFI_textBox_화면_해상도_세로.Text = CS_label__ShowValue_변환_예상_해상도_세로.Text;
                DFI_textBox_화면_해상도_가로.Text = CS_label__ShowValue_변환_예상_해상도_가로.Text;

            }
            else if (CS_comboBox_기준.Text.Equals("세로"))
            {
                DFI_textBox_화면_해상도_가로.Text = CS_label__ShowValue_변환_예상_해상도_가로.Text;
                DFI_textBox_화면_해상도_세로.Text = CS_label__ShowValue_변환_예상_해상도_세로.Text;
            }
            _Form_Main_toolStripStatusLabel.Text = "변환된 해상도가 적용되었습니다.";
            CS_textBox_기준_픽셀.Text = "";
            TimerStart();
            _Form_Main_해상도변환적용ToolStripMenuItem.Enabled = false;
            CS_button_적용.Enabled = false;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormManager.Show_프로그램_정보(this);
        }

        private void 제작자ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormManager.Show_제작자_및_도움(this);
        }

        private void 전체선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void 잘라내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutX();
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyC();
        }

        private void 붙여넣기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteV();
        }

        private void 최대영상비트레이트복사MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VB_label__ShowValue_최대_영상_비트레이트_Click(sender, e);
        }

        private void 예상영상비트레이트복사EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVBOC_label_ShowValue_영상_비트레이트_Click(sender, e);
        }

        private void 영상비트레이트소수점설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormManager.Show_SetDecimalPoint(this);
        }


        /*
         * 비트레이트 값 복사
         */
        private void VB_label__ShowValue_최대_영상_비트레이트_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RmvCmaInNum(VB_label__ShowValue_최대_영상_비트레이트.Text));
            _Form_Main_toolStripStatusLabel.Text = "최대 영상 비트레이트가 복사되었습니다.";
            TimerStart();
        }

        private void VB_label_최대_영상_비트레이트_Click(object sender, EventArgs e)
        {
            VB_label__ShowValue_최대_영상_비트레이트_Click(sender, e);
        }

        private void VB_label_Kbps_Click(object sender, EventArgs e)
        {
            VB_label__ShowValue_최대_영상_비트레이트_Click(sender, e);
        }

        private void CVBOC_label_ShowValue_영상_비트레이트_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RmvCmaInNum(CVBOC_label__ShowValue_영상_비트레이트.Text));
            _Form_Main_toolStripStatusLabel.Text = "예상 영상 비트레이트가 복사되었습니다.";
            TimerStart();
        }

        private void CVBOC_label_예상_영상_비트레이트_Click(object sender, EventArgs e)
        {
            CVBOC_label_ShowValue_영상_비트레이트_Click(sender, e);
        }

        private void CVBOC_label_Kbps_Click(object sender, EventArgs e)
        {
            CVBOC_label_ShowValue_영상_비트레이트_Click(sender, e);
        }
    }
}
