namespace Bitrate_Calculator
{
    partial class Main_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Layout_Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Layout_OutSizeBasedBitrate_groupBox = new System.Windows.Forms.GroupBox();
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기 = new System.Windows.Forms.TextBox();
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기 = new System.Windows.Forms.FlowLayoutPanel();
            this.OutSizeBasedBitrate_label_원하는출력영상크기 = new System.Windows.Forms.Label();
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기 = new System.Windows.Forms.ComboBox();
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트 = new System.Windows.Forms.Label();
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트 = new System.Windows.Forms.FlowLayoutPanel();
            this.OutSizeBasedBitrate_label_예상영상비트레이트 = new System.Windows.Forms.Label();
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트 = new System.Windows.Forms.ComboBox();
            this.Layout_ConvertResolution_groupBox = new System.Windows.Forms.GroupBox();
            this.Layout_ConvertResolution_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConvertResolution_label_현재해상도 = new System.Windows.Forms.Label();
            this.ConvertResolution_button_적용 = new System.Windows.Forms.Button();
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConvertResolution_comboBox_기준 = new System.Windows.Forms.ComboBox();
            this.ConvertResolution_textBox_변환기준 = new System.Windows.Forms.TextBox();
            this.ConvertResolution_label_변환예상해상도 = new System.Windows.Forms.Label();
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도 = new System.Windows.Forms.FlowLayoutPanel();
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로 = new System.Windows.Forms.Label();
            this.ConvertResolution_label_변환예상해상도_x = new System.Windows.Forms.Label();
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로 = new System.Windows.Forms.Label();
            this.ConvertResolution_label_변환기준 = new System.Windows.Forms.Label();
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도 = new System.Windows.Forms.FlowLayoutPanel();
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로 = new System.Windows.Forms.Label();
            this.ConvertResolution_label_현재해상도_x = new System.Windows.Forms.Label();
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로 = new System.Windows.Forms.Label();
            this.ValuePrintLabel_ConvertResolution_변환예상크기 = new System.Windows.Forms.Label();
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConvertResolution_label_변환예상크기 = new System.Windows.Forms.Label();
            this.ConvertResolution_comboBox_변환예상크기 = new System.Windows.Forms.ComboBox();
            this.ConvertResolution_label_colon = new System.Windows.Forms.Label();
            this.Layout_OriginVidInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.Layout_OriginVidInfo_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OriginVidInfo_button_초기화 = new System.Windows.Forms.Button();
            this.OriginVidInfo_label_적용코덱 = new System.Windows.Forms.Label();
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_comboBox_적용코덱 = new System.Windows.Forms.ComboBox();
            this.OriginVidInfo_label_오디오비트레이트 = new System.Windows.Forms.Label();
            this.OriginVidInfo_label_초당프레임 = new System.Windows.Forms.Label();
            this.OriginVidInfo_label_영상길이 = new System.Windows.Forms.Label();
            this.OriginVidInfo_label_화면해상도 = new System.Windows.Forms.Label();
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_textBox_오디오비트레이트 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_Kbps = new System.Windows.Forms.Label();
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_textBox_시간 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_시간 = new System.Windows.Forms.Label();
            this.OriginVidInfo_textBox_분 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_분 = new System.Windows.Forms.Label();
            this.OriginVidInfo_textBox_초 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_초 = new System.Windows.Forms.Label();
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_textBox_초당프레임 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_FPS = new System.Windows.Forms.Label();
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_textBox_화면해상도_가로 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_x = new System.Windows.Forms.Label();
            this.OriginVidInfo_textBox_화면해상도_세로 = new System.Windows.Forms.TextBox();
            this.Layout_Bitrate_groupBox = new System.Windows.Forms.GroupBox();
            this.Layout_Bitrate_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ValuePrintLabel_Bitrate_예상출력영상크기 = new System.Windows.Forms.Label();
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bitrate_label_예상출력영상크기 = new System.Windows.Forms.Label();
            this.Bitrate_comboBox_예상출력영상크기 = new System.Windows.Forms.ComboBox();
            this.ValuePrintLabel_Bitrate_최대영상비트레이트 = new System.Windows.Forms.Label();
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bitrate_label_최대영상비트레이트 = new System.Windows.Forms.Label();
            this.Bitrate_comboBox_최대영상비트레이트 = new System.Windows.Forms.ComboBox();
            this.Layout_Main_tableLayoutPanel_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.Layout_Main_flowLayoutPanel_버튼_Right = new System.Windows.Forms.FlowLayoutPanel();
            this.Main_button_모두초기화 = new System.Windows.Forms.Button();
            this.Main_button_종료 = new System.Windows.Forms.Button();
            this.Layout_Main_flowLayoutPanel_버튼_left = new System.Windows.Forms.FlowLayoutPanel();
            this.Main_button_제작자 = new System.Windows.Forms.Button();
            this.Main_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Main_statusStrip = new System.Windows.Forms.StatusStrip();
            this.ValuePrintLabel_Main_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Main_timer = new System.Windows.Forms.Timer(this.components);
            this.ToolStripMenuItem_메뉴 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_해상도변환적용 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_원본영상파일정보초기화 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_모두초기화 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator_메뉴1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_최대영상비트레이트복사 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_예상영상비트레이트복사 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_표시소수점정밀도설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator_메뉴2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_도움말 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_제작자 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator_도움말 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_프로그램정보 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_편집 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_전체선택 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator_편집 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_잘라내기 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_복사 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_붙여넣기 = new System.Windows.Forms.ToolStripMenuItem();
            this.Layout_Main_tableLayoutPanel.SuspendLayout();
            this.Layout_OutSizeBasedBitrate_groupBox.SuspendLayout();
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.SuspendLayout();
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.SuspendLayout();
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.SuspendLayout();
            this.Layout_ConvertResolution_groupBox.SuspendLayout();
            this.Layout_ConvertResolution_tableLayoutPanel.SuspendLayout();
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.SuspendLayout();
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.SuspendLayout();
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.SuspendLayout();
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.SuspendLayout();
            this.Layout_OriginVidInfo_groupBox.SuspendLayout();
            this.Layout_OriginVidInfo_tableLayoutPanel.SuspendLayout();
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.SuspendLayout();
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.SuspendLayout();
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.SuspendLayout();
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.SuspendLayout();
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.SuspendLayout();
            this.Layout_Bitrate_groupBox.SuspendLayout();
            this.Layout_Bitrate_tableLayoutPanel.SuspendLayout();
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.SuspendLayout();
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.SuspendLayout();
            this.Layout_Main_tableLayoutPanel_Buttons.SuspendLayout();
            this.Layout_Main_flowLayoutPanel_버튼_Right.SuspendLayout();
            this.Layout_Main_flowLayoutPanel_버튼_left.SuspendLayout();
            this.Main_statusStrip.SuspendLayout();
            this.Main_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout_Main_tableLayoutPanel
            // 
            this.Layout_Main_tableLayoutPanel.ColumnCount = 2;
            this.Layout_Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.92744F));
            this.Layout_Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.07256F));
            this.Layout_Main_tableLayoutPanel.Controls.Add(this.Layout_OutSizeBasedBitrate_groupBox, 1, 0);
            this.Layout_Main_tableLayoutPanel.Controls.Add(this.Layout_ConvertResolution_groupBox, 1, 1);
            this.Layout_Main_tableLayoutPanel.Controls.Add(this.Layout_OriginVidInfo_groupBox, 0, 0);
            this.Layout_Main_tableLayoutPanel.Controls.Add(this.Layout_Bitrate_groupBox, 0, 2);
            this.Layout_Main_tableLayoutPanel.Controls.Add(this.Layout_Main_tableLayoutPanel_Buttons, 1, 3);
            this.Layout_Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Main_tableLayoutPanel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout_Main_tableLayoutPanel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Layout_Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 26);
            this.Layout_Main_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.Layout_Main_tableLayoutPanel.Name = "Layout_Main_tableLayoutPanel";
            this.Layout_Main_tableLayoutPanel.RowCount = 4;
            this.Layout_Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.73494F));
            this.Layout_Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.18072F));
            this.Layout_Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.08434F));
            this.Layout_Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Layout_Main_tableLayoutPanel.Size = new System.Drawing.Size(882, 378);
            this.Layout_Main_tableLayoutPanel.TabIndex = 0;
            // 
            // Layout_OutSizeBasedBitrate_groupBox
            // 
            this.Layout_OutSizeBasedBitrate_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout_OutSizeBasedBitrate_groupBox.AutoSize = true;
            this.Layout_OutSizeBasedBitrate_groupBox.Controls.Add(this.Layout_OutSizeBasedBitrate_tableLayoutPanel);
            this.Layout_OutSizeBasedBitrate_groupBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout_OutSizeBasedBitrate_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Layout_OutSizeBasedBitrate_groupBox.Location = new System.Drawing.Point(460, 5);
            this.Layout_OutSizeBasedBitrate_groupBox.Margin = new System.Windows.Forms.Padding(2, 5, 6, 5);
            this.Layout_OutSizeBasedBitrate_groupBox.Name = "Layout_OutSizeBasedBitrate_groupBox";
            this.Layout_OutSizeBasedBitrate_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.Layout_OutSizeBasedBitrate_groupBox.Size = new System.Drawing.Size(416, 102);
            this.Layout_OutSizeBasedBitrate_groupBox.TabIndex = 2;
            this.Layout_OutSizeBasedBitrate_groupBox.TabStop = false;
            this.Layout_OutSizeBasedBitrate_groupBox.Text = "출력 영상 크기 기준 영상 비트레이트 계산";
            this.Main_toolTip.SetToolTip(this.Layout_OutSizeBasedBitrate_groupBox, "원본 영상 파일 정보를 토대로 하여 원하는 크기가 되도록 원본 영상을 재 인코딩 할 때의 영상 비트레이트를 계산합니다.");
            // 
            // Layout_OutSizeBasedBitrate_tableLayoutPanel
            // 
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.ColumnCount = 2;
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.80582F));
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.19418F));
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Controls.Add(this.OutSizeBasedBitrate_textBox_원하는출력영상크기, 1, 0);
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Controls.Add(this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기, 0, 0);
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Controls.Add(this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트, 1, 1);
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Controls.Add(this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트, 0, 1);
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Location = new System.Drawing.Point(2, 24);
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Name = "Layout_OutSizeBasedBitrate_tableLayoutPanel";
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.RowCount = 2;
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.Size = new System.Drawing.Size(412, 76);
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.TabIndex = 0;
            // 
            // OutSizeBasedBitrate_textBox_원하는출력영상크기
            // 
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.BackColor = System.Drawing.SystemColors.Window;
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.Location = new System.Drawing.Point(268, 5);
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.MaxLength = 10;
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.Name = "OutSizeBasedBitrate_textBox_원하는출력영상크기";
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.Size = new System.Drawing.Size(85, 27);
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.TabIndex = 1;
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_textBox_원하는출력영상크기, "원본 영상을 재 인코딩 할 때 적용되는 출력 영상 크기를 설정합니다.");
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.Enter += new System.EventHandler(this.ControlEnter);
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OutSizeBasedBitrate_textBox_원하는출력영상크기.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기
            // 
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.AutoSize = true;
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.Controls.Add(this.OutSizeBasedBitrate_label_원하는출력영상크기);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.Controls.Add(this.OutSizeBasedBitrate_comboBox_원하는출력영상크기);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.Location = new System.Drawing.Point(19, 3);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.Name = "Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기";
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.Size = new System.Drawing.Size(245, 32);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.TabIndex = 0;
            this.Main_toolTip.SetToolTip(this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기, "원본 영상을 재 인코딩 할 때 적용되는 출력 영상 크기를 설정합니다.");
            // 
            // OutSizeBasedBitrate_label_원하는출력영상크기
            // 
            this.OutSizeBasedBitrate_label_원하는출력영상크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutSizeBasedBitrate_label_원하는출력영상크기.AutoSize = true;
            this.OutSizeBasedBitrate_label_원하는출력영상크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutSizeBasedBitrate_label_원하는출력영상크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutSizeBasedBitrate_label_원하는출력영상크기.Location = new System.Drawing.Point(2, 4);
            this.OutSizeBasedBitrate_label_원하는출력영상크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutSizeBasedBitrate_label_원하는출력영상크기.Name = "OutSizeBasedBitrate_label_원하는출력영상크기";
            this.OutSizeBasedBitrate_label_원하는출력영상크기.Size = new System.Drawing.Size(185, 23);
            this.OutSizeBasedBitrate_label_원하는출력영상크기.TabIndex = 0;
            this.OutSizeBasedBitrate_label_원하는출력영상크기.Text = "원하는 출력 영상 크기:";
            this.OutSizeBasedBitrate_label_원하는출력영상크기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_label_원하는출력영상크기, "원본 영상을 재 인코딩 할 때 적용되는 출력 영상 크기를 설정합니다.");
            // 
            // OutSizeBasedBitrate_comboBox_원하는출력영상크기
            // 
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.BackColor = System.Drawing.SystemColors.Window;
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.FormattingEnabled = true;
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.Location = new System.Drawing.Point(191, 2);
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.Name = "OutSizeBasedBitrate_comboBox_원하는출력영상크기";
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.Size = new System.Drawing.Size(52, 28);
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.TabIndex = 1;
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.Text = "MB";
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_comboBox_원하는출력영상크기, "원본 영상을 재 인코딩 할 때 적용되는 출력 영상 크기를 설정합니다.");
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.Enter += new System.EventHandler(this.ControlEnter);
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OutSizeBasedBitrate_comboBox_원하는출력영상크기.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트
            // 
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.AutoSize = true;
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Location = new System.Drawing.Point(268, 45);
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Name = "ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트";
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Size = new System.Drawing.Size(16, 23);
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.TabIndex = 3;
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Text = " ";
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_toolTip.SetToolTip(this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트, "원본 영상을 재 인코딩할 때 원하는 출력 영상 크기가 되도록 하는 영상 비트레이트 값입니다.\r\n클릭하면 값이 복사됩니다. (단축키: Ctrl+F)" +
        "");
            this.ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트.Click += new System.EventHandler(this.Copy예상영상비트레이트);
            // 
            // Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트
            // 
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.AutoSize = true;
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.Controls.Add(this.OutSizeBasedBitrate_label_예상영상비트레이트);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.Controls.Add(this.OutSizeBasedBitrate_comboBox_예상영상비트레이트);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.Location = new System.Drawing.Point(3, 41);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.Name = "Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트";
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.Size = new System.Drawing.Size(261, 32);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.TabIndex = 2;
            this.Main_toolTip.SetToolTip(this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트, "원본 영상을 재 인코딩할 때 원하는 출력 영상 크기가 되도록 하는 영상 비트레이트 값입니다.");
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.Click += new System.EventHandler(this.Copy예상영상비트레이트);
            // 
            // OutSizeBasedBitrate_label_예상영상비트레이트
            // 
            this.OutSizeBasedBitrate_label_예상영상비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutSizeBasedBitrate_label_예상영상비트레이트.AutoSize = true;
            this.OutSizeBasedBitrate_label_예상영상비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutSizeBasedBitrate_label_예상영상비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutSizeBasedBitrate_label_예상영상비트레이트.Location = new System.Drawing.Point(2, 4);
            this.OutSizeBasedBitrate_label_예상영상비트레이트.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutSizeBasedBitrate_label_예상영상비트레이트.Name = "OutSizeBasedBitrate_label_예상영상비트레이트";
            this.OutSizeBasedBitrate_label_예상영상비트레이트.Size = new System.Drawing.Size(179, 23);
            this.OutSizeBasedBitrate_label_예상영상비트레이트.TabIndex = 0;
            this.OutSizeBasedBitrate_label_예상영상비트레이트.Text = "예상 영상 비트레이트:";
            this.OutSizeBasedBitrate_label_예상영상비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_label_예상영상비트레이트, "원본 영상을 재 인코딩할 때 원하는 출력 영상 크기가 되도록 하는 영상 비트레이트 값입니다.\r\n클릭하면 값이 복사됩니다. (단축키: Ctrl+F)" +
        "");
            this.OutSizeBasedBitrate_label_예상영상비트레이트.Click += new System.EventHandler(this.Copy예상영상비트레이트);
            // 
            // OutSizeBasedBitrate_comboBox_예상영상비트레이트
            // 
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.FormattingEnabled = true;
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.Items.AddRange(new object[] {
            "Kbps",
            "Mbps"});
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.Location = new System.Drawing.Point(185, 2);
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.Name = "OutSizeBasedBitrate_comboBox_예상영상비트레이트";
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.Size = new System.Drawing.Size(74, 28);
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.TabIndex = 1;
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.Text = "Kbps";
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.Enter += new System.EventHandler(this.ControlEnter);
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OutSizeBasedBitrate_comboBox_예상영상비트레이트.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // Layout_ConvertResolution_groupBox
            // 
            this.Layout_ConvertResolution_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout_ConvertResolution_groupBox.Controls.Add(this.Layout_ConvertResolution_tableLayoutPanel);
            this.Layout_ConvertResolution_groupBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout_ConvertResolution_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Layout_ConvertResolution_groupBox.Location = new System.Drawing.Point(460, 117);
            this.Layout_ConvertResolution_groupBox.Margin = new System.Windows.Forms.Padding(2, 5, 6, 0);
            this.Layout_ConvertResolution_groupBox.Name = "Layout_ConvertResolution_groupBox";
            this.Layout_ConvertResolution_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.Layout_Main_tableLayoutPanel.SetRowSpan(this.Layout_ConvertResolution_groupBox, 2);
            this.Layout_ConvertResolution_groupBox.Size = new System.Drawing.Size(416, 215);
            this.Layout_ConvertResolution_groupBox.TabIndex = 3;
            this.Layout_ConvertResolution_groupBox.TabStop = false;
            this.Layout_ConvertResolution_groupBox.Text = "해상도 변환";
            this.Main_toolTip.SetToolTip(this.Layout_ConvertResolution_groupBox, "원본 영상의 화면 해상도를 변환 기준을 토대로 하여 동일한 비율로 확대하거나 축소합니다.");
            // 
            // Layout_ConvertResolution_tableLayoutPanel
            // 
            this.Layout_ConvertResolution_tableLayoutPanel.ColumnCount = 2;
            this.Layout_ConvertResolution_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.97619F));
            this.Layout_ConvertResolution_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.02381F));
            this.Layout_ConvertResolution_tableLayoutPanel.Controls.Add(this.ConvertResolution_label_현재해상도, 0, 0);
            this.Layout_ConvertResolution_tableLayoutPanel.Controls.Add(this.ConvertResolution_button_적용, 1, 4);
            this.Layout_ConvertResolution_tableLayoutPanel.Controls.Add(this.Layout_ConvertResolution_flowLayoutPanel_변환기준, 1, 1);
            this.Layout_ConvertResolution_tableLayoutPanel.Controls.Add(this.ConvertResolution_label_변환예상해상도, 0, 2);
            this.Layout_ConvertResolution_tableLayoutPanel.Controls.Add(this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도, 1, 2);
            this.Layout_ConvertResolution_tableLayoutPanel.Controls.Add(this.ConvertResolution_label_변환기준, 0, 1);
            this.Layout_ConvertResolution_tableLayoutPanel.Controls.Add(this.Layout_ConvertResolution_flowLayoutPanel_현재해상도, 1, 0);
            this.Layout_ConvertResolution_tableLayoutPanel.Controls.Add(this.ValuePrintLabel_ConvertResolution_변환예상크기, 1, 3);
            this.Layout_ConvertResolution_tableLayoutPanel.Controls.Add(this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기, 0, 3);
            this.Layout_ConvertResolution_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_ConvertResolution_tableLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Layout_ConvertResolution_tableLayoutPanel.Location = new System.Drawing.Point(2, 24);
            this.Layout_ConvertResolution_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_ConvertResolution_tableLayoutPanel.Name = "Layout_ConvertResolution_tableLayoutPanel";
            this.Layout_ConvertResolution_tableLayoutPanel.RowCount = 5;
            this.Layout_ConvertResolution_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_ConvertResolution_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_ConvertResolution_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_ConvertResolution_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout_ConvertResolution_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Layout_ConvertResolution_tableLayoutPanel.Size = new System.Drawing.Size(412, 189);
            this.Layout_ConvertResolution_tableLayoutPanel.TabIndex = 0;
            // 
            // ConvertResolution_label_현재해상도
            // 
            this.ConvertResolution_label_현재해상도.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConvertResolution_label_현재해상도.AutoSize = true;
            this.ConvertResolution_label_현재해상도.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_현재해상도.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_현재해상도.Location = new System.Drawing.Point(83, 7);
            this.ConvertResolution_label_현재해상도.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_현재해상도.Name = "ConvertResolution_label_현재해상도";
            this.ConvertResolution_label_현재해상도.Size = new System.Drawing.Size(133, 23);
            this.ConvertResolution_label_현재해상도.TabIndex = 0;
            this.ConvertResolution_label_현재해상도.Text = "현재 해상도(px):";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_현재해상도, "원본 영상 파일 정보에서 설정된 화면 해상도입니다.");
            // 
            // ConvertResolution_button_적용
            // 
            this.ConvertResolution_button_적용.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertResolution_button_적용.AutoSize = true;
            this.ConvertResolution_button_적용.Enabled = false;
            this.ConvertResolution_button_적용.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_button_적용.ForeColor = System.Drawing.Color.Black;
            this.ConvertResolution_button_적용.Location = new System.Drawing.Point(337, 151);
            this.ConvertResolution_button_적용.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.ConvertResolution_button_적용.Name = "ConvertResolution_button_적용";
            this.ConvertResolution_button_적용.Size = new System.Drawing.Size(70, 33);
            this.ConvertResolution_button_적용.TabIndex = 8;
            this.ConvertResolution_button_적용.Text = "적용";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_button_적용, "변환 예상 해상도를 원본 영상 파일 정보에 적용합니다. (단축키: Ctrl+S)");
            this.ConvertResolution_button_적용.UseVisualStyleBackColor = true;
            this.ConvertResolution_button_적용.Click += new System.EventHandler(this.Apply해상도변환);
            // 
            // Layout_ConvertResolution_flowLayoutPanel_변환기준
            // 
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.AutoSize = true;
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.Controls.Add(this.ConvertResolution_comboBox_기준);
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.Controls.Add(this.ConvertResolution_textBox_변환기준);
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.Location = new System.Drawing.Point(220, 39);
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.Name = "Layout_ConvertResolution_flowLayoutPanel_변환기준";
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.Size = new System.Drawing.Size(105, 32);
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.TabIndex = 3;
            this.Main_toolTip.SetToolTip(this.Layout_ConvertResolution_flowLayoutPanel_변환기준, "해상도 변환의 기준이 되는 해상도의 가로 길이 또는 세로 길이를 설정합니다.");
            // 
            // ConvertResolution_comboBox_기준
            // 
            this.ConvertResolution_comboBox_기준.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_comboBox_기준.BackColor = System.Drawing.SystemColors.Window;
            this.ConvertResolution_comboBox_기준.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ConvertResolution_comboBox_기준.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_comboBox_기준.FormattingEnabled = true;
            this.ConvertResolution_comboBox_기준.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConvertResolution_comboBox_기준.Items.AddRange(new object[] {
            "가로",
            "세로"});
            this.ConvertResolution_comboBox_기준.Location = new System.Drawing.Point(2, 2);
            this.ConvertResolution_comboBox_기준.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_comboBox_기준.Name = "ConvertResolution_comboBox_기준";
            this.ConvertResolution_comboBox_기준.Size = new System.Drawing.Size(58, 28);
            this.ConvertResolution_comboBox_기준.TabIndex = 0;
            this.ConvertResolution_comboBox_기준.Text = "가로";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_comboBox_기준, "해상도 변환의 기준이 되는 해상도의 가로 길이 또는 세로 길이를 설정합니다.");
            this.ConvertResolution_comboBox_기준.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.ConvertResolution_comboBox_기준.Enter += new System.EventHandler(this.ControlEnter);
            this.ConvertResolution_comboBox_기준.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.ConvertResolution_comboBox_기준.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // ConvertResolution_textBox_변환기준
            // 
            this.ConvertResolution_textBox_변환기준.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_textBox_변환기준.BackColor = System.Drawing.SystemColors.Window;
            this.ConvertResolution_textBox_변환기준.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ConvertResolution_textBox_변환기준.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_textBox_변환기준.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ConvertResolution_textBox_변환기준.Location = new System.Drawing.Point(64, 2);
            this.ConvertResolution_textBox_변환기준.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_textBox_변환기준.MaxLength = 4;
            this.ConvertResolution_textBox_변환기준.Name = "ConvertResolution_textBox_변환기준";
            this.ConvertResolution_textBox_변환기준.Size = new System.Drawing.Size(39, 27);
            this.ConvertResolution_textBox_변환기준.TabIndex = 1;
            this.ConvertResolution_textBox_변환기준.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.ConvertResolution_textBox_변환기준, "해상도 변환의 기준이 되는 해상도의 가로 길이 또는 세로 길이를 설정합니다.");
            this.ConvertResolution_textBox_변환기준.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.ConvertResolution_textBox_변환기준.Enter += new System.EventHandler(this.ControlEnter);
            this.ConvertResolution_textBox_변환기준.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.ConvertResolution_textBox_변환기준.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ConvertResolution_label_변환예상해상도
            // 
            this.ConvertResolution_label_변환예상해상도.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConvertResolution_label_변환예상해상도.AutoSize = true;
            this.ConvertResolution_label_변환예상해상도.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_변환예상해상도.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_변환예상해상도.Location = new System.Drawing.Point(43, 81);
            this.ConvertResolution_label_변환예상해상도.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_변환예상해상도.Name = "ConvertResolution_label_변환예상해상도";
            this.ConvertResolution_label_변환예상해상도.Size = new System.Drawing.Size(173, 23);
            this.ConvertResolution_label_변환예상해상도.TabIndex = 4;
            this.ConvertResolution_label_변환예상해상도.Text = "변환 예상 해상도(px):";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_변환예상해상도, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            // 
            // Layout_ConvertResolution_flowLayoutPanel_변환예상해상도
            // 
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.AutoSize = true;
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.Controls.Add(this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.Controls.Add(this.ConvertResolution_label_변환예상해상도_x);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.Controls.Add(this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.Location = new System.Drawing.Point(220, 81);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.Name = "Layout_ConvertResolution_flowLayoutPanel_변환예상해상도";
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.Size = new System.Drawing.Size(72, 23);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.TabIndex = 5;
            this.Main_toolTip.SetToolTip(this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            // 
            // ValuePrintLabel_ConvertResolution_변환예상해상도_가로
            // 
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.AutoSize = true;
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Location = new System.Drawing.Point(2, 0);
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Name = "ValuePrintLabel_ConvertResolution_변환예상해상도_가로";
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Size = new System.Drawing.Size(19, 23);
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.TabIndex = 0;
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.Text = "0";
            this.Main_toolTip.SetToolTip(this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_가로.TextChanged += new System.EventHandler(this.ControlTextChanged);
            // 
            // ConvertResolution_label_변환예상해상도_x
            // 
            this.ConvertResolution_label_변환예상해상도_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_변환예상해상도_x.AutoSize = true;
            this.ConvertResolution_label_변환예상해상도_x.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_변환예상해상도_x.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_변환예상해상도_x.Location = new System.Drawing.Point(25, 0);
            this.ConvertResolution_label_변환예상해상도_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_변환예상해상도_x.Name = "ConvertResolution_label_변환예상해상도_x";
            this.ConvertResolution_label_변환예상해상도_x.Size = new System.Drawing.Size(22, 23);
            this.ConvertResolution_label_변환예상해상도_x.TabIndex = 1;
            this.ConvertResolution_label_변환예상해상도_x.Text = "×";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_변환예상해상도_x, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            // 
            // ValuePrintLabel_ConvertResolution_변환예상해상도_세로
            // 
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.AutoSize = true;
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Location = new System.Drawing.Point(51, 0);
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Name = "ValuePrintLabel_ConvertResolution_변환예상해상도_세로";
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Size = new System.Drawing.Size(19, 23);
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.TabIndex = 2;
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.Text = "0";
            this.Main_toolTip.SetToolTip(this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            this.ValuePrintLabel_ConvertResolution_변환예상해상도_세로.TextChanged += new System.EventHandler(this.ControlTextChanged);
            // 
            // ConvertResolution_label_변환기준
            // 
            this.ConvertResolution_label_변환기준.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConvertResolution_label_변환기준.AutoSize = true;
            this.ConvertResolution_label_변환기준.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_변환기준.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_변환기준.Location = new System.Drawing.Point(100, 44);
            this.ConvertResolution_label_변환기준.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_변환기준.Name = "ConvertResolution_label_변환기준";
            this.ConvertResolution_label_변환기준.Size = new System.Drawing.Size(116, 23);
            this.ConvertResolution_label_변환기준.TabIndex = 2;
            this.ConvertResolution_label_변환기준.Text = "변환 기준(px):";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_변환기준, "해상도 변환의 기준이 되는 해상도의 가로 길이 또는 세로 길이를 설정합니다.");
            // 
            // Layout_ConvertResolution_flowLayoutPanel_현재해상도
            // 
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.AutoSize = true;
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.Controls.Add(this.ValuePrintLabel_ConvertResolution_현재해상도_가로);
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.Controls.Add(this.ConvertResolution_label_현재해상도_x);
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.Controls.Add(this.ValuePrintLabel_ConvertResolution_현재해상도_세로);
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.Location = new System.Drawing.Point(220, 7);
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.Name = "Layout_ConvertResolution_flowLayoutPanel_현재해상도";
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.Size = new System.Drawing.Size(72, 23);
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.TabIndex = 1;
            this.Main_toolTip.SetToolTip(this.Layout_ConvertResolution_flowLayoutPanel_현재해상도, "원본 영상 파일 정보에서 설정된 화면 해상도입니다.");
            // 
            // ValuePrintLabel_ConvertResolution_현재해상도_가로
            // 
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.AutoSize = true;
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.Location = new System.Drawing.Point(2, 0);
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.Name = "ValuePrintLabel_ConvertResolution_현재해상도_가로";
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.Size = new System.Drawing.Size(19, 23);
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.TabIndex = 0;
            this.ValuePrintLabel_ConvertResolution_현재해상도_가로.Text = "0";
            this.Main_toolTip.SetToolTip(this.ValuePrintLabel_ConvertResolution_현재해상도_가로, "원본 영상 파일 정보에서 설정된 화면 해상도입니다.");
            // 
            // ConvertResolution_label_현재해상도_x
            // 
            this.ConvertResolution_label_현재해상도_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_현재해상도_x.AutoSize = true;
            this.ConvertResolution_label_현재해상도_x.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_현재해상도_x.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_현재해상도_x.Location = new System.Drawing.Point(25, 0);
            this.ConvertResolution_label_현재해상도_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_현재해상도_x.Name = "ConvertResolution_label_현재해상도_x";
            this.ConvertResolution_label_현재해상도_x.Size = new System.Drawing.Size(22, 23);
            this.ConvertResolution_label_현재해상도_x.TabIndex = 1;
            this.ConvertResolution_label_현재해상도_x.Text = "×";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_현재해상도_x, "원본 영상 파일 정보에서 설정된 화면 해상도입니다.");
            // 
            // ValuePrintLabel_ConvertResolution_현재해상도_세로
            // 
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.AutoSize = true;
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.Location = new System.Drawing.Point(51, 0);
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.Name = "ValuePrintLabel_ConvertResolution_현재해상도_세로";
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.Size = new System.Drawing.Size(19, 23);
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.TabIndex = 2;
            this.ValuePrintLabel_ConvertResolution_현재해상도_세로.Text = "0";
            this.Main_toolTip.SetToolTip(this.ValuePrintLabel_ConvertResolution_현재해상도_세로, "원본 영상 파일 정보에서 설정된 화면 해상도입니다.");
            // 
            // ValuePrintLabel_ConvertResolution_변환예상크기
            // 
            this.ValuePrintLabel_ConvertResolution_변환예상크기.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ValuePrintLabel_ConvertResolution_변환예상크기.AutoSize = true;
            this.ValuePrintLabel_ConvertResolution_변환예상크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ValuePrintLabel_ConvertResolution_변환예상크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValuePrintLabel_ConvertResolution_변환예상크기.Location = new System.Drawing.Point(220, 118);
            this.ValuePrintLabel_ConvertResolution_변환예상크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePrintLabel_ConvertResolution_변환예상크기.Name = "ValuePrintLabel_ConvertResolution_변환예상크기";
            this.ValuePrintLabel_ConvertResolution_변환예상크기.Size = new System.Drawing.Size(16, 23);
            this.ValuePrintLabel_ConvertResolution_변환예상크기.TabIndex = 7;
            this.ValuePrintLabel_ConvertResolution_변환예상크기.Text = " ";
            this.Main_toolTip.SetToolTip(this.ValuePrintLabel_ConvertResolution_변환예상크기, "변환 예상 해상도로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // Layout_ConvertResolution_flowLayoutPanel_변환예상크기
            // 
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.AutoSize = true;
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.Controls.Add(this.ConvertResolution_label_변환예상크기);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.Controls.Add(this.ConvertResolution_comboBox_변환예상크기);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.Controls.Add(this.ConvertResolution_label_colon);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.Location = new System.Drawing.Point(16, 113);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.Name = "Layout_ConvertResolution_flowLayoutPanel_변환예상크기";
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.Size = new System.Drawing.Size(200, 32);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.TabIndex = 6;
            this.Main_toolTip.SetToolTip(this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기, "변환 예상 해상도로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // ConvertResolution_label_변환예상크기
            // 
            this.ConvertResolution_label_변환예상크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConvertResolution_label_변환예상크기.AutoSize = true;
            this.ConvertResolution_label_변환예상크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_변환예상크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_변환예상크기.Location = new System.Drawing.Point(2, 4);
            this.ConvertResolution_label_변환예상크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_변환예상크기.Name = "ConvertResolution_label_변환예상크기";
            this.ConvertResolution_label_변환예상크기.Size = new System.Drawing.Size(124, 23);
            this.ConvertResolution_label_변환예상크기.TabIndex = 0;
            this.ConvertResolution_label_변환예상크기.Text = "변환 예상 크기";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_변환예상크기, "변환 예상 해상도로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // ConvertResolution_comboBox_변환예상크기
            // 
            this.ConvertResolution_comboBox_변환예상크기.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ConvertResolution_comboBox_변환예상크기.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ConvertResolution_comboBox_변환예상크기.FormattingEnabled = true;
            this.ConvertResolution_comboBox_변환예상크기.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ConvertResolution_comboBox_변환예상크기.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.ConvertResolution_comboBox_변환예상크기.Location = new System.Drawing.Point(130, 2);
            this.ConvertResolution_comboBox_변환예상크기.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_comboBox_변환예상크기.Name = "ConvertResolution_comboBox_변환예상크기";
            this.ConvertResolution_comboBox_변환예상크기.Size = new System.Drawing.Size(52, 28);
            this.ConvertResolution_comboBox_변환예상크기.TabIndex = 1;
            this.ConvertResolution_comboBox_변환예상크기.Text = "MB";
            this.ConvertResolution_comboBox_변환예상크기.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.ConvertResolution_comboBox_변환예상크기.Enter += new System.EventHandler(this.ControlEnter);
            this.ConvertResolution_comboBox_변환예상크기.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.ConvertResolution_comboBox_변환예상크기.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // ConvertResolution_label_colon
            // 
            this.ConvertResolution_label_colon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_colon.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.ConvertResolution_label_colon.Location = new System.Drawing.Point(186, 4);
            this.ConvertResolution_label_colon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_colon.Name = "ConvertResolution_label_colon";
            this.ConvertResolution_label_colon.Size = new System.Drawing.Size(12, 24);
            this.ConvertResolution_label_colon.TabIndex = 2;
            this.ConvertResolution_label_colon.Text = ":";
            // 
            // Layout_OriginVidInfo_groupBox
            // 
            this.Layout_OriginVidInfo_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout_OriginVidInfo_groupBox.AutoSize = true;
            this.Layout_OriginVidInfo_groupBox.Controls.Add(this.Layout_OriginVidInfo_tableLayoutPanel);
            this.Layout_OriginVidInfo_groupBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout_OriginVidInfo_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Layout_OriginVidInfo_groupBox.Location = new System.Drawing.Point(5, 5);
            this.Layout_OriginVidInfo_groupBox.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.Layout_OriginVidInfo_groupBox.Name = "Layout_OriginVidInfo_groupBox";
            this.Layout_OriginVidInfo_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.Layout_Main_tableLayoutPanel.SetRowSpan(this.Layout_OriginVidInfo_groupBox, 2);
            this.Layout_OriginVidInfo_groupBox.Size = new System.Drawing.Size(450, 252);
            this.Layout_OriginVidInfo_groupBox.TabIndex = 0;
            this.Layout_OriginVidInfo_groupBox.TabStop = false;
            this.Layout_OriginVidInfo_groupBox.Text = "원본 영상 파일 정보";
            this.Main_toolTip.SetToolTip(this.Layout_OriginVidInfo_groupBox, "원본 영상 파일의 정보를 적습니다.");
            // 
            // Layout_OriginVidInfo_tableLayoutPanel
            // 
            this.Layout_OriginVidInfo_tableLayoutPanel.ColumnCount = 2;
            this.Layout_OriginVidInfo_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.05104F));
            this.Layout_OriginVidInfo_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.94896F));
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.OriginVidInfo_button_초기화, 1, 5);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.OriginVidInfo_label_적용코덱, 0, 4);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱, 1, 4);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.OriginVidInfo_label_오디오비트레이트, 0, 3);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.OriginVidInfo_label_초당프레임, 0, 2);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.OriginVidInfo_label_영상길이, 0, 0);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.OriginVidInfo_label_화면해상도, 0, 1);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트, 1, 3);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.Layout_OriginVidInfo_flowLayoutPanel_영상길이, 1, 0);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임, 1, 2);
            this.Layout_OriginVidInfo_tableLayoutPanel.Controls.Add(this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도, 1, 1);
            this.Layout_OriginVidInfo_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_OriginVidInfo_tableLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Layout_OriginVidInfo_tableLayoutPanel.Location = new System.Drawing.Point(2, 24);
            this.Layout_OriginVidInfo_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_OriginVidInfo_tableLayoutPanel.Name = "Layout_OriginVidInfo_tableLayoutPanel";
            this.Layout_OriginVidInfo_tableLayoutPanel.RowCount = 6;
            this.Layout_OriginVidInfo_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout_OriginVidInfo_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout_OriginVidInfo_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout_OriginVidInfo_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout_OriginVidInfo_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout_OriginVidInfo_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Layout_OriginVidInfo_tableLayoutPanel.Size = new System.Drawing.Size(446, 226);
            this.Layout_OriginVidInfo_tableLayoutPanel.TabIndex = 0;
            // 
            // OriginVidInfo_button_초기화
            // 
            this.OriginVidInfo_button_초기화.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OriginVidInfo_button_초기화.AutoSize = true;
            this.OriginVidInfo_button_초기화.Enabled = false;
            this.OriginVidInfo_button_초기화.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_button_초기화.ForeColor = System.Drawing.Color.Black;
            this.OriginVidInfo_button_초기화.Location = new System.Drawing.Point(351, 186);
            this.OriginVidInfo_button_초기화.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.OriginVidInfo_button_초기화.Name = "OriginVidInfo_button_초기화";
            this.OriginVidInfo_button_초기화.Size = new System.Drawing.Size(90, 35);
            this.OriginVidInfo_button_초기화.TabIndex = 10;
            this.OriginVidInfo_button_초기화.Text = "초기화";
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_button_초기화, "설정된 원본 영상 파일 정보를 초기화합니다. (단축키: Ctrl+W)");
            this.OriginVidInfo_button_초기화.UseVisualStyleBackColor = true;
            this.OriginVidInfo_button_초기화.Click += new System.EventHandler(this.Clear원본영상파일정보);
            // 
            // OriginVidInfo_label_적용코덱
            // 
            this.OriginVidInfo_label_적용코덱.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_적용코덱.AutoSize = true;
            this.OriginVidInfo_label_적용코덱.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_적용코덱.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_적용코덱.Location = new System.Drawing.Point(79, 155);
            this.OriginVidInfo_label_적용코덱.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_label_적용코덱.Name = "OriginVidInfo_label_적용코덱";
            this.OriginVidInfo_label_적용코덱.Size = new System.Drawing.Size(88, 23);
            this.OriginVidInfo_label_적용코덱.TabIndex = 8;
            this.OriginVidInfo_label_적용코덱.Text = "적용 코덱:";
            this.OriginVidInfo_label_적용코덱.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_적용코덱, "원본 영상을 재 인코딩 할 때 적용하려는 코덱입니다.");
            // 
            // Layout_OriginVidInfo_flowLayoutPanel_적용코덱
            // 
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.AutoSize = true;
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.Controls.Add(this.OriginVidInfo_comboBox_적용코덱);
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.Location = new System.Drawing.Point(171, 150);
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.Name = "Layout_OriginVidInfo_flowLayoutPanel_적용코덱";
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.Size = new System.Drawing.Size(87, 32);
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.TabIndex = 9;
            this.Main_toolTip.SetToolTip(this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱, "원본 영상을 재 인코딩 할 때 적용하려는 코덱입니다.");
            // 
            // OriginVidInfo_comboBox_적용코덱
            // 
            this.OriginVidInfo_comboBox_적용코덱.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_comboBox_적용코덱.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_comboBox_적용코덱.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_comboBox_적용코덱.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_comboBox_적용코덱.FormattingEnabled = true;
            this.OriginVidInfo_comboBox_적용코덱.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_comboBox_적용코덱.Items.AddRange(new object[] {
            "H.263",
            "H.264",
            "X264",
            "Xvid",
            "DivX",
            "MPEG-2",
            "MPEG-4"});
            this.OriginVidInfo_comboBox_적용코덱.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_comboBox_적용코덱.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_comboBox_적용코덱.Name = "OriginVidInfo_comboBox_적용코덱";
            this.OriginVidInfo_comboBox_적용코덱.Size = new System.Drawing.Size(83, 28);
            this.OriginVidInfo_comboBox_적용코덱.TabIndex = 0;
            this.OriginVidInfo_comboBox_적용코덱.Text = "H.264";
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_comboBox_적용코덱, "원본 영상을 재 인코딩 할 때 적용하려는 코덱입니다.");
            this.OriginVidInfo_comboBox_적용코덱.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_comboBox_적용코덱.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_comboBox_적용코덱.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_comboBox_적용코덱.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // OriginVidInfo_label_오디오비트레이트
            // 
            this.OriginVidInfo_label_오디오비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_오디오비트레이트.AutoSize = true;
            this.OriginVidInfo_label_오디오비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_오디오비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_오디오비트레이트.Location = new System.Drawing.Point(11, 118);
            this.OriginVidInfo_label_오디오비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_label_오디오비트레이트.Name = "OriginVidInfo_label_오디오비트레이트";
            this.OriginVidInfo_label_오디오비트레이트.Size = new System.Drawing.Size(156, 23);
            this.OriginVidInfo_label_오디오비트레이트.TabIndex = 6;
            this.OriginVidInfo_label_오디오비트레이트.Text = "오디오 비트레이트:";
            this.OriginVidInfo_label_오디오비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_오디오비트레이트, "원본 영상의 오디오 비트레이트입니다.");
            // 
            // OriginVidInfo_label_초당프레임
            // 
            this.OriginVidInfo_label_초당프레임.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_초당프레임.AutoSize = true;
            this.OriginVidInfo_label_초당프레임.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_초당프레임.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_초당프레임.Location = new System.Drawing.Point(62, 81);
            this.OriginVidInfo_label_초당프레임.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_label_초당프레임.Name = "OriginVidInfo_label_초당프레임";
            this.OriginVidInfo_label_초당프레임.Size = new System.Drawing.Size(105, 23);
            this.OriginVidInfo_label_초당프레임.TabIndex = 4;
            this.OriginVidInfo_label_초당프레임.Text = "초당 프레임:";
            this.OriginVidInfo_label_초당프레임.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_초당프레임, "원본 영상의 초당 프레임입니다.");
            // 
            // OriginVidInfo_label_영상길이
            // 
            this.OriginVidInfo_label_영상길이.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_영상길이.AutoSize = true;
            this.OriginVidInfo_label_영상길이.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_영상길이.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_영상길이.Location = new System.Drawing.Point(79, 7);
            this.OriginVidInfo_label_영상길이.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_label_영상길이.Name = "OriginVidInfo_label_영상길이";
            this.OriginVidInfo_label_영상길이.Size = new System.Drawing.Size(88, 23);
            this.OriginVidInfo_label_영상길이.TabIndex = 0;
            this.OriginVidInfo_label_영상길이.Text = "영상 길이:";
            this.OriginVidInfo_label_영상길이.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_영상길이, "원본 영상의 런타임 시간입니다.");
            // 
            // OriginVidInfo_label_화면해상도
            // 
            this.OriginVidInfo_label_화면해상도.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_화면해상도.AutoSize = true;
            this.OriginVidInfo_label_화면해상도.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_화면해상도.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_화면해상도.Location = new System.Drawing.Point(34, 44);
            this.OriginVidInfo_label_화면해상도.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_label_화면해상도.Name = "OriginVidInfo_label_화면해상도";
            this.OriginVidInfo_label_화면해상도.Size = new System.Drawing.Size(133, 23);
            this.OriginVidInfo_label_화면해상도.TabIndex = 2;
            this.OriginVidInfo_label_화면해상도.Text = "화면 해상도(px):";
            this.OriginVidInfo_label_화면해상도.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_화면해상도, "원본 영상의 화면 해상도입니다.");
            // 
            // Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트
            // 
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.AutoSize = true;
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.Controls.Add(this.OriginVidInfo_textBox_오디오비트레이트);
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.Controls.Add(this.OriginVidInfo_label_Kbps);
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.Location = new System.Drawing.Point(171, 114);
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.Name = "Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트";
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.Size = new System.Drawing.Size(85, 31);
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.TabIndex = 7;
            this.Main_toolTip.SetToolTip(this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트, "원본 영상의 오디오 비트레이트입니다.");
            // 
            // OriginVidInfo_textBox_오디오비트레이트
            // 
            this.OriginVidInfo_textBox_오디오비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_textBox_오디오비트레이트.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_오디오비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_오디오비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_오디오비트레이트.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_오디오비트레이트.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_textBox_오디오비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_오디오비트레이트.MaxLength = 3;
            this.OriginVidInfo_textBox_오디오비트레이트.Name = "OriginVidInfo_textBox_오디오비트레이트";
            this.OriginVidInfo_textBox_오디오비트레이트.Size = new System.Drawing.Size(30, 27);
            this.OriginVidInfo_textBox_오디오비트레이트.TabIndex = 0;
            this.OriginVidInfo_textBox_오디오비트레이트.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_오디오비트레이트, "원본 영상의 오디오 비트레이트입니다.");
            this.OriginVidInfo_textBox_오디오비트레이트.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_오디오비트레이트.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_오디오비트레이트.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_오디오비트레이트.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // OriginVidInfo_label_Kbps
            // 
            this.OriginVidInfo_label_Kbps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_label_Kbps.AutoSize = true;
            this.OriginVidInfo_label_Kbps.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_Kbps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_Kbps.Location = new System.Drawing.Point(36, 4);
            this.OriginVidInfo_label_Kbps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_Kbps.Name = "OriginVidInfo_label_Kbps";
            this.OriginVidInfo_label_Kbps.Size = new System.Drawing.Size(47, 23);
            this.OriginVidInfo_label_Kbps.TabIndex = 1;
            this.OriginVidInfo_label_Kbps.Text = "Kbps";
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_Kbps, "원본 영상의 오디오 비트레이트입니다.");
            // 
            // Layout_OriginVidInfo_flowLayoutPanel_영상길이
            // 
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.AutoSize = true;
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Controls.Add(this.OriginVidInfo_textBox_시간);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Controls.Add(this.OriginVidInfo_label_시간);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Controls.Add(this.OriginVidInfo_textBox_분);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Controls.Add(this.OriginVidInfo_label_분);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Controls.Add(this.OriginVidInfo_textBox_초);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Controls.Add(this.OriginVidInfo_label_초);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Location = new System.Drawing.Point(171, 3);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Name = "Layout_OriginVidInfo_flowLayoutPanel_영상길이";
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.Size = new System.Drawing.Size(210, 31);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.TabIndex = 1;
            this.Main_toolTip.SetToolTip(this.Layout_OriginVidInfo_flowLayoutPanel_영상길이, "원본 영상의 런타임 시간입니다.");
            // 
            // OriginVidInfo_textBox_시간
            // 
            this.OriginVidInfo_textBox_시간.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_시간.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_시간.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_시간.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_시간.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_textBox_시간.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_시간.MaxLength = 3;
            this.OriginVidInfo_textBox_시간.Name = "OriginVidInfo_textBox_시간";
            this.OriginVidInfo_textBox_시간.Size = new System.Drawing.Size(30, 27);
            this.OriginVidInfo_textBox_시간.TabIndex = 0;
            this.OriginVidInfo_textBox_시간.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_시간, "원본 영상의 런타임 시간입니다.");
            this.OriginVidInfo_textBox_시간.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_시간.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_시간.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_시간.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // OriginVidInfo_label_시간
            // 
            this.OriginVidInfo_label_시간.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_label_시간.AutoSize = true;
            this.OriginVidInfo_label_시간.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_시간.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_시간.Location = new System.Drawing.Point(36, 4);
            this.OriginVidInfo_label_시간.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_시간.Name = "OriginVidInfo_label_시간";
            this.OriginVidInfo_label_시간.Size = new System.Drawing.Size(50, 23);
            this.OriginVidInfo_label_시간.TabIndex = 1;
            this.OriginVidInfo_label_시간.Text = "시간 ";
            this.OriginVidInfo_label_시간.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_시간, "원본 영상의 런타임 시간입니다.");
            // 
            // OriginVidInfo_textBox_분
            // 
            this.OriginVidInfo_textBox_분.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_분.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_분.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_분.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_분.Location = new System.Drawing.Point(90, 2);
            this.OriginVidInfo_textBox_분.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_분.MaxLength = 2;
            this.OriginVidInfo_textBox_분.Name = "OriginVidInfo_textBox_분";
            this.OriginVidInfo_textBox_분.Size = new System.Drawing.Size(23, 27);
            this.OriginVidInfo_textBox_분.TabIndex = 2;
            this.OriginVidInfo_textBox_분.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_분, "원본 영상의 런타임 시간입니다.");
            this.OriginVidInfo_textBox_분.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_분.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_분.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_분.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // OriginVidInfo_label_분
            // 
            this.OriginVidInfo_label_분.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_label_분.AutoSize = true;
            this.OriginVidInfo_label_분.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_분.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_분.Location = new System.Drawing.Point(117, 4);
            this.OriginVidInfo_label_분.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_분.Name = "OriginVidInfo_label_분";
            this.OriginVidInfo_label_분.Size = new System.Drawing.Size(33, 23);
            this.OriginVidInfo_label_분.TabIndex = 3;
            this.OriginVidInfo_label_분.Text = "분 ";
            this.OriginVidInfo_label_분.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_분, "원본 영상의 런타임 시간입니다.");
            // 
            // OriginVidInfo_textBox_초
            // 
            this.OriginVidInfo_textBox_초.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_초.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_초.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_초.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_초.Location = new System.Drawing.Point(154, 2);
            this.OriginVidInfo_textBox_초.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_초.MaxLength = 2;
            this.OriginVidInfo_textBox_초.Name = "OriginVidInfo_textBox_초";
            this.OriginVidInfo_textBox_초.Size = new System.Drawing.Size(23, 27);
            this.OriginVidInfo_textBox_초.TabIndex = 4;
            this.OriginVidInfo_textBox_초.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_초, "원본 영상의 런타임 시간입니다.");
            this.OriginVidInfo_textBox_초.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_초.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_초.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_초.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // OriginVidInfo_label_초
            // 
            this.OriginVidInfo_label_초.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_label_초.AutoSize = true;
            this.OriginVidInfo_label_초.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_초.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_초.Location = new System.Drawing.Point(181, 4);
            this.OriginVidInfo_label_초.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_초.Name = "OriginVidInfo_label_초";
            this.OriginVidInfo_label_초.Size = new System.Drawing.Size(27, 23);
            this.OriginVidInfo_label_초.TabIndex = 5;
            this.OriginVidInfo_label_초.Text = "초";
            this.OriginVidInfo_label_초.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_초, "원본 영상의 런타임 시간입니다.");
            // 
            // Layout_OriginVidInfo_flowLayoutPanel_초당프레임
            // 
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.AutoSize = true;
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.Controls.Add(this.OriginVidInfo_textBox_초당프레임);
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.Controls.Add(this.OriginVidInfo_label_FPS);
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.Location = new System.Drawing.Point(171, 77);
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.Name = "Layout_OriginVidInfo_flowLayoutPanel_초당프레임";
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.Size = new System.Drawing.Size(84, 31);
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.TabIndex = 5;
            this.Main_toolTip.SetToolTip(this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임, "원본 영상의 초당 프레임입니다.");
            // 
            // OriginVidInfo_textBox_초당프레임
            // 
            this.OriginVidInfo_textBox_초당프레임.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_textBox_초당프레임.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_초당프레임.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_초당프레임.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_초당프레임.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_초당프레임.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_textBox_초당프레임.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_초당프레임.MaxLength = 4;
            this.OriginVidInfo_textBox_초당프레임.Name = "OriginVidInfo_textBox_초당프레임";
            this.OriginVidInfo_textBox_초당프레임.Size = new System.Drawing.Size(39, 27);
            this.OriginVidInfo_textBox_초당프레임.TabIndex = 0;
            this.OriginVidInfo_textBox_초당프레임.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_초당프레임, "원본 영상의 초당 프레임입니다.");
            this.OriginVidInfo_textBox_초당프레임.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_초당프레임.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_초당프레임.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_초당프레임.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // OriginVidInfo_label_FPS
            // 
            this.OriginVidInfo_label_FPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_label_FPS.AutoSize = true;
            this.OriginVidInfo_label_FPS.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_FPS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_FPS.Location = new System.Drawing.Point(45, 4);
            this.OriginVidInfo_label_FPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_FPS.Name = "OriginVidInfo_label_FPS";
            this.OriginVidInfo_label_FPS.Size = new System.Drawing.Size(37, 23);
            this.OriginVidInfo_label_FPS.TabIndex = 1;
            this.OriginVidInfo_label_FPS.Text = "FPS";
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_FPS, "원본 영상의 초당 프레임입니다.");
            // 
            // Layout_OriginVidInfo_flowLayoutPanel_화면해상도
            // 
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.AutoSize = true;
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.Controls.Add(this.OriginVidInfo_textBox_화면해상도_가로);
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.Controls.Add(this.OriginVidInfo_label_x);
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.Controls.Add(this.OriginVidInfo_textBox_화면해상도_세로);
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.Location = new System.Drawing.Point(171, 40);
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.Name = "Layout_OriginVidInfo_flowLayoutPanel_화면해상도";
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.Size = new System.Drawing.Size(112, 31);
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.TabIndex = 3;
            // 
            // OriginVidInfo_textBox_화면해상도_가로
            // 
            this.OriginVidInfo_textBox_화면해상도_가로.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_화면해상도_가로.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_화면해상도_가로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_화면해상도_가로.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_화면해상도_가로.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_textBox_화면해상도_가로.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_화면해상도_가로.MaxLength = 4;
            this.OriginVidInfo_textBox_화면해상도_가로.Name = "OriginVidInfo_textBox_화면해상도_가로";
            this.OriginVidInfo_textBox_화면해상도_가로.Size = new System.Drawing.Size(39, 27);
            this.OriginVidInfo_textBox_화면해상도_가로.TabIndex = 0;
            this.OriginVidInfo_textBox_화면해상도_가로.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_화면해상도_가로, "원본 영상 화면 해상도의 가로 길이입니다.");
            this.OriginVidInfo_textBox_화면해상도_가로.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_화면해상도_가로.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_화면해상도_가로.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_화면해상도_가로.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // OriginVidInfo_label_x
            // 
            this.OriginVidInfo_label_x.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_label_x.AutoSize = true;
            this.OriginVidInfo_label_x.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_x.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_x.Location = new System.Drawing.Point(45, 4);
            this.OriginVidInfo_label_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_x.Name = "OriginVidInfo_label_x";
            this.OriginVidInfo_label_x.Size = new System.Drawing.Size(22, 23);
            this.OriginVidInfo_label_x.TabIndex = 2;
            this.OriginVidInfo_label_x.Text = "×";
            this.OriginVidInfo_label_x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OriginVidInfo_textBox_화면해상도_세로
            // 
            this.OriginVidInfo_textBox_화면해상도_세로.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_화면해상도_세로.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_화면해상도_세로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_화면해상도_세로.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_화면해상도_세로.Location = new System.Drawing.Point(71, 2);
            this.OriginVidInfo_textBox_화면해상도_세로.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_화면해상도_세로.MaxLength = 4;
            this.OriginVidInfo_textBox_화면해상도_세로.Name = "OriginVidInfo_textBox_화면해상도_세로";
            this.OriginVidInfo_textBox_화면해상도_세로.Size = new System.Drawing.Size(39, 27);
            this.OriginVidInfo_textBox_화면해상도_세로.TabIndex = 3;
            this.OriginVidInfo_textBox_화면해상도_세로.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_화면해상도_세로, "원본 영상 화면 해상도의 세로 길이입니다.");
            this.OriginVidInfo_textBox_화면해상도_세로.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_화면해상도_세로.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_화면해상도_세로.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_화면해상도_세로.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Layout_Bitrate_groupBox
            // 
            this.Layout_Bitrate_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout_Bitrate_groupBox.AutoSize = true;
            this.Layout_Bitrate_groupBox.Controls.Add(this.Layout_Bitrate_tableLayoutPanel);
            this.Layout_Bitrate_groupBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout_Bitrate_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Layout_Bitrate_groupBox.Location = new System.Drawing.Point(5, 267);
            this.Layout_Bitrate_groupBox.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.Layout_Bitrate_groupBox.Name = "Layout_Bitrate_groupBox";
            this.Layout_Bitrate_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.Layout_Main_tableLayoutPanel.SetRowSpan(this.Layout_Bitrate_groupBox, 2);
            this.Layout_Bitrate_groupBox.Size = new System.Drawing.Size(450, 106);
            this.Layout_Bitrate_groupBox.TabIndex = 1;
            this.Layout_Bitrate_groupBox.TabStop = false;
            this.Layout_Bitrate_groupBox.Text = "영상 비트레이트";
            this.Main_toolTip.SetToolTip(this.Layout_Bitrate_groupBox, "최대 영상 비트레이트와 예상 출력 영상 크기를 보여줍니다.");
            // 
            // Layout_Bitrate_tableLayoutPanel
            // 
            this.Layout_Bitrate_tableLayoutPanel.ColumnCount = 2;
            this.Layout_Bitrate_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.08969F));
            this.Layout_Bitrate_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.91031F));
            this.Layout_Bitrate_tableLayoutPanel.Controls.Add(this.ValuePrintLabel_Bitrate_예상출력영상크기, 1, 1);
            this.Layout_Bitrate_tableLayoutPanel.Controls.Add(this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기, 0, 1);
            this.Layout_Bitrate_tableLayoutPanel.Controls.Add(this.ValuePrintLabel_Bitrate_최대영상비트레이트, 1, 0);
            this.Layout_Bitrate_tableLayoutPanel.Controls.Add(this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트, 0, 0);
            this.Layout_Bitrate_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout_Bitrate_tableLayoutPanel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout_Bitrate_tableLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Layout_Bitrate_tableLayoutPanel.Location = new System.Drawing.Point(2, 24);
            this.Layout_Bitrate_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_Bitrate_tableLayoutPanel.Name = "Layout_Bitrate_tableLayoutPanel";
            this.Layout_Bitrate_tableLayoutPanel.RowCount = 2;
            this.Layout_Bitrate_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_Bitrate_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout_Bitrate_tableLayoutPanel.Size = new System.Drawing.Size(446, 80);
            this.Layout_Bitrate_tableLayoutPanel.TabIndex = 0;
            // 
            // ValuePrintLabel_Bitrate_예상출력영상크기
            // 
            this.ValuePrintLabel_Bitrate_예상출력영상크기.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ValuePrintLabel_Bitrate_예상출력영상크기.AutoSize = true;
            this.ValuePrintLabel_Bitrate_예상출력영상크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ValuePrintLabel_Bitrate_예상출력영상크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValuePrintLabel_Bitrate_예상출력영상크기.Location = new System.Drawing.Point(270, 48);
            this.ValuePrintLabel_Bitrate_예상출력영상크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePrintLabel_Bitrate_예상출력영상크기.Name = "ValuePrintLabel_Bitrate_예상출력영상크기";
            this.ValuePrintLabel_Bitrate_예상출력영상크기.Size = new System.Drawing.Size(16, 23);
            this.ValuePrintLabel_Bitrate_예상출력영상크기.TabIndex = 3;
            this.ValuePrintLabel_Bitrate_예상출력영상크기.Text = " ";
            this.ValuePrintLabel_Bitrate_예상출력영상크기.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_toolTip.SetToolTip(this.ValuePrintLabel_Bitrate_예상출력영상크기, "최대 영상 비트레이트로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // Layout_Bitrate_flowLayoutPanel_예상출력영상크기
            // 
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.AutoSize = true;
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.Controls.Add(this.Bitrate_label_예상출력영상크기);
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.Controls.Add(this.Bitrate_comboBox_예상출력영상크기);
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.Location = new System.Drawing.Point(38, 44);
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.Name = "Layout_Bitrate_flowLayoutPanel_예상출력영상크기";
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.Size = new System.Drawing.Size(228, 32);
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.TabIndex = 2;
            this.Main_toolTip.SetToolTip(this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기, "최대 영상 비트레이트로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // Bitrate_label_예상출력영상크기
            // 
            this.Bitrate_label_예상출력영상크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bitrate_label_예상출력영상크기.AutoSize = true;
            this.Bitrate_label_예상출력영상크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bitrate_label_예상출력영상크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bitrate_label_예상출력영상크기.Location = new System.Drawing.Point(2, 4);
            this.Bitrate_label_예상출력영상크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bitrate_label_예상출력영상크기.Name = "Bitrate_label_예상출력영상크기";
            this.Bitrate_label_예상출력영상크기.Size = new System.Drawing.Size(168, 23);
            this.Bitrate_label_예상출력영상크기.TabIndex = 1;
            this.Bitrate_label_예상출력영상크기.Text = "예상 출력 영상 크기:";
            this.Bitrate_label_예상출력영상크기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.Bitrate_label_예상출력영상크기, "최대 영상 비트레이트로 원본 영상을 재 인코딩할 때 예상되는 출력 영상의 크기입니다.");
            // 
            // Bitrate_comboBox_예상출력영상크기
            // 
            this.Bitrate_comboBox_예상출력영상크기.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Bitrate_comboBox_예상출력영상크기.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Bitrate_comboBox_예상출력영상크기.FormattingEnabled = true;
            this.Bitrate_comboBox_예상출력영상크기.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Bitrate_comboBox_예상출력영상크기.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.Bitrate_comboBox_예상출력영상크기.Location = new System.Drawing.Point(174, 2);
            this.Bitrate_comboBox_예상출력영상크기.Margin = new System.Windows.Forms.Padding(2);
            this.Bitrate_comboBox_예상출력영상크기.Name = "Bitrate_comboBox_예상출력영상크기";
            this.Bitrate_comboBox_예상출력영상크기.Size = new System.Drawing.Size(52, 28);
            this.Bitrate_comboBox_예상출력영상크기.TabIndex = 2;
            this.Bitrate_comboBox_예상출력영상크기.Text = "MB";
            this.Bitrate_comboBox_예상출력영상크기.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.Bitrate_comboBox_예상출력영상크기.Enter += new System.EventHandler(this.ControlEnter);
            this.Bitrate_comboBox_예상출력영상크기.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.Bitrate_comboBox_예상출력영상크기.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // ValuePrintLabel_Bitrate_최대영상비트레이트
            // 
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.AutoSize = true;
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.Location = new System.Drawing.Point(270, 8);
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.Name = "ValuePrintLabel_Bitrate_최대영상비트레이트";
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.Size = new System.Drawing.Size(16, 23);
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.TabIndex = 1;
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.Text = " ";
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_toolTip.SetToolTip(this.ValuePrintLabel_Bitrate_최대영상비트레이트, "원본 영상 파일 정보를 토대로 계산된 최대 품질의 영상으로 인코딩 할 수 있는 영상 비트레이트 값입니다.\r\n이 이상의 영상 비트레이트 값은 출력 " +
        "영상 품질에 영향을 끼치지 않습니다.\r\n클릭하면 값이 복사됩니다. (단축키: Ctrl+D)");
            this.ValuePrintLabel_Bitrate_최대영상비트레이트.Click += new System.EventHandler(this.Copy최대영상비트레이트);
            // 
            // Layout_Bitrate_flowLayoutPanel_최대영상비트레이트
            // 
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.AutoSize = true;
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.Controls.Add(this.Bitrate_label_최대영상비트레이트);
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.Controls.Add(this.Bitrate_comboBox_최대영상비트레이트);
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.Location = new System.Drawing.Point(5, 4);
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.Name = "Layout_Bitrate_flowLayoutPanel_최대영상비트레이트";
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.Size = new System.Drawing.Size(261, 32);
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.TabIndex = 0;
            this.Main_toolTip.SetToolTip(this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트, "원본 영상 파일 정보를 토대로 계산된 최대 품질의 영상으로 인코딩 할 수 있는 영상 비트레이트 값입니다.\r\n이 이상의 영상 비트레이트 값은 출력 " +
        "영상 품질에 영향을 끼치지 않습니다.");
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.Click += new System.EventHandler(this.Copy최대영상비트레이트);
            // 
            // Bitrate_label_최대영상비트레이트
            // 
            this.Bitrate_label_최대영상비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bitrate_label_최대영상비트레이트.AutoSize = true;
            this.Bitrate_label_최대영상비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bitrate_label_최대영상비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bitrate_label_최대영상비트레이트.Location = new System.Drawing.Point(2, 4);
            this.Bitrate_label_최대영상비트레이트.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bitrate_label_최대영상비트레이트.Name = "Bitrate_label_최대영상비트레이트";
            this.Bitrate_label_최대영상비트레이트.Size = new System.Drawing.Size(179, 23);
            this.Bitrate_label_최대영상비트레이트.TabIndex = 0;
            this.Bitrate_label_최대영상비트레이트.Text = "최대 영상 비트레이트:";
            this.Bitrate_label_최대영상비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.Bitrate_label_최대영상비트레이트, "원본 영상 파일 정보를 토대로 계산된 최대 품질의 영상으로 인코딩 할 수 있는 영상 비트레이트 값입니다.\r\n이 이상의 영상 비트레이트 값은 출력 " +
        "영상 품질에 영향을 끼치지 않습니다.\r\n클릭하면 값이 복사됩니다. (단축키: Ctrl+D)");
            this.Bitrate_label_최대영상비트레이트.Click += new System.EventHandler(this.Copy최대영상비트레이트);
            // 
            // Bitrate_comboBox_최대영상비트레이트
            // 
            this.Bitrate_comboBox_최대영상비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Bitrate_comboBox_최대영상비트레이트.FormattingEnabled = true;
            this.Bitrate_comboBox_최대영상비트레이트.Items.AddRange(new object[] {
            "Kbps",
            "Mbps"});
            this.Bitrate_comboBox_최대영상비트레이트.Location = new System.Drawing.Point(185, 2);
            this.Bitrate_comboBox_최대영상비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.Bitrate_comboBox_최대영상비트레이트.Name = "Bitrate_comboBox_최대영상비트레이트";
            this.Bitrate_comboBox_최대영상비트레이트.Size = new System.Drawing.Size(74, 28);
            this.Bitrate_comboBox_최대영상비트레이트.TabIndex = 3;
            this.Bitrate_comboBox_최대영상비트레이트.Text = "Kbps";
            this.Bitrate_comboBox_최대영상비트레이트.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.Bitrate_comboBox_최대영상비트레이트.Enter += new System.EventHandler(this.ControlEnter);
            this.Bitrate_comboBox_최대영상비트레이트.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.Bitrate_comboBox_최대영상비트레이트.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // Layout_Main_tableLayoutPanel_Buttons
            // 
            this.Layout_Main_tableLayoutPanel_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout_Main_tableLayoutPanel_Buttons.AutoSize = true;
            this.Layout_Main_tableLayoutPanel_Buttons.ColumnCount = 2;
            this.Layout_Main_tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.23088F));
            this.Layout_Main_tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.76912F));
            this.Layout_Main_tableLayoutPanel_Buttons.Controls.Add(this.Layout_Main_flowLayoutPanel_버튼_Right, 1, 0);
            this.Layout_Main_tableLayoutPanel_Buttons.Controls.Add(this.Layout_Main_flowLayoutPanel_버튼_left, 0, 0);
            this.Layout_Main_tableLayoutPanel_Buttons.Location = new System.Drawing.Point(458, 332);
            this.Layout_Main_tableLayoutPanel_Buttons.Margin = new System.Windows.Forms.Padding(0);
            this.Layout_Main_tableLayoutPanel_Buttons.Name = "Layout_Main_tableLayoutPanel_Buttons";
            this.Layout_Main_tableLayoutPanel_Buttons.RowCount = 1;
            this.Layout_Main_tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout_Main_tableLayoutPanel_Buttons.Size = new System.Drawing.Size(424, 46);
            this.Layout_Main_tableLayoutPanel_Buttons.TabIndex = 4;
            // 
            // Layout_Main_flowLayoutPanel_버튼_Right
            // 
            this.Layout_Main_flowLayoutPanel_버튼_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Layout_Main_flowLayoutPanel_버튼_Right.AutoSize = true;
            this.Layout_Main_flowLayoutPanel_버튼_Right.Controls.Add(this.Main_button_모두초기화);
            this.Layout_Main_flowLayoutPanel_버튼_Right.Controls.Add(this.Main_button_종료);
            this.Layout_Main_flowLayoutPanel_버튼_Right.Location = new System.Drawing.Point(184, 6);
            this.Layout_Main_flowLayoutPanel_버튼_Right.Margin = new System.Windows.Forms.Padding(5);
            this.Layout_Main_flowLayoutPanel_버튼_Right.Name = "Layout_Main_flowLayoutPanel_버튼_Right";
            this.Layout_Main_flowLayoutPanel_버튼_Right.Size = new System.Drawing.Size(235, 35);
            this.Layout_Main_flowLayoutPanel_버튼_Right.TabIndex = 1;
            // 
            // Main_button_모두초기화
            // 
            this.Main_button_모두초기화.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_button_모두초기화.Enabled = false;
            this.Main_button_모두초기화.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Main_button_모두초기화.Location = new System.Drawing.Point(0, 0);
            this.Main_button_모두초기화.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Main_button_모두초기화.Name = "Main_button_모두초기화";
            this.Main_button_모두초기화.Size = new System.Drawing.Size(150, 35);
            this.Main_button_모두초기화.TabIndex = 0;
            this.Main_button_모두초기화.Text = "모두 초기화";
            this.Main_toolTip.SetToolTip(this.Main_button_모두초기화, "설정된 모든 값을 초기화합니다. (단축키: Ctrl+R)");
            this.Main_button_모두초기화.UseVisualStyleBackColor = true;
            this.Main_button_모두초기화.Click += new System.EventHandler(this.ClearAll);
            // 
            // Main_button_종료
            // 
            this.Main_button_종료.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_button_종료.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Main_button_종료.Location = new System.Drawing.Point(155, 0);
            this.Main_button_종료.Margin = new System.Windows.Forms.Padding(0);
            this.Main_button_종료.Name = "Main_button_종료";
            this.Main_button_종료.Size = new System.Drawing.Size(80, 35);
            this.Main_button_종료.TabIndex = 1;
            this.Main_button_종료.Text = "종료";
            this.Main_toolTip.SetToolTip(this.Main_button_종료, "프로그램을 종료합니다.");
            this.Main_button_종료.UseVisualStyleBackColor = true;
            this.Main_button_종료.Click += new System.EventHandler(this.ToolStripMenuItem_종료_Click);
            // 
            // Layout_Main_flowLayoutPanel_버튼_left
            // 
            this.Layout_Main_flowLayoutPanel_버튼_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Layout_Main_flowLayoutPanel_버튼_left.AutoSize = true;
            this.Layout_Main_flowLayoutPanel_버튼_left.Controls.Add(this.Main_button_제작자);
            this.Layout_Main_flowLayoutPanel_버튼_left.Location = new System.Drawing.Point(5, 6);
            this.Layout_Main_flowLayoutPanel_버튼_left.Margin = new System.Windows.Forms.Padding(5);
            this.Layout_Main_flowLayoutPanel_버튼_left.Name = "Layout_Main_flowLayoutPanel_버튼_left";
            this.Layout_Main_flowLayoutPanel_버튼_left.Size = new System.Drawing.Size(100, 35);
            this.Layout_Main_flowLayoutPanel_버튼_left.TabIndex = 0;
            // 
            // Main_button_제작자
            // 
            this.Main_button_제작자.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Main_button_제작자.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Main_button_제작자.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Main_button_제작자.Location = new System.Drawing.Point(0, 0);
            this.Main_button_제작자.Margin = new System.Windows.Forms.Padding(0);
            this.Main_button_제작자.Name = "Main_button_제작자";
            this.Main_button_제작자.Size = new System.Drawing.Size(100, 35);
            this.Main_button_제작자.TabIndex = 0;
            this.Main_button_제작자.Text = "제작자";
            this.Main_button_제작자.UseVisualStyleBackColor = true;
            this.Main_button_제작자.Click += new System.EventHandler(this.ToolStripMenuItem_제작자_Click);
            // 
            // Main_toolTip
            // 
            this.Main_toolTip.AutoPopDelay = 86400000;
            this.Main_toolTip.InitialDelay = 500;
            this.Main_toolTip.ReshowDelay = 100;
            // 
            // Main_statusStrip
            // 
            this.Main_statusStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.Main_statusStrip.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Main_statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Main_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ValuePrintLabel_Main_status});
            this.Main_statusStrip.Location = new System.Drawing.Point(0, 404);
            this.Main_statusStrip.Name = "Main_statusStrip";
            this.Main_statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.Main_statusStrip.Size = new System.Drawing.Size(882, 29);
            this.Main_statusStrip.SizingGrip = false;
            this.Main_statusStrip.TabIndex = 2;
            this.Main_statusStrip.Text = "statusStrip";
            // 
            // ValuePrintLabel_Main_status
            // 
            this.ValuePrintLabel_Main_status.Name = "ValuePrintLabel_Main_status";
            this.ValuePrintLabel_Main_status.Size = new System.Drawing.Size(16, 23);
            this.ValuePrintLabel_Main_status.Text = " ";
            // 
            // Main_timer
            // 
            this.Main_timer.Interval = 3000;
            // 
            // ToolStripMenuItem_메뉴
            // 
            this.ToolStripMenuItem_메뉴.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_해상도변환적용,
            this.ToolStripMenuItem_원본영상파일정보초기화,
            this.ToolStripMenuItem_모두초기화,
            this.ToolStripSeparator_메뉴1,
            this.ToolStripMenuItem_최대영상비트레이트복사,
            this.ToolStripMenuItem_예상영상비트레이트복사,
            this.ToolStripMenuItem_표시소수점정밀도설정,
            this.ToolStripSeparator_메뉴2,
            this.ToolStripMenuItem_종료});
            this.ToolStripMenuItem_메뉴.Name = "ToolStripMenuItem_메뉴";
            this.ToolStripMenuItem_메뉴.Size = new System.Drawing.Size(77, 24);
            this.ToolStripMenuItem_메뉴.Text = "메뉴(&M)";
            // 
            // ToolStripMenuItem_해상도변환적용
            // 
            this.ToolStripMenuItem_해상도변환적용.Enabled = false;
            this.ToolStripMenuItem_해상도변환적용.Name = "ToolStripMenuItem_해상도변환적용";
            this.ToolStripMenuItem_해상도변환적용.Size = new System.Drawing.Size(364, 26);
            this.ToolStripMenuItem_해상도변환적용.Text = "해상도 변환 적용(&S)                  Ctrl+S";
            this.ToolStripMenuItem_해상도변환적용.Click += new System.EventHandler(this.Apply해상도변환);
            // 
            // ToolStripMenuItem_원본영상파일정보초기화
            // 
            this.ToolStripMenuItem_원본영상파일정보초기화.Enabled = false;
            this.ToolStripMenuItem_원본영상파일정보초기화.Name = "ToolStripMenuItem_원본영상파일정보초기화";
            this.ToolStripMenuItem_원본영상파일정보초기화.Size = new System.Drawing.Size(364, 26);
            this.ToolStripMenuItem_원본영상파일정보초기화.Text = "원본 영상 파일 정보 초기화(&W)  Ctrl+W";
            this.ToolStripMenuItem_원본영상파일정보초기화.Click += new System.EventHandler(this.Clear원본영상파일정보);
            // 
            // ToolStripMenuItem_모두초기화
            // 
            this.ToolStripMenuItem_모두초기화.Enabled = false;
            this.ToolStripMenuItem_모두초기화.Name = "ToolStripMenuItem_모두초기화";
            this.ToolStripMenuItem_모두초기화.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_모두초기화.Size = new System.Drawing.Size(364, 26);
            this.ToolStripMenuItem_모두초기화.Text = "모두 초기화(&R)                         Ctrl+R";
            this.ToolStripMenuItem_모두초기화.Click += new System.EventHandler(this.ClearAll);
            // 
            // ToolStripSeparator_메뉴1
            // 
            this.ToolStripSeparator_메뉴1.Name = "ToolStripSeparator_메뉴1";
            this.ToolStripSeparator_메뉴1.Size = new System.Drawing.Size(361, 6);
            // 
            // ToolStripMenuItem_최대영상비트레이트복사
            // 
            this.ToolStripMenuItem_최대영상비트레이트복사.Name = "ToolStripMenuItem_최대영상비트레이트복사";
            this.ToolStripMenuItem_최대영상비트레이트복사.Size = new System.Drawing.Size(364, 26);
            this.ToolStripMenuItem_최대영상비트레이트복사.Text = "최대 영상 비트레이트 복사(&D)     Ctrl+D";
            this.ToolStripMenuItem_최대영상비트레이트복사.Click += new System.EventHandler(this.Copy최대영상비트레이트);
            // 
            // ToolStripMenuItem_예상영상비트레이트복사
            // 
            this.ToolStripMenuItem_예상영상비트레이트복사.Name = "ToolStripMenuItem_예상영상비트레이트복사";
            this.ToolStripMenuItem_예상영상비트레이트복사.Size = new System.Drawing.Size(364, 26);
            this.ToolStripMenuItem_예상영상비트레이트복사.Text = "예상 영상 비트레이트 복사(&F)      Ctrl+F";
            this.ToolStripMenuItem_예상영상비트레이트복사.Click += new System.EventHandler(this.Copy예상영상비트레이트);
            // 
            // ToolStripMenuItem_표시소수점정밀도설정
            // 
            this.ToolStripMenuItem_표시소수점정밀도설정.Name = "ToolStripMenuItem_표시소수점정밀도설정";
            this.ToolStripMenuItem_표시소수점정밀도설정.Size = new System.Drawing.Size(364, 26);
            this.ToolStripMenuItem_표시소수점정밀도설정.Text = "표시 소수점 정밀도 설정...";
            this.ToolStripMenuItem_표시소수점정밀도설정.Click += new System.EventHandler(this.ToolStripMenuItem_표시소수점정밀도설정_Click);
            // 
            // ToolStripSeparator_메뉴2
            // 
            this.ToolStripSeparator_메뉴2.Name = "ToolStripSeparator_메뉴2";
            this.ToolStripSeparator_메뉴2.Size = new System.Drawing.Size(361, 6);
            // 
            // ToolStripMenuItem_종료
            // 
            this.ToolStripMenuItem_종료.Name = "ToolStripMenuItem_종료";
            this.ToolStripMenuItem_종료.Size = new System.Drawing.Size(364, 26);
            this.ToolStripMenuItem_종료.Text = "종료(&E)                                   Alt+F4";
            this.ToolStripMenuItem_종료.Click += new System.EventHandler(this.ToolStripMenuItem_종료_Click);
            // 
            // ToolStripMenuItem_도움말
            // 
            this.ToolStripMenuItem_도움말.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_제작자,
            this.ToolStripSeparator_도움말,
            this.ToolStripMenuItem_프로그램정보});
            this.ToolStripMenuItem_도움말.Name = "ToolStripMenuItem_도움말";
            this.ToolStripMenuItem_도움말.Size = new System.Drawing.Size(89, 24);
            this.ToolStripMenuItem_도움말.Text = "도움말(&H)";
            // 
            // ToolStripMenuItem_제작자
            // 
            this.ToolStripMenuItem_제작자.Name = "ToolStripMenuItem_제작자";
            this.ToolStripMenuItem_제작자.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_제작자.Text = "제작자(&P)...";
            this.ToolStripMenuItem_제작자.Click += new System.EventHandler(this.ToolStripMenuItem_제작자_Click);
            // 
            // ToolStripSeparator_도움말
            // 
            this.ToolStripSeparator_도움말.Name = "ToolStripSeparator_도움말";
            this.ToolStripSeparator_도움말.Size = new System.Drawing.Size(221, 6);
            // 
            // ToolStripMenuItem_프로그램정보
            // 
            this.ToolStripMenuItem_프로그램정보.Name = "ToolStripMenuItem_프로그램정보";
            this.ToolStripMenuItem_프로그램정보.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_프로그램정보.Text = "프로그램 정보(&I)...";
            this.ToolStripMenuItem_프로그램정보.Click += new System.EventHandler(this.ToolStripMenuItem_프로그램정보_Click);
            // 
            // Main_menuStrip
            // 
            this.Main_menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.Main_menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_메뉴,
            this.ToolStripMenuItem_편집,
            this.ToolStripMenuItem_도움말});
            this.Main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Main_menuStrip.Name = "Main_menuStrip";
            this.Main_menuStrip.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.Main_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Main_menuStrip.Size = new System.Drawing.Size(882, 26);
            this.Main_menuStrip.TabIndex = 1;
            this.Main_menuStrip.Text = "menuStrip";
            // 
            // ToolStripMenuItem_편집
            // 
            this.ToolStripMenuItem_편집.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_전체선택,
            this.ToolStripSeparator_편집,
            this.ToolStripMenuItem_잘라내기,
            this.ToolStripMenuItem_복사,
            this.ToolStripMenuItem_붙여넣기});
            this.ToolStripMenuItem_편집.Name = "ToolStripMenuItem_편집";
            this.ToolStripMenuItem_편집.Size = new System.Drawing.Size(71, 24);
            this.ToolStripMenuItem_편집.Text = "편집(&E)";
            // 
            // ToolStripMenuItem_전체선택
            // 
            this.ToolStripMenuItem_전체선택.Name = "ToolStripMenuItem_전체선택";
            this.ToolStripMenuItem_전체선택.Size = new System.Drawing.Size(252, 26);
            this.ToolStripMenuItem_전체선택.Text = "전체 선택(&A)      Ctrl+A";
            this.ToolStripMenuItem_전체선택.Click += new System.EventHandler(this.ToolStripMenuItem_전체선택_Click);
            // 
            // ToolStripSeparator_편집
            // 
            this.ToolStripSeparator_편집.Name = "ToolStripSeparator_편집";
            this.ToolStripSeparator_편집.Size = new System.Drawing.Size(249, 6);
            // 
            // ToolStripMenuItem_잘라내기
            // 
            this.ToolStripMenuItem_잘라내기.Name = "ToolStripMenuItem_잘라내기";
            this.ToolStripMenuItem_잘라내기.Size = new System.Drawing.Size(252, 26);
            this.ToolStripMenuItem_잘라내기.Text = "잘라내기(&X)       Ctrl+X";
            this.ToolStripMenuItem_잘라내기.Click += new System.EventHandler(this.ToolStripMenuItem_잘라내기_Click);
            // 
            // ToolStripMenuItem_복사
            // 
            this.ToolStripMenuItem_복사.Name = "ToolStripMenuItem_복사";
            this.ToolStripMenuItem_복사.Size = new System.Drawing.Size(252, 26);
            this.ToolStripMenuItem_복사.Text = "복사(&C)             Ctrl+C";
            this.ToolStripMenuItem_복사.Click += new System.EventHandler(this.ToolStripMenuItem_복사_Click);
            // 
            // ToolStripMenuItem_붙여넣기
            // 
            this.ToolStripMenuItem_붙여넣기.Name = "ToolStripMenuItem_붙여넣기";
            this.ToolStripMenuItem_붙여넣기.Size = new System.Drawing.Size(252, 26);
            this.ToolStripMenuItem_붙여넣기.Text = "붙여넣기(&V)       Ctrl+V";
            this.ToolStripMenuItem_붙여넣기.Click += new System.EventHandler(this.ToolStripMenuItem_붙여넣기_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(882, 433);
            this.Controls.Add(this.Layout_Main_tableLayoutPanel);
            this.Controls.Add(this.Main_menuStrip);
            this.Controls.Add(this.Main_statusStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Main_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(900, 480);
            this.Name = "Main_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "비트레이트 계산기";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Layout_Main_tableLayoutPanel.ResumeLayout(false);
            this.Layout_Main_tableLayoutPanel.PerformLayout();
            this.Layout_OutSizeBasedBitrate_groupBox.ResumeLayout(false);
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.ResumeLayout(false);
            this.Layout_OutSizeBasedBitrate_tableLayoutPanel.PerformLayout();
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.ResumeLayout(false);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기.PerformLayout();
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.ResumeLayout(false);
            this.Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트.PerformLayout();
            this.Layout_ConvertResolution_groupBox.ResumeLayout(false);
            this.Layout_ConvertResolution_tableLayoutPanel.ResumeLayout(false);
            this.Layout_ConvertResolution_tableLayoutPanel.PerformLayout();
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.ResumeLayout(false);
            this.Layout_ConvertResolution_flowLayoutPanel_변환기준.PerformLayout();
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.ResumeLayout(false);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상해상도.PerformLayout();
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.ResumeLayout(false);
            this.Layout_ConvertResolution_flowLayoutPanel_현재해상도.PerformLayout();
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.ResumeLayout(false);
            this.Layout_ConvertResolution_flowLayoutPanel_변환예상크기.PerformLayout();
            this.Layout_OriginVidInfo_groupBox.ResumeLayout(false);
            this.Layout_OriginVidInfo_tableLayoutPanel.ResumeLayout(false);
            this.Layout_OriginVidInfo_tableLayoutPanel.PerformLayout();
            this.Layout_OriginVidInfo_flowLayoutPanel_적용코덱.ResumeLayout(false);
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.ResumeLayout(false);
            this.Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트.PerformLayout();
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.ResumeLayout(false);
            this.Layout_OriginVidInfo_flowLayoutPanel_영상길이.PerformLayout();
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.ResumeLayout(false);
            this.Layout_OriginVidInfo_flowLayoutPanel_초당프레임.PerformLayout();
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.ResumeLayout(false);
            this.Layout_OriginVidInfo_flowLayoutPanel_화면해상도.PerformLayout();
            this.Layout_Bitrate_groupBox.ResumeLayout(false);
            this.Layout_Bitrate_tableLayoutPanel.ResumeLayout(false);
            this.Layout_Bitrate_tableLayoutPanel.PerformLayout();
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.ResumeLayout(false);
            this.Layout_Bitrate_flowLayoutPanel_예상출력영상크기.PerformLayout();
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.ResumeLayout(false);
            this.Layout_Bitrate_flowLayoutPanel_최대영상비트레이트.PerformLayout();
            this.Layout_Main_tableLayoutPanel_Buttons.ResumeLayout(false);
            this.Layout_Main_tableLayoutPanel_Buttons.PerformLayout();
            this.Layout_Main_flowLayoutPanel_버튼_Right.ResumeLayout(false);
            this.Layout_Main_flowLayoutPanel_버튼_left.ResumeLayout(false);
            this.Main_statusStrip.ResumeLayout(false);
            this.Main_statusStrip.PerformLayout();
            this.Main_menuStrip.ResumeLayout(false);
            this.Main_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout_Main_tableLayoutPanel;
        private System.Windows.Forms.GroupBox Layout_OriginVidInfo_groupBox;
        private System.Windows.Forms.FlowLayoutPanel Layout_OriginVidInfo_flowLayoutPanel_화면해상도;
        private System.Windows.Forms.Label OriginVidInfo_label_화면해상도;
        private System.Windows.Forms.Label OriginVidInfo_label_x;
        private System.Windows.Forms.Label OriginVidInfo_label_영상길이;
        private System.Windows.Forms.Label OriginVidInfo_label_초당프레임;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_초당프레임;
        private System.Windows.Forms.Label OriginVidInfo_label_오디오비트레이트;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_오디오비트레이트;
        private System.Windows.Forms.Label OriginVidInfo_label_적용코덱;
        private System.Windows.Forms.GroupBox Layout_Bitrate_groupBox;
        private System.Windows.Forms.TableLayoutPanel Layout_Bitrate_tableLayoutPanel;
        private System.Windows.Forms.Label Bitrate_label_최대영상비트레이트;
        private System.Windows.Forms.Label ValuePrintLabel_Bitrate_최대영상비트레이트;
        private System.Windows.Forms.Label Bitrate_label_예상출력영상크기;
        private System.Windows.Forms.Label ValuePrintLabel_Bitrate_예상출력영상크기;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_화면해상도_가로;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_화면해상도_세로;
        private System.Windows.Forms.FlowLayoutPanel Layout_OriginVidInfo_flowLayoutPanel_오디오비트레이트;
        private System.Windows.Forms.Label OriginVidInfo_label_Kbps;
        private System.Windows.Forms.FlowLayoutPanel Layout_OriginVidInfo_flowLayoutPanel_초당프레임;
        private System.Windows.Forms.Label OriginVidInfo_label_FPS;
        private System.Windows.Forms.Button OriginVidInfo_button_초기화;
        private System.Windows.Forms.FlowLayoutPanel Layout_Bitrate_flowLayoutPanel_최대영상비트레이트;
        private System.Windows.Forms.FlowLayoutPanel Layout_Bitrate_flowLayoutPanel_예상출력영상크기;
        private System.Windows.Forms.TableLayoutPanel Layout_OriginVidInfo_tableLayoutPanel;
        private System.Windows.Forms.ToolTip Main_toolTip;
        private System.Windows.Forms.GroupBox Layout_OutSizeBasedBitrate_groupBox;
        private System.Windows.Forms.TableLayoutPanel Layout_OutSizeBasedBitrate_tableLayoutPanel;
        private System.Windows.Forms.Label OutSizeBasedBitrate_label_원하는출력영상크기;
        private System.Windows.Forms.FlowLayoutPanel Layout_OutSizeBasedBitrate_flowLayoutPanel_원하는출력영상크기;
        private System.Windows.Forms.TextBox OutSizeBasedBitrate_textBox_원하는출력영상크기;
        private System.Windows.Forms.ComboBox OutSizeBasedBitrate_comboBox_원하는출력영상크기;
        private System.Windows.Forms.Label OutSizeBasedBitrate_label_예상영상비트레이트;
        private System.Windows.Forms.FlowLayoutPanel Layout_OutSizeBasedBitrate_flowLayoutPanel_예상영상비트레이트;
        private System.Windows.Forms.Label ValuePrintLabel_OutSizeBasedBitrate_예상영상비트레이트;
        private System.Windows.Forms.GroupBox Layout_ConvertResolution_groupBox;
        private System.Windows.Forms.TableLayoutPanel Layout_ConvertResolution_tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel Layout_ConvertResolution_flowLayoutPanel_변환기준;
        private System.Windows.Forms.ComboBox ConvertResolution_comboBox_기준;
        private System.Windows.Forms.TextBox ConvertResolution_textBox_변환기준;
        private System.Windows.Forms.Label ConvertResolution_label_변환예상해상도;
        private System.Windows.Forms.FlowLayoutPanel Layout_ConvertResolution_flowLayoutPanel_변환예상해상도;
        private System.Windows.Forms.Label ValuePrintLabel_ConvertResolution_변환예상해상도_가로;
        private System.Windows.Forms.Label ConvertResolution_label_변환예상해상도_x;
        private System.Windows.Forms.Label ValuePrintLabel_ConvertResolution_변환예상해상도_세로;
        private System.Windows.Forms.Label ConvertResolution_label_변환예상크기;
        private System.Windows.Forms.FlowLayoutPanel Layout_ConvertResolution_flowLayoutPanel_변환예상크기;
        private System.Windows.Forms.Label ValuePrintLabel_ConvertResolution_변환예상크기;
        private System.Windows.Forms.Button ConvertResolution_button_적용;
        private System.Windows.Forms.FlowLayoutPanel Layout_ConvertResolution_flowLayoutPanel_현재해상도;
        private System.Windows.Forms.Label ConvertResolution_label_현재해상도;
        private System.Windows.Forms.Label ValuePrintLabel_ConvertResolution_현재해상도_가로;
        private System.Windows.Forms.Label ConvertResolution_label_현재해상도_x;
        private System.Windows.Forms.Label ValuePrintLabel_ConvertResolution_현재해상도_세로;
        private System.Windows.Forms.Label ConvertResolution_label_변환기준;
        private System.Windows.Forms.FlowLayoutPanel Layout_OriginVidInfo_flowLayoutPanel_적용코덱;
        private System.Windows.Forms.ComboBox OriginVidInfo_comboBox_적용코덱;
        private System.Windows.Forms.StatusStrip Main_statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ValuePrintLabel_Main_status;
        private System.Windows.Forms.Timer Main_timer;
        private System.Windows.Forms.ComboBox Bitrate_comboBox_예상출력영상크기;
        private System.Windows.Forms.ComboBox ConvertResolution_comboBox_변환예상크기;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_메뉴;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_해상도변환적용;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_원본영상파일정보초기화;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_모두초기화;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator_메뉴1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_최대영상비트레이트복사;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_예상영상비트레이트복사;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator_메뉴2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_종료;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_도움말;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_제작자;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator_도움말;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_프로그램정보;
        private System.Windows.Forms.MenuStrip Main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_편집;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_전체선택;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator_편집;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_잘라내기;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_복사;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_붙여넣기;
        private System.Windows.Forms.Label ConvertResolution_label_colon;
        private System.Windows.Forms.ComboBox Bitrate_comboBox_최대영상비트레이트;
        private System.Windows.Forms.ComboBox OutSizeBasedBitrate_comboBox_예상영상비트레이트;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_표시소수점정밀도설정;
        private System.Windows.Forms.FlowLayoutPanel Layout_OriginVidInfo_flowLayoutPanel_영상길이;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_시간;
        private System.Windows.Forms.Label OriginVidInfo_label_시간;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_분;
        private System.Windows.Forms.Label OriginVidInfo_label_분;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_초;
        private System.Windows.Forms.Label OriginVidInfo_label_초;
        private System.Windows.Forms.TableLayoutPanel Layout_Main_tableLayoutPanel_Buttons;
        private System.Windows.Forms.FlowLayoutPanel Layout_Main_flowLayoutPanel_버튼_Right;
        private System.Windows.Forms.Button Main_button_모두초기화;
        private System.Windows.Forms.Button Main_button_종료;
        private System.Windows.Forms.FlowLayoutPanel Layout_Main_flowLayoutPanel_버튼_left;
        private System.Windows.Forms.Button Main_button_제작자;
    }
}

