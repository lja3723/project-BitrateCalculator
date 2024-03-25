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
        private readonly BitrateCalculator calculator;
        private readonly ResultPrecisionManager precisionManager;
        private readonly ChildFormManager childFormManager;
        private readonly StatusStripManager statusManager;
        private readonly LabelDisplayManager labelManager;
        private readonly InfoControlManager infoCtrlManager;
        private readonly RealtimeManager realtimeManager;
        private readonly ButtonFunctionAccessor accessor;

        public Main_Form()
        {
            InitializeComponent();

            calculator = new BitrateCalculator();
            precisionManager = new ResultPrecisionManager();
            childFormManager = new ChildFormManager(this, precisionManager);
            statusManager = new StatusStripManager(Main_timer, ValuePrintLabel_Main_status);

            infoCtrlManager = new InfoControlManager(
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
                ConvertResolution_comboBox_변환예상크기);

            labelManager = new LabelDisplayManager(
                precisionManager,
                ValuePrintLabel_Bitrate_최대영상비트레이트,
                ValuePrintLabel_Bitrate_예상출력영상크기,
                ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트,
                ValuePrintLabel_ConvertResolution_현재해상도_가로,
                ValuePrintLabel_ConvertResolution_현재해상도_세로,
                ValuePrintLabel_ConvertResolution_변환예상해상도_가로,
                ValuePrintLabel_ConvertResolution_변환예상해상도_세로,
                ValuePrintLabel_ConvertResolution_변환예상크기);

            accessor = new ButtonFunctionAccessor(
                ToolStripMenuItem_해상도변환적용,
                ConvertResolution_button_적용,
                ToolStripMenuItem_원본영상파일정보초기화,
                OriginVidInfo_button_초기화,
                ToolStripMenuItem_모두초기화,
                Main_button_모두초기화);

            realtimeManager = new RealtimeManager(calculator, infoCtrlManager, labelManager, accessor, statusManager);

            statusManager.ShowMessage("프로그램을 사용해 주셔서 감사합니다. 이 곳에 알림이 표시됩니다.", 5800);
        }
        #endregion



        #region 단축키 처리, 에러
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            object sender = null;
            EventArgs e = null;

            switch (keyData)
            {
                case Keys.Control | Keys.R:
                    if (accessor.ClearAllEnabled)
                        ClearAll(sender, e);
                    return true;
                case Keys.Control | Keys.W:
                    if (accessor.ClearOriginVidFieldEnabled)
                        Clear원본영상파일정보(sender, e);
                   return true;
                case Keys.Control | Keys.S:
                    if (accessor.ApplyConvertResolutionEnabled)
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
       
        //입력할 수 없을 때 발생하는 에러
        private void CannotPutError(KeyEventArgs e)
        {
            e.Handled = true;
            statusManager.ShowErrorMessage("입력할 수 없습니다.");
        }
        private void CannotPutError(KeyPressEventArgs e)
        {
            e.Handled = true;
            statusManager.ShowErrorMessage("입력할 수 없습니다.");
        }
        private void CannotPutError()
        {
            statusManager.ShowErrorMessage("입력할 수 없습니다.");
        }

        //입력값이 숫자가 아닐 때 발생하는 에러
        private void PutIsOnlyDigitError(KeyPressEventArgs e)
        {
            e.Handled = true;
            statusManager.ShowErrorMessage("숫자만 입력할 수 있습니다.");
        }

        //입력값의 수치 범위가 초과할 때 발생하는 에러
        private void OverRangedError(string kindOfValue, int min, int max)
        {
            statusManager.ShowErrorMessage(min + " 이상 " + max + " 이하의 " + kindOfValue + "만 입력할 수 있습니다.");
        }

        //입력값의 길이 범위가 초과할 때 발생하는 에러
        private void OverMaxLengthError(object sender)
        {
            TextBox textBox = (TextBox)sender;
            statusManager.ShowErrorMessage("입력 한도는 " + textBox.MaxLength + "자리입니다.");
        }
        #endregion



        #region 도메인 로직(?) - 리팩토링 필요
        //문자열 또는 문자가 지정된 범위 안에 있는 지 검사
        private bool IsRanged(string str, int min, int max)
        {
            long num = Convert.ToInt64(str);
            return min <= num && num <= max;
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



        #region 프로그램 기능
        private void Clear원본영상파일정보(object sender, EventArgs e)
        {
            infoCtrlManager.ClearOriginVidFields(accessor, statusManager);
        }

        private void ClearAll(object sender, EventArgs e)
        {
            infoCtrlManager.ClearAll(accessor, statusManager, labelManager);
        }

        private void Apply해상도변환(object sender, EventArgs e)
        {
            infoCtrlManager.ApplyConvertResolution(accessor, statusManager, calculator);
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
            childFormManager.Show_SetDecimalPoint(() => realtimeManager.RefreshProgram());
        }
        #endregion



        #region 비트레이트 값 복사
        private void Copy최대영상비트레이트(object sender, EventArgs e)
        {
            Clipboard.SetText(calculator.MaxBitrate.ToString());
            statusManager.ShowMessage("최대 영상 비트레이트가 복사되었습니다.");
        }

        private void Copy예상영상비트레이트(object sender, EventArgs e)
        {
            Clipboard.SetText(calculator.DesiredOutputBitrate.ToString());
            statusManager.ShowMessage("예상 영상 비트레이트가 복사되었습니다.");
        }
        #endregion



        #region TextChanged 이벤트
        private void OriginVidInfo_textBox_시간_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateHour();
        }

        private void OriginVidInfo_textBox_분_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateMin();
        }

        private void OriginVidInfo_textBox_초_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateSec();
        }

        private void OriginVidInfo_textBox_화면해상도_가로_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateWidth();
        }

        private void OriginVidInfo_textBox_화면해상도_세로_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateHeight();
        }

        private void OriginVidInfo_textBox_초당프레임_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateFps();
        }

        private void OriginVidInfo_textBox_오디오비트레이트_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateAudioBitrate();
        }

        private void OriginVidInfo_comboBox_적용코덱_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateCodec();
        }

        private void Bitrate_comboBox_최대영상비트레이트_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateMaxBitrateUnit();
        }

        private void Bitrate_comboBox_예상출력영상크기_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateExpectedOutputVidSizeUnit();
        }

        private void OutSizeBasedBitrate_comboBox_원하는출력영상크기_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateDesiredOutputVidSizeUnit();
        }

        private void OutSizeBasedBitrate_textBox_원하는출력영상크기_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateDesiredOutputVidSize();
        }

        private void OutSizeBasedBitrate_comboBox_예상영상비트레이트_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateDesiredOutputBitrateUnit();
        }

        private void ConvertResolution_comboBox_변환기준_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateConvertResolutionBase();
        }

        private void ConvertResolution_textBox_변환기준_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateConvertResolutionSize();
        }

        private void ConvertResolution_comboBox_변환예상크기_TextChanged(object sender, EventArgs e)
        {
            realtimeManager.UpdateConvertedVidSizeUnit();
        }
        #endregion
    }
}
