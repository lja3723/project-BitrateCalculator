using System;
using System.Linq;
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
        private readonly ResultPrecisionManager resultPrecisionManager;
        private readonly ChildFormManager childFormManager;
        private readonly StatusStripManager statusStripManager;
        private readonly VisualManager visual;

        public Main_Form()
        {
            InitializeComponent();

            resultPrecisionManager = new ResultPrecisionManager();
            childFormManager = new ChildFormManager(this, resultPrecisionManager);
            statusStripManager = new StatusStripManager(Main_timer, ValuePrintLabel_Main_status);
            visual = new VisualManager(
                resultPrecisionManager,
                OriginVidInfo_textBox_시간,
                OriginVidInfo_textBox_분,
                OriginVidInfo_textBox_초,
                OriginVidInfo_textBox_화면해상도_가로,
                OriginVidInfo_textBox_화면해상도_세로,
                OriginVidInfo_textBox_초당프레임,
                OriginVidInfo_textBox_오디오비트레이트,
                OriginVidInfo_comboBox_적용코덱,
                Bitrate_comboBox_최대영상비트레이트,
                Bitrate_comboBox_예상출력영상크기,
                OutSizeBasedBitrate_comboBox_원하는출력영상크기,
                OutSizeBasedBitrate_textBox_원하는출력영상크기,
                OutSizeBasedBitrate_comboBox_예상영상비트레이트,
                ConvertResolution_comboBox_변환기준,
                ConvertResolution_textBox_변환기준,
                ConvertResolution_comboBox_변환예상크기,
                ValuePrintLabel_Bitrate_최대영상비트레이트,
                ValuePrintLabel_Bitrate_예상출력영상크기,
                ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트,
                ValuePrintLabel_ConvertResolution_현재해상도_가로,
                ValuePrintLabel_ConvertResolution_현재해상도_세로,
                ValuePrintLabel_ConvertResolution_변환예상해상도_가로,
                ValuePrintLabel_ConvertResolution_변환예상해상도_세로,
                ValuePrintLabel_ConvertResolution_변환예상크기);
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            //용량 소수점 정밀도 초기화
            visual.ValueLabel예상출력영상크기 = 0;
            visual.ValueLabel최대영상비트레이트 = 0;
            visual.ValueLabel예상영상비트레이트 = 0;
            visual.ValueLabel변환예상크기 = 0;

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


        #region real time 처리
        //bitrate 상태 업데이트
        private void UpdateBitrateState()
        {
            if (!visual.화면해상도_가로.HasValue || !visual.화면해상도_세로.HasValue || !visual.초당프레임.HasValue)
                return;

            visual.ValueLabel최대영상비트레이트 = CalcBitrate(
                visual.화면해상도_가로.Value,
                visual.화면해상도_세로.Value,
                visual.초당프레임.Value,
                visual.적용코덱,
                visual.최대영상비트레이트);

            if (!visual.시간.HasValue || !visual.분.HasValue || !visual.초.HasValue || !visual.오디오비트레이트.HasValue)
                return;

            visual.ValueLabel예상출력영상크기 = CalcCapacity(
                visual.시간.Value,
                visual.분.Value,
                visual.초.Value,
                visual.오디오비트레이트.Value,
                visual.ValueLabel최대영상비트레이트,
                visual.예상출력영상크기,
                visual.최대영상비트레이트);
        }

        //원하는 비트레이트 상태 업데이트
        private void UpdateOutsizeBasedBitrateState()
        {
            //validation: 모두 비어있지 않아야 함
            if (!visual.시간.HasValue || !visual.분.HasValue || !visual.초.HasValue) return;
            if (!visual.오디오비트레이트.HasValue || !visual.원하는출력영상크기.HasValue) return;

            visual.ValueLabel예상영상비트레이트 = CalcOutsizeBasedBitrate(
                visual.시간.Value,
                visual.분.Value,
                visual.초.Value,
                visual.오디오비트레이트.Value,
                visual.원하는출력영상크기.Value,
                visual.원하는출력영상크기_단위, 
                visual.예상영상비트레이트
                );
        }
        #endregion



        #region TODO: 리얼타임 처리와 도메인 로직 분리필요
        //해상도 변환
        //TODO: 공통로직 제거필요
        private void ConvertResolution()
        {
            //validation: 비어있으면 반환
            if (!visual.변환기준.HasValue || !visual.화면해상도_가로.HasValue || !visual.화면해상도_세로.HasValue)
            {
                visual.ValueLabel변환예상해상도_가로 = 0;
                visual.ValueLabel변환예상해상도_세로 = 0;
                return;
            }

            uint currentWidth = visual.화면해상도_가로.Value;
            uint currentHeight = visual.화면해상도_세로.Value;

            //가로 기준 해상도 변환
            if (visual.변환기준_단위 == ConvertResolutionBase.Horizontal)
            {
                if (currentWidth == 0) return;

                uint newWidth = visual.변환기준.Value;
                uint newHeight = (uint)Math.Round(newWidth * currentHeight / (decimal)currentWidth);

                visual.ValueLabel변환예상해상도_가로 = newWidth;
                visual.ValueLabel변환예상해상도_세로 = newHeight;

                //변환된 세로가 최대 범위 초과시
                if (newHeight > VisualManager.변환예상해상도_최대범위)
                {
                    ToolStripMenuItem_해상도변환적용.Enabled = false;
                    ConvertResolution_button_적용.Enabled = false;

                    statusStripManager.ShowErrorMessage("변환 예상 해상도의 " + "세로" + " 길이가 최대 범위(" + VisualManager.변환예상해상도_최대범위 + ")를 벗어납니다.");
                }
            }

            //세로 기준 해상도 변환
            if (visual.변환기준_단위 == ConvertResolutionBase.Vertical)
            {
                if (currentHeight == 0) return;

                uint newHeight = visual.변환기준.Value;
                uint newWidth = (uint)Math.Round(newHeight * currentWidth / (decimal)currentHeight);

                visual.ValueLabel변환예상해상도_가로 = newWidth;
                visual.ValueLabel변환예상해상도_세로 = newHeight;

                //변환된 가로가 최대 범위 초과시
                if (newWidth > VisualManager.변환예상해상도_최대범위)
                {
                    ToolStripMenuItem_해상도변환적용.Enabled = false;
                    ConvertResolution_button_적용.Enabled = false;

                    statusStripManager.ShowErrorMessage("변환 예상 해상도의 " + "가로" + " 길이가 최대 범위(" + VisualManager.변환예상해상도_최대범위 + ")를 벗어납니다.");
                }
            }
        }


        //변환 해상도 기준 동영상 용량 계산
        private void UpdateBitrateWithConvertedResolution()
        {
            if (!visual.ValueLabel변환예상해상도_가로.HasValue || !visual.ValueLabel변환예상해상도_세로.HasValue)
            {
                visual.ValueLabel변환예상크기 = 0;
                return;
            }
            if (!visual.시간.HasValue || !visual.분.HasValue || !visual.초.HasValue || !visual.오디오비트레이트.HasValue)
                return;
            if (!visual.ValueLabel변환예상해상도_가로.HasValue || !visual.ValueLabel변환예상해상도_세로.HasValue || !visual.초당프레임.HasValue)
                return;

            visual.ValueLabel변환예상크기 = CalcCapacity(
                visual.시간.Value,
                visual.분.Value,
                visual.초.Value,
                visual.오디오비트레이트.Value,
                CalcBitrate(
                    visual.ValueLabel변환예상해상도_가로.Value,
                    visual.ValueLabel변환예상해상도_세로.Value,
                    visual.초당프레임.Value, 
                    visual.적용코덱,
                    visual.최대영상비트레이트),
                visual.변환예상크기,
                visual.최대영상비트레이트);
        }


        //TextChanged 이벤트
        //업데이트된 텍스트박스에 맞는 프로그램 새로고침 발생함
        //TODO: 각 컨트롤에 맞는 이벤트 함수로 분리 필요
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            ToolStripMenuItem_모두초기화.Enabled = true;
            Main_button_모두초기화.Enabled = true;

            //최대 영상 비트레이트를 계산하는 데 필요한 컨트롤이 변경되었는 지 확인
            bool isCtrlToCalcMaxBitrate = 
                control == OriginVidInfo_textBox_화면해상도_가로 || 
                control == OriginVidInfo_textBox_화면해상도_세로 || 
                control == OriginVidInfo_textBox_초당프레임 || 
                control == OriginVidInfo_comboBox_적용코덱 || 
                control == Bitrate_comboBox_최대영상비트레이트;

            //최대 영상 비트레이트에 해당하는 영상 용량을 계산하는 데 필요한 컨트롤이 변경되었는 지 확인
            bool isCtrlToCalcCapacityOfMaxBitrate = 
                control == OriginVidInfo_textBox_시간 || 
                control == OriginVidInfo_textBox_분 || 
                control == OriginVidInfo_textBox_초 || 
                control == OriginVidInfo_textBox_오디오비트레이트 || 
                control == Bitrate_comboBox_예상출력영상크기 || 
                control == OutSizeBasedBitrate_comboBox_예상영상비트레이트;

            //OutSizeBasedBitrate 컨트롤이 변경되었는 지 확인
            bool isOutSizeBasedBitrateCtrl =
                control == OutSizeBasedBitrate_textBox_원하는출력영상크기 || 
                control == OutSizeBasedBitrate_comboBox_원하는출력영상크기;

            if (isCtrlToCalcMaxBitrate || isCtrlToCalcCapacityOfMaxBitrate || isOutSizeBasedBitrateCtrl)
            {
                UpdateBitrateState();
                UpdateOutsizeBasedBitrateState();
                if (control != Bitrate_comboBox_예상출력영상크기 && control != OutSizeBasedBitrate_comboBox_예상영상비트레이트 && !isOutSizeBasedBitrateCtrl)
                {
                    ToolStripMenuItem_원본영상파일정보초기화.Enabled = true;
                    OriginVidInfo_button_초기화.Enabled = true;
                }
            }

            //OriginVidInfo 화면 해상도 컨트롤 변경되었는 지 확인
            bool isOriginVidInfo화면해상도 = 
                control == OriginVidInfo_textBox_화면해상도_가로 || 
                control == OriginVidInfo_textBox_화면해상도_세로;

            //OriginVidInfo 화면 해상도 컨트롤이 변경되었으면 ConvertResolution 현재 해상도를 같게 맞춤
            if (isOriginVidInfo화면해상도)
            {
                if (control == OriginVidInfo_textBox_화면해상도_가로)
                    visual.ValueLabel현재해상도_가로 = Math.Max(0, visual.화면해상도_가로.GetValueOrDefault(0));

                if (control == OriginVidInfo_textBox_화면해상도_세로)
                    visual.ValueLabel현재해상도_세로 = Math.Max(0, visual.화면해상도_세로.GetValueOrDefault(0));
            }

            //ConvertResolution 컨트롤의 편집 가능한 컨트롤이 변경되었는 지 확인
            bool isConvertResolutionWritableCtrl = 
                control == ConvertResolution_comboBox_변환기준 || 
                control == ConvertResolution_textBox_변환기준 || 
                control == ConvertResolution_comboBox_변환예상크기;

            //ConvertResolution 변환예상해상도 Label이 변경되었는 지 확인
            bool isConvertResolution변환예상해상도Label = 
                control == ValuePrintLabel_ConvertResolution_변환예상해상도_가로 ||
                control == ValuePrintLabel_ConvertResolution_변환예상해상도_세로;

            //ConvertResolution 컨트롤이 변경되었는 지 확인
            if (isOriginVidInfo화면해상도 || isConvertResolutionWritableCtrl || isConvertResolution변환예상해상도Label)
            {
                if (!isOriginVidInfo화면해상도)
                    UpdateBitrateWithConvertedResolution();
                if (!isConvertResolution변환예상해상도Label)
                    ConvertResolution();
                else
                {
                    ToolStripMenuItem_해상도변환적용.Enabled = true;
                    ConvertResolution_button_적용.Enabled = true;
                }
            }
        }
        #endregion



        #region 도메인 로직
        //문자열 또는 문자가 지정된 범위 안에 있는 지 검사
        private bool IsRanged(string str, int min, int max)
        {
            long num = Convert.ToInt64(str);
            return min <= num && num <= max;
        }

        //영상 용량 계산
        private decimal CalcCapacity(uint hours, uint mins, uint seconds, uint audioBitrate, decimal bitrate, FilesizeUnit filesizeUnit, PersecUnit bitrateUnit)
        {
            int bitrateUnitOffset = PersecUnitHelper.ToValue(bitrateUnit) >> 10/*div by 1024*/;
            int fileSizeUnitOffset = FilesizeUnitHelper.ToValue(filesizeUnit);
            long totalSeconds = 3600 * hours + 60 * mins + seconds;
            
            return (audioBitrate + bitrate * bitrateUnitOffset) / (fileSizeUnitOffset << 3/*mul by 8*/) * totalSeconds;
        }

        //영상 비트레이트 계산
        //fps에는 OriginVidInfo_textBox_초당프레임 들어가기
        //codec에는 OriginVidInfo_comboBox_적용코덱 들어가기
        private decimal CalcBitrate(uint width, uint height, uint fps, Codecs codec, PersecUnit unit)
        {
            decimal CodecValue = CodecsHelper.ToValue(codec);
            decimal unitOffset = PersecUnitHelper.ToValue(unit);

            return CodecValue * width * height * fps / unitOffset;
        }

        //출력 영상 크기 기준 영상 비트레이트 계산
        private decimal CalcOutsizeBasedBitrate(uint hours, uint mins, uint seconds, uint audioBitrate, uint expectedVidSize, FilesizeUnit filesizeUnit, PersecUnit bitrateUnit)
        {

            int filesizeUnitOffset = FilesizeUnitHelper.ToValue(filesizeUnit);
            int persecUnitOffset = PersecUnitHelper.ToValue(bitrateUnit) >> 10/*div by 1024*/;
            ulong totalSeconds = 3600 * hours + 60 * mins + seconds;
            if (totalSeconds == 0) return 0;

            decimal outsizeBasedBitrate = (((expectedVidSize << 3/*mul by 8*/) * filesizeUnitOffset / (decimal)totalSeconds) - audioBitrate) / persecUnitOffset;     
            return Math.Max(0, outsizeBasedBitrate);
        }
        #endregion



        #region 단축키
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            object sender = null;
            EventArgs e = null;

            switch (keyData)
            {
                case Keys.Control | Keys.R:
                    if (ToolStripMenuItem_모두초기화.Enabled == true)
                        ClearAll(sender, e);
                    return true;
                case Keys.Control | Keys.W:
                    if (ToolStripMenuItem_원본영상파일정보초기화.Enabled == true)
                        Clear원본영상파일정보(sender, e);
                   return true;
                case Keys.Control | Keys.S:
                    if (ToolStripMenuItem_해상도변환적용.Enabled == true)
                        Apply해상도변환(sender, e);
                   return true;
                case Keys.Control | Keys.D:
                    Copy최대영상비트레이트(sender, e);
                    return true;
                case Keys.Control | Keys.F:
                    Copy예상영상비트레이트(sender, e);
                    return true;
                case Keys.Control | Keys.A:
                    SelectAll(sender, e);
                    return true;
                case Keys.Control | Keys.X:
                    CutX(sender, e);
                    return true;
                case Keys.Control | Keys.C:
                    CopyC(sender, e);
                    return true;
                case Keys.Control | Keys.V:
                    PasteV(sender, e);
                    return true;
                case Keys.Return:
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
        private void CannotPutError(KeyEventArgs e)
        {
            e.Handled = true;
            statusStripManager.ShowErrorMessage("입력할 수 없습니다.");
        }
        private void CannotPutError(KeyPressEventArgs e)
        {
            e.Handled = true;
            statusStripManager.ShowErrorMessage("입력할 수 없습니다.");
        }
        private void CannotPutError()
        {
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
        //Delete 키는 KeyPress로 탐지가 안된다.
        //따라서 KeyDown에서 확인해야 함

        //Delete 키에 의해 0으로 시작하는 숫자가 되는 것을 방지
        private void TextBox_PreventLeadingZeroByDelKey(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (e.KeyCode != Keys.Delete) return;
            if (textBox.SelectionStart != 0) return;
            if (textBox.Text.Length <= 1) return;
            if (textBox.Text[1] != '0') return;
            
            CannotPutError(e);
        }

        //텍스트박스에 대한 일반 문자 입력 처리
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            //숫자 입력 또는 지우기만 허용
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '\b'))
            {
                PutIsOnlyDigitError(e);
                return;
            }

            /* 텍스트박스의 텍스트 길이가 0보다 클 때의 처리
             * 현재 텍스트박스의 텍스트를 임시 저장하는 임시 스트링 변수 tmpTextBoxText를 선언 후
             * tmpTextBox에 입력된 키에 해당하는 TextBox의 변화를 미리 적용시킨다.
             * tmpConvertedStr에 tmpTextBox를 Convert.ToInt64 시킨 문자열을 저장하여
             * tmpTextBox와 tmpConvertStr을 비교, 같으면 적용, 다르면 에러를 발생시킨다. */
            if (textBox.Text.Length == 0) return;
            
            //column = 키보드 커서의 위치 (가장 왼쪽 = 0, 가장 오른쪽 = TextBox.Text.Length)
            int column = textBox.SelectionStart;
            string tmpTextBoxText;
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

            string tmpConvertedStr = Convert.ToString(Convert.ToInt64(tmpTextBoxText));

            //tmpConvertStr의 길이가 textBox의 길이보다 클 경우 입력한도넘김에러 발생
            if (tmpConvertedStr.Length > textBox.MaxLength)
            {
                OverMaxLengthError(sender);
                return;
            }

            //두 임시 문자열이 같지 않으면 입력 불가 에러 발생
            if (tmpTextBoxText != tmpConvertedStr)
            {
                CannotPutError(e);
                return;
            }

            
            //이벤트 발생 컨트롤이 분 또는 초인 경우
            if ( textBox == OriginVidInfo_textBox_분 ||
                 textBox == OriginVidInfo_textBox_초 
                 )
            {
                if (!IsRanged(tmpConvertedStr, 0, 59))
                {
                    OverRangedError("정수", 0, 59);
                    e.Handled = true;
                    return;
                }
            }

            //시간인 경우
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

        //ComboBox의 Delete키 입력 방지
        private void ComboBox_PreventDelKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                e.Handled = true;
        }

        //콤보박스 모든 문자 입력 방지
        private void ComboBox_PreventKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion




        #region 프로그램 기능 - TODO: 컨트롤 직접참조 제거하기
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
            ConvertResolution_comboBox_변환기준.Text = "가로";
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
            OriginVidInfo_textBox_화면해상도_가로.Text = ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text;
            OriginVidInfo_textBox_화면해상도_세로.Text = ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text;
            ConvertResolution_textBox_변환기준.Text = "";

            ToolStripMenuItem_해상도변환적용.Enabled = false;
            ConvertResolution_button_적용.Enabled = false;

            statusStripManager.ShowMessage("변환된 해상도가 적용되었습니다.");
        }




        private void SelectAll(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                (ActiveControl as TextBox).SelectAll();
        }

        private void CutX(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                (ActiveControl as TextBox).Cut();
        }

        private void CopyC(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                (ActiveControl as TextBox).Copy();
        }

        private void PasteV(object sender, EventArgs e)
        {
            if (!(ActiveControl is TextBox)) return;

            //클립보드 내용이 모두 숫자가 아니면 에러
            if (!Clipboard.GetText().All(char.IsDigit))
            {
                CannotPutError();
                return;
            }

            //클립보드의 숫자의 나열을 정확한 자연수의 표현으로 변환한 문자열을 임시로 담는 변수 tmpStr 선언
            //예) 002011 => 2011
            string tmpStr = Convert.ToString(Convert.ToInt64(Clipboard.GetText()));
            TextBox textBox = ActiveControl as TextBox;

            //현재 선택된 텍스트박스가 분 또는 초일 때 0~59에서 벗어나면 에러
            if (textBox == OriginVidInfo_textBox_분 || textBox == OriginVidInfo_textBox_초)
            {
                if (!IsRanged(tmpStr, 0, 59))
                {
                    OverRangedError("정수", 0, 59);
                    return;
                }
            }

            //tmpStr길이 + 현재 텍스트박스의 텍스트 길이 > 텍스트박스 최대 길이인 경우 에러
            if (tmpStr.Length + textBox.Text.Length > textBox.MaxLength)
            {
                OverMaxLengthError(textBox);
                return;
            }

            //클립보드의 내용을 텍스트박스의  키보드 커서 위치에 삽입
            int pos = textBox.SelectionStart;
            textBox.Text = textBox.Text.Insert(pos, tmpStr);
            textBox.SelectionStart = pos + tmpStr.Length;
            textBox.SelectionLength = 0;
        }




        private void ExitProgram(object sender, EventArgs e)
        {
            Close();
        }
        #endregion



        //리팩터링 (거의)완료된 영역
        #region 자식 폼 관리
        private void CreateChildForm_프로그램정보(object sender, EventArgs e)
        {
            childFormManager.Show_프로그램_정보();
        }

        private void CreateChildForm_제작자(object sender, EventArgs e)
        {
            childFormManager.Show_제작자_정보();
        }

        private void CreateChildForm_표시소수점정밀도설정(object sender, EventArgs e)
        {
            //소수점 설정 후 프로그램 새로고침되는 로직 넣기
            childFormManager.Show_SetDecimalPoint(() => 
            {
                UpdateBitrateState();
                UpdateBitrateWithConvertedResolution();
                UpdateOutsizeBasedBitrateState();
            });
        }
        #endregion



        #region 비트레이트 값 복사
        private void Copy최대영상비트레이트(object sender, EventArgs e)
        {
            Clipboard.SetText(visual.ValueLabel최대영상비트레이트.ToString());
            statusStripManager.ShowMessage("최대 영상 비트레이트가 복사되었습니다.");
        }

        private void Copy예상영상비트레이트(object sender, EventArgs e)
        {
            Clipboard.SetText(visual.ValueLabel예상영상비트레이트.ToString());
            statusStripManager.ShowMessage("예상 영상 비트레이트가 복사되었습니다.");
        }
        #endregion
    }
}
