﻿namespace Bitrate_Calculator
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
            this.Main_컨tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OriginVidInfo_컨_groupBox = new System.Windows.Forms.GroupBox();
            this.OriginVidInfo_컨_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OriginVidInfo_button_초기화 = new System.Windows.Forms.Button();
            this.OriginVidInfo_label_코덱_값 = new System.Windows.Forms.Label();
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_comboBox_적용_코덱 = new System.Windows.Forms.ComboBox();
            this.OriginVidInfo_label_오디오_비트레이트 = new System.Windows.Forms.Label();
            this.OriginVidInfo_label_초당_프레임 = new System.Windows.Forms.Label();
            this.OriginVidInfo_label_영상_길이 = new System.Windows.Forms.Label();
            this.OriginVidInfo_label_화면_해상도 = new System.Windows.Forms.Label();
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_textBox_오디오_비트레이트 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_Kbps = new System.Windows.Forms.Label();
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_textBox_시간 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_시간 = new System.Windows.Forms.Label();
            this.OriginVidInfo_textBox_분 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_분 = new System.Windows.Forms.Label();
            this.OriginVidInfo_textBox_초 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_초 = new System.Windows.Forms.Label();
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_textBox_FPS = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_FPS = new System.Windows.Forms.Label();
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginVidInfo_textBox_화면_해상도_가로 = new System.Windows.Forms.TextBox();
            this.OriginVidInfo_label_곱하기 = new System.Windows.Forms.Label();
            this.OriginVidInfo_textBox_화면_해상도_세로 = new System.Windows.Forms.TextBox();
            this.Bitrate_컨_groupBox_영상_비트레이트 = new System.Windows.Forms.GroupBox();
            this.Bitrate_컨_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Bitrate_label_ShowValue_예상_출력_영상_크기 = new System.Windows.Forms.Label();
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bitrate_label_예상_출력_영상_크기 = new System.Windows.Forms.Label();
            this.Bitrate_comboBox_예상_출력_영상_크기_단위 = new System.Windows.Forms.ComboBox();
            this.Bitrate_label_ShowValue_최대_영상_비트레이트 = new System.Windows.Forms.Label();
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트 = new System.Windows.Forms.FlowLayoutPanel();
            this.Bitrate_label_최대_영상_비트레이트 = new System.Windows.Forms.Label();
            this.Bitrate_comboBox_Bitrate_단위 = new System.Windows.Forms.ComboBox();
            this.OutSizeBasedBitrate_컨_groupBox = new System.Windows.Forms.GroupBox();
            this.OutSizeBasedBitrate_컨_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기 = new System.Windows.Forms.TextBox();
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기 = new System.Windows.Forms.FlowLayoutPanel();
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기 = new System.Windows.Forms.Label();
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위 = new System.Windows.Forms.ComboBox();
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트 = new System.Windows.Forms.Label();
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트 = new System.Windows.Forms.FlowLayoutPanel();
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트 = new System.Windows.Forms.Label();
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위 = new System.Windows.Forms.ComboBox();
            this.ConvertResolution_컨_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Main_button_제작자 = new System.Windows.Forms.Button();
            this.ConvertResolution_컨_groupBox = new System.Windows.Forms.GroupBox();
            this.ConvertResolution_컨_tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ConvertResolution_label_현재해상도 = new System.Windows.Forms.Label();
            this.ConvertResolution_button_적용 = new System.Windows.Forms.Button();
            this.ConvertResolution_컨flowLayoutPanel_기준 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConvertResolution_comboBox_기준 = new System.Windows.Forms.ComboBox();
            this.ConvertResolution_textBox_기준픽셀 = new System.Windows.Forms.TextBox();
            this.ConvertResolution_label_변환예상해상도 = new System.Windows.Forms.Label();
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로 = new System.Windows.Forms.Label();
            this.ConvertResolution_label_x_2 = new System.Windows.Forms.Label();
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로 = new System.Windows.Forms.Label();
            this.ConvertResolution_label_변환기준 = new System.Windows.Forms.Label();
            this.ConvertResolution_컨flowLayoutPanel_현재해상도 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConvertResolution_label_ShowValue_현재해상도_가로 = new System.Windows.Forms.Label();
            this.ConvertResolution_label_x_1 = new System.Windows.Forms.Label();
            this.ConvertResolution_label_ShowValue_현재해상도_세로 = new System.Windows.Forms.Label();
            this.ConvertResolution_label_ShowValue_변환예상크기 = new System.Windows.Forms.Label();
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConvertResolution_label_변환예상영상크기 = new System.Windows.Forms.Label();
            this.ConvertResolution_comboBox_변환예상크기단위 = new System.Windows.Forms.ComboBox();
            this.ConvertResolution_label_colon = new System.Windows.Forms.Label();
            this.Main_컨flowLayoutPanel_버튼 = new System.Windows.Forms.FlowLayoutPanel();
            this.Main_button_모두_초기화 = new System.Windows.Forms.Button();
            this.Main_button_종료 = new System.Windows.Forms.Button();
            this.Main_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Main_statusStrip = new System.Windows.Forms.StatusStrip();
            this.Main_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Main_timer = new System.Windows.Forms.Timer(this.components);
            this.Main_ToolStripMenuItem_파일 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_해상도변환적용 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_원본영상파일정보초기화 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_모두초기화 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Main_ToolStripMenuItem_최대영상비트레이트복사 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_예상영상비트레이트복사 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_표시소수점정밀도설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.Main_ToolStripMenuItem_종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_도움말 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_제작자 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Main_ToolStripMenuItem_프로그램정보 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Main_ToolStripMenuItem_편집 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_전체선택 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_toolStripSeparator33 = new System.Windows.Forms.ToolStripSeparator();
            this.Main_ToolStripMenuItem_잘라내기 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_복사 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ToolStripMenuItem_붙여넣기 = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_컨tableLayoutPanel.SuspendLayout();
            this.OriginVidInfo_컨_groupBox.SuspendLayout();
            this.OriginVidInfo_컨_tableLayoutPanel1.SuspendLayout();
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.SuspendLayout();
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.SuspendLayout();
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.SuspendLayout();
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.SuspendLayout();
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.SuspendLayout();
            this.Bitrate_컨_groupBox_영상_비트레이트.SuspendLayout();
            this.Bitrate_컨_tableLayoutPanel.SuspendLayout();
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.SuspendLayout();
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.SuspendLayout();
            this.OutSizeBasedBitrate_컨_groupBox.SuspendLayout();
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.SuspendLayout();
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.SuspendLayout();
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.SuspendLayout();
            this.ConvertResolution_컨_tableLayoutPanel1.SuspendLayout();
            this.ConvertResolution_컨_groupBox.SuspendLayout();
            this.ConvertResolution_컨_tableLayoutPanel2.SuspendLayout();
            this.ConvertResolution_컨flowLayoutPanel_기준.SuspendLayout();
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.SuspendLayout();
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.SuspendLayout();
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.SuspendLayout();
            this.Main_컨flowLayoutPanel_버튼.SuspendLayout();
            this.Main_statusStrip.SuspendLayout();
            this.Main_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_컨tableLayoutPanel
            // 
            this.Main_컨tableLayoutPanel.ColumnCount = 2;
            this.Main_컨tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.4298F));
            this.Main_컨tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5702F));
            this.Main_컨tableLayoutPanel.Controls.Add(this.OriginVidInfo_컨_groupBox, 0, 0);
            this.Main_컨tableLayoutPanel.Controls.Add(this.Bitrate_컨_groupBox_영상_비트레이트, 0, 2);
            this.Main_컨tableLayoutPanel.Controls.Add(this.OutSizeBasedBitrate_컨_groupBox, 1, 0);
            this.Main_컨tableLayoutPanel.Controls.Add(this.ConvertResolution_컨_tableLayoutPanel1, 1, 1);
            this.Main_컨tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_컨tableLayoutPanel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Main_컨tableLayoutPanel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Main_컨tableLayoutPanel.Location = new System.Drawing.Point(0, 26);
            this.Main_컨tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.Main_컨tableLayoutPanel.Name = "Main_컨tableLayoutPanel";
            this.Main_컨tableLayoutPanel.RowCount = 3;
            this.Main_컨tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.97543F));
            this.Main_컨tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.54055F));
            this.Main_컨tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.48403F));
            this.Main_컨tableLayoutPanel.Size = new System.Drawing.Size(882, 378);
            this.Main_컨tableLayoutPanel.TabIndex = 0;
            // 
            // OriginVidInfo_컨_groupBox
            // 
            this.OriginVidInfo_컨_groupBox.Controls.Add(this.OriginVidInfo_컨_tableLayoutPanel1);
            this.OriginVidInfo_컨_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginVidInfo_컨_groupBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_컨_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_컨_groupBox.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_컨_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_컨_groupBox.Name = "OriginVidInfo_컨_groupBox";
            this.OriginVidInfo_컨_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.Main_컨tableLayoutPanel.SetRowSpan(this.OriginVidInfo_컨_groupBox, 2);
            this.OriginVidInfo_컨_groupBox.Size = new System.Drawing.Size(440, 262);
            this.OriginVidInfo_컨_groupBox.TabIndex = 0;
            this.OriginVidInfo_컨_groupBox.TabStop = false;
            this.OriginVidInfo_컨_groupBox.Text = "원본 영상 파일 정보";
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_컨_groupBox, "원본 영상 파일의 정보를 적습니다.");
            // 
            // OriginVidInfo_컨_tableLayoutPanel1
            // 
            this.OriginVidInfo_컨_tableLayoutPanel1.ColumnCount = 2;
            this.OriginVidInfo_컨_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.88761F));
            this.OriginVidInfo_컨_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.11239F));
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_button_초기화, 1, 5);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_label_코덱_값, 0, 4);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_컨flowLayoutPanel_적용_코덱, 1, 4);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_label_오디오_비트레이트, 0, 3);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_label_초당_프레임, 0, 2);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_label_영상_길이, 0, 0);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_label_화면_해상도, 0, 1);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트, 1, 3);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_컨flowLayoutPanel_영상_길이, 1, 0);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_컨flowLayoutPanel_초당_프레임, 1, 2);
            this.OriginVidInfo_컨_tableLayoutPanel1.Controls.Add(this.OriginVidInfo_컨flowLayoutPanel_화면_해상도, 1, 1);
            this.OriginVidInfo_컨_tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginVidInfo_컨_tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_컨_tableLayoutPanel1.Location = new System.Drawing.Point(2, 24);
            this.OriginVidInfo_컨_tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_컨_tableLayoutPanel1.Name = "OriginVidInfo_컨_tableLayoutPanel1";
            this.OriginVidInfo_컨_tableLayoutPanel1.RowCount = 6;
            this.OriginVidInfo_컨_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.OriginVidInfo_컨_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.OriginVidInfo_컨_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.OriginVidInfo_컨_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.5F));
            this.OriginVidInfo_컨_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.OriginVidInfo_컨_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.OriginVidInfo_컨_tableLayoutPanel1.Size = new System.Drawing.Size(436, 236);
            this.OriginVidInfo_컨_tableLayoutPanel1.TabIndex = 0;
            // 
            // OriginVidInfo_button_초기화
            // 
            this.OriginVidInfo_button_초기화.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_button_초기화.AutoSize = true;
            this.OriginVidInfo_button_초기화.Enabled = false;
            this.OriginVidInfo_button_초기화.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_button_초기화.ForeColor = System.Drawing.Color.Black;
            this.OriginVidInfo_button_초기화.Location = new System.Drawing.Point(332, 202);
            this.OriginVidInfo_button_초기화.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_button_초기화.Name = "OriginVidInfo_button_초기화";
            this.OriginVidInfo_button_초기화.Size = new System.Drawing.Size(102, 32);
            this.OriginVidInfo_button_초기화.TabIndex = 10;
            this.OriginVidInfo_button_초기화.Text = "초기화";
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_button_초기화, "설정된 원본 영상 파일 정보를 초기화합니다. (단축키: Ctrl+W)");
            this.OriginVidInfo_button_초기화.UseVisualStyleBackColor = true;
            this.OriginVidInfo_button_초기화.Click += new System.EventHandler(this.OriginVidInfo_button_초기화_Click);
            // 
            // OriginVidInfo_label_코덱_값
            // 
            this.OriginVidInfo_label_코덱_값.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_코덱_값.AutoSize = true;
            this.OriginVidInfo_label_코덱_값.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_코덱_값.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_코덱_값.Location = new System.Drawing.Point(70, 166);
            this.OriginVidInfo_label_코덱_값.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_코덱_값.Name = "OriginVidInfo_label_코덱_값";
            this.OriginVidInfo_label_코덱_값.Size = new System.Drawing.Size(88, 23);
            this.OriginVidInfo_label_코덱_값.TabIndex = 8;
            this.OriginVidInfo_label_코덱_값.Text = "적용 코덱:";
            this.OriginVidInfo_label_코덱_값.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_코덱_값, "원본 영상을 재 인코딩 할 때 적용하려는 코덱입니다.");
            // 
            // OriginVidInfo_컨flowLayoutPanel_적용_코덱
            // 
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.AutoSize = true;
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.Controls.Add(this.OriginVidInfo_comboBox_적용_코덱);
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.Location = new System.Drawing.Point(162, 162);
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.Name = "OriginVidInfo_컨flowLayoutPanel_적용_코덱";
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.Size = new System.Drawing.Size(87, 32);
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.TabIndex = 9;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_컨flowLayoutPanel_적용_코덱, "원본 영상을 재 인코딩 할 때 적용하려는 코덱입니다.");
            // 
            // OriginVidInfo_comboBox_적용_코덱
            // 
            this.OriginVidInfo_comboBox_적용_코덱.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_comboBox_적용_코덱.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_comboBox_적용_코덱.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_comboBox_적용_코덱.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_comboBox_적용_코덱.FormattingEnabled = true;
            this.OriginVidInfo_comboBox_적용_코덱.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_comboBox_적용_코덱.Items.AddRange(new object[] {
            "H.263",
            "H.264",
            "X264",
            "Xvid",
            "DviX",
            "MPEG-2",
            "MPEG-4"});
            this.OriginVidInfo_comboBox_적용_코덱.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_comboBox_적용_코덱.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_comboBox_적용_코덱.Name = "OriginVidInfo_comboBox_적용_코덱";
            this.OriginVidInfo_comboBox_적용_코덱.Size = new System.Drawing.Size(83, 28);
            this.OriginVidInfo_comboBox_적용_코덱.TabIndex = 9;
            this.OriginVidInfo_comboBox_적용_코덱.Text = "H.264";
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_comboBox_적용_코덱, "원본 영상을 재 인코딩 할 때 적용하려는 코덱입니다.");
            this.OriginVidInfo_comboBox_적용_코덱.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_comboBox_적용_코덱.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_comboBox_적용_코덱.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_comboBox_적용_코덱.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // OriginVidInfo_label_오디오_비트레이트
            // 
            this.OriginVidInfo_label_오디오_비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_오디오_비트레이트.AutoSize = true;
            this.OriginVidInfo_label_오디오_비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_오디오_비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_오디오_비트레이트.Location = new System.Drawing.Point(2, 125);
            this.OriginVidInfo_label_오디오_비트레이트.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_오디오_비트레이트.Name = "OriginVidInfo_label_오디오_비트레이트";
            this.OriginVidInfo_label_오디오_비트레이트.Size = new System.Drawing.Size(156, 23);
            this.OriginVidInfo_label_오디오_비트레이트.TabIndex = 6;
            this.OriginVidInfo_label_오디오_비트레이트.Text = "오디오 비트레이트:";
            this.OriginVidInfo_label_오디오_비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_오디오_비트레이트, "원본 영상의 오디오 비트레이트입니다.");
            // 
            // OriginVidInfo_label_초당_프레임
            // 
            this.OriginVidInfo_label_초당_프레임.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_초당_프레임.AutoSize = true;
            this.OriginVidInfo_label_초당_프레임.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_초당_프레임.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_초당_프레임.Location = new System.Drawing.Point(53, 86);
            this.OriginVidInfo_label_초당_프레임.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_초당_프레임.Name = "OriginVidInfo_label_초당_프레임";
            this.OriginVidInfo_label_초당_프레임.Size = new System.Drawing.Size(105, 23);
            this.OriginVidInfo_label_초당_프레임.TabIndex = 4;
            this.OriginVidInfo_label_초당_프레임.Text = "초당 프레임:";
            this.OriginVidInfo_label_초당_프레임.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_초당_프레임, "원본 영상의 초당 프레임입니다.");
            // 
            // OriginVidInfo_label_영상_길이
            // 
            this.OriginVidInfo_label_영상_길이.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_영상_길이.AutoSize = true;
            this.OriginVidInfo_label_영상_길이.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_영상_길이.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_영상_길이.Location = new System.Drawing.Point(70, 8);
            this.OriginVidInfo_label_영상_길이.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_영상_길이.Name = "OriginVidInfo_label_영상_길이";
            this.OriginVidInfo_label_영상_길이.Size = new System.Drawing.Size(88, 23);
            this.OriginVidInfo_label_영상_길이.TabIndex = 0;
            this.OriginVidInfo_label_영상_길이.Text = "영상 길이:";
            this.OriginVidInfo_label_영상_길이.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_영상_길이, "원본 영상의 런타임 시간입니다.");
            // 
            // OriginVidInfo_label_화면_해상도
            // 
            this.OriginVidInfo_label_화면_해상도.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OriginVidInfo_label_화면_해상도.AutoSize = true;
            this.OriginVidInfo_label_화면_해상도.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_화면_해상도.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_화면_해상도.Location = new System.Drawing.Point(25, 47);
            this.OriginVidInfo_label_화면_해상도.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_화면_해상도.Name = "OriginVidInfo_label_화면_해상도";
            this.OriginVidInfo_label_화면_해상도.Size = new System.Drawing.Size(133, 23);
            this.OriginVidInfo_label_화면_해상도.TabIndex = 2;
            this.OriginVidInfo_label_화면_해상도.Text = "화면 해상도(px):";
            this.OriginVidInfo_label_화면_해상도.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_label_화면_해상도, "원본 영상의 화면 해상도입니다.");
            // 
            // OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트
            // 
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.AutoSize = true;
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.Controls.Add(this.OriginVidInfo_textBox_오디오_비트레이트);
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.Controls.Add(this.OriginVidInfo_label_Kbps);
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.Location = new System.Drawing.Point(162, 121);
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.Name = "OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트";
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.Size = new System.Drawing.Size(85, 31);
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.TabIndex = 7;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트, "원본 영상의 오디오 비트레이트입니다.");
            // 
            // OriginVidInfo_textBox_오디오_비트레이트
            // 
            this.OriginVidInfo_textBox_오디오_비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_textBox_오디오_비트레이트.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_오디오_비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_오디오_비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_오디오_비트레이트.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_오디오_비트레이트.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_textBox_오디오_비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_오디오_비트레이트.MaxLength = 3;
            this.OriginVidInfo_textBox_오디오_비트레이트.Name = "OriginVidInfo_textBox_오디오_비트레이트";
            this.OriginVidInfo_textBox_오디오_비트레이트.Size = new System.Drawing.Size(30, 27);
            this.OriginVidInfo_textBox_오디오_비트레이트.TabIndex = 0;
            this.OriginVidInfo_textBox_오디오_비트레이트.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_오디오_비트레이트, "원본 영상의 오디오 비트레이트입니다.");
            this.OriginVidInfo_textBox_오디오_비트레이트.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_오디오_비트레이트.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_오디오_비트레이트.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_오디오_비트레이트.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
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
            // OriginVidInfo_컨flowLayoutPanel_영상_길이
            // 
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.AutoSize = true;
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Controls.Add(this.OriginVidInfo_textBox_시간);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Controls.Add(this.OriginVidInfo_label_시간);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Controls.Add(this.OriginVidInfo_textBox_분);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Controls.Add(this.OriginVidInfo_label_분);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Controls.Add(this.OriginVidInfo_textBox_초);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Controls.Add(this.OriginVidInfo_label_초);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Location = new System.Drawing.Point(162, 4);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Name = "OriginVidInfo_컨flowLayoutPanel_영상_길이";
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.Size = new System.Drawing.Size(210, 31);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.TabIndex = 1;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_컨flowLayoutPanel_영상_길이, "원본 영상의 런타임 시간입니다.");
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
            // OriginVidInfo_컨flowLayoutPanel_초당_프레임
            // 
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.AutoSize = true;
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.Controls.Add(this.OriginVidInfo_textBox_FPS);
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.Controls.Add(this.OriginVidInfo_label_FPS);
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.Location = new System.Drawing.Point(162, 82);
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.Name = "OriginVidInfo_컨flowLayoutPanel_초당_프레임";
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.Size = new System.Drawing.Size(84, 31);
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.TabIndex = 5;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_컨flowLayoutPanel_초당_프레임, "원본 영상의 초당 프레임입니다.");
            // 
            // OriginVidInfo_textBox_FPS
            // 
            this.OriginVidInfo_textBox_FPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_textBox_FPS.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_FPS.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_FPS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_FPS.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_FPS.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_textBox_FPS.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_FPS.MaxLength = 4;
            this.OriginVidInfo_textBox_FPS.Name = "OriginVidInfo_textBox_FPS";
            this.OriginVidInfo_textBox_FPS.Size = new System.Drawing.Size(39, 27);
            this.OriginVidInfo_textBox_FPS.TabIndex = 0;
            this.OriginVidInfo_textBox_FPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_FPS, "원본 영상의 초당 프레임입니다.");
            this.OriginVidInfo_textBox_FPS.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_FPS.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_FPS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_FPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
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
            // OriginVidInfo_컨flowLayoutPanel_화면_해상도
            // 
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.AutoSize = true;
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.Controls.Add(this.OriginVidInfo_textBox_화면_해상도_가로);
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.Controls.Add(this.OriginVidInfo_label_곱하기);
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.Controls.Add(this.OriginVidInfo_textBox_화면_해상도_세로);
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.Location = new System.Drawing.Point(162, 43);
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.Name = "OriginVidInfo_컨flowLayoutPanel_화면_해상도";
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.Size = new System.Drawing.Size(112, 31);
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.TabIndex = 3;
            // 
            // OriginVidInfo_textBox_화면_해상도_가로
            // 
            this.OriginVidInfo_textBox_화면_해상도_가로.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_화면_해상도_가로.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_화면_해상도_가로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_화면_해상도_가로.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_화면_해상도_가로.Location = new System.Drawing.Point(2, 2);
            this.OriginVidInfo_textBox_화면_해상도_가로.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_화면_해상도_가로.MaxLength = 4;
            this.OriginVidInfo_textBox_화면_해상도_가로.Name = "OriginVidInfo_textBox_화면_해상도_가로";
            this.OriginVidInfo_textBox_화면_해상도_가로.Size = new System.Drawing.Size(39, 27);
            this.OriginVidInfo_textBox_화면_해상도_가로.TabIndex = 0;
            this.OriginVidInfo_textBox_화면_해상도_가로.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_화면_해상도_가로, "원본 영상 화면 해상도의 가로 길이입니다.");
            this.OriginVidInfo_textBox_화면_해상도_가로.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_화면_해상도_가로.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_화면_해상도_가로.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_화면_해상도_가로.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // OriginVidInfo_label_곱하기
            // 
            this.OriginVidInfo_label_곱하기.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OriginVidInfo_label_곱하기.AutoSize = true;
            this.OriginVidInfo_label_곱하기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OriginVidInfo_label_곱하기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_label_곱하기.Location = new System.Drawing.Point(45, 4);
            this.OriginVidInfo_label_곱하기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginVidInfo_label_곱하기.Name = "OriginVidInfo_label_곱하기";
            this.OriginVidInfo_label_곱하기.Size = new System.Drawing.Size(22, 23);
            this.OriginVidInfo_label_곱하기.TabIndex = 2;
            this.OriginVidInfo_label_곱하기.Text = "×";
            this.OriginVidInfo_label_곱하기.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OriginVidInfo_textBox_화면_해상도_세로
            // 
            this.OriginVidInfo_textBox_화면_해상도_세로.BackColor = System.Drawing.SystemColors.Window;
            this.OriginVidInfo_textBox_화면_해상도_세로.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OriginVidInfo_textBox_화면_해상도_세로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OriginVidInfo_textBox_화면_해상도_세로.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OriginVidInfo_textBox_화면_해상도_세로.Location = new System.Drawing.Point(71, 2);
            this.OriginVidInfo_textBox_화면_해상도_세로.Margin = new System.Windows.Forms.Padding(2);
            this.OriginVidInfo_textBox_화면_해상도_세로.MaxLength = 4;
            this.OriginVidInfo_textBox_화면_해상도_세로.Name = "OriginVidInfo_textBox_화면_해상도_세로";
            this.OriginVidInfo_textBox_화면_해상도_세로.Size = new System.Drawing.Size(39, 27);
            this.OriginVidInfo_textBox_화면_해상도_세로.TabIndex = 3;
            this.OriginVidInfo_textBox_화면_해상도_세로.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OriginVidInfo_textBox_화면_해상도_세로, "원본 영상 화면 해상도의 세로 길이입니다.");
            this.OriginVidInfo_textBox_화면_해상도_세로.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OriginVidInfo_textBox_화면_해상도_세로.Enter += new System.EventHandler(this.ControlEnter);
            this.OriginVidInfo_textBox_화면_해상도_세로.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OriginVidInfo_textBox_화면_해상도_세로.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Bitrate_컨_groupBox_영상_비트레이트
            // 
            this.Bitrate_컨_groupBox_영상_비트레이트.Controls.Add(this.Bitrate_컨_tableLayoutPanel);
            this.Bitrate_컨_groupBox_영상_비트레이트.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bitrate_컨_groupBox_영상_비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bitrate_컨_groupBox_영상_비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bitrate_컨_groupBox_영상_비트레이트.Location = new System.Drawing.Point(2, 268);
            this.Bitrate_컨_groupBox_영상_비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.Bitrate_컨_groupBox_영상_비트레이트.Name = "Bitrate_컨_groupBox_영상_비트레이트";
            this.Bitrate_컨_groupBox_영상_비트레이트.Padding = new System.Windows.Forms.Padding(2);
            this.Bitrate_컨_groupBox_영상_비트레이트.Size = new System.Drawing.Size(440, 108);
            this.Bitrate_컨_groupBox_영상_비트레이트.TabIndex = 1;
            this.Bitrate_컨_groupBox_영상_비트레이트.TabStop = false;
            this.Bitrate_컨_groupBox_영상_비트레이트.Text = "영상 비트레이트";
            this.Main_toolTip.SetToolTip(this.Bitrate_컨_groupBox_영상_비트레이트, "최대 영상 비트레이트와 예상 출력 영상 크기를 보여줍니다.");
            // 
            // Bitrate_컨_tableLayoutPanel
            // 
            this.Bitrate_컨_tableLayoutPanel.ColumnCount = 2;
            this.Bitrate_컨_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.51603F));
            this.Bitrate_컨_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.48397F));
            this.Bitrate_컨_tableLayoutPanel.Controls.Add(this.Bitrate_label_ShowValue_예상_출력_영상_크기, 1, 1);
            this.Bitrate_컨_tableLayoutPanel.Controls.Add(this.Bitrate_컨flowLayoutPanel_예상_출력물_크기, 0, 1);
            this.Bitrate_컨_tableLayoutPanel.Controls.Add(this.Bitrate_label_ShowValue_최대_영상_비트레이트, 1, 0);
            this.Bitrate_컨_tableLayoutPanel.Controls.Add(this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트, 0, 0);
            this.Bitrate_컨_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bitrate_컨_tableLayoutPanel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bitrate_컨_tableLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bitrate_컨_tableLayoutPanel.Location = new System.Drawing.Point(2, 24);
            this.Bitrate_컨_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.Bitrate_컨_tableLayoutPanel.Name = "Bitrate_컨_tableLayoutPanel";
            this.Bitrate_컨_tableLayoutPanel.RowCount = 2;
            this.Bitrate_컨_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Bitrate_컨_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Bitrate_컨_tableLayoutPanel.Size = new System.Drawing.Size(436, 82);
            this.Bitrate_컨_tableLayoutPanel.TabIndex = 0;
            // 
            // Bitrate_label_ShowValue_예상_출력_영상_크기
            // 
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.AutoSize = true;
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.Location = new System.Drawing.Point(270, 50);
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.Name = "Bitrate_label_ShowValue_예상_출력_영상_크기";
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.Size = new System.Drawing.Size(16, 23);
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.TabIndex = 0;
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.Text = " ";
            this.Bitrate_label_ShowValue_예상_출력_영상_크기.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_toolTip.SetToolTip(this.Bitrate_label_ShowValue_예상_출력_영상_크기, "최대 영상 비트레이트로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // Bitrate_컨flowLayoutPanel_예상_출력물_크기
            // 
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.AutoSize = true;
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.Controls.Add(this.Bitrate_label_예상_출력_영상_크기);
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.Controls.Add(this.Bitrate_comboBox_예상_출력_영상_크기_단위);
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.Location = new System.Drawing.Point(38, 45);
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.Margin = new System.Windows.Forms.Padding(2);
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.Name = "Bitrate_컨flowLayoutPanel_예상_출력물_크기";
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.Size = new System.Drawing.Size(228, 32);
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.TabIndex = 3;
            this.Main_toolTip.SetToolTip(this.Bitrate_컨flowLayoutPanel_예상_출력물_크기, "최대 영상 비트레이트로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // Bitrate_label_예상_출력_영상_크기
            // 
            this.Bitrate_label_예상_출력_영상_크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bitrate_label_예상_출력_영상_크기.AutoSize = true;
            this.Bitrate_label_예상_출력_영상_크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bitrate_label_예상_출력_영상_크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bitrate_label_예상_출력_영상_크기.Location = new System.Drawing.Point(2, 4);
            this.Bitrate_label_예상_출력_영상_크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bitrate_label_예상_출력_영상_크기.Name = "Bitrate_label_예상_출력_영상_크기";
            this.Bitrate_label_예상_출력_영상_크기.Size = new System.Drawing.Size(168, 23);
            this.Bitrate_label_예상_출력_영상_크기.TabIndex = 2;
            this.Bitrate_label_예상_출력_영상_크기.Text = "예상 출력 영상 크기:";
            this.Bitrate_label_예상_출력_영상_크기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.Bitrate_label_예상_출력_영상_크기, "최대 영상 비트레이트로 원본 영상을 재 인코딩할 때 예상되는 출력 영상의 크기입니다.");
            // 
            // Bitrate_comboBox_예상_출력_영상_크기_단위
            // 
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.FormattingEnabled = true;
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.Location = new System.Drawing.Point(174, 2);
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.Margin = new System.Windows.Forms.Padding(2);
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.Name = "Bitrate_comboBox_예상_출력_영상_크기_단위";
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.Size = new System.Drawing.Size(52, 28);
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.TabIndex = 1;
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.Text = "MB";
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.Enter += new System.EventHandler(this.ControlEnter);
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.Bitrate_comboBox_예상_출력_영상_크기_단위.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // Bitrate_label_ShowValue_최대_영상_비트레이트
            // 
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.AutoSize = true;
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.Location = new System.Drawing.Point(270, 9);
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.Name = "Bitrate_label_ShowValue_최대_영상_비트레이트";
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.Size = new System.Drawing.Size(16, 23);
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.TabIndex = 0;
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.Text = " ";
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_toolTip.SetToolTip(this.Bitrate_label_ShowValue_최대_영상_비트레이트, "원본 영상 파일 정보를 토대로 계산된 최대 품질의 영상으로 인코딩 할 수 있는 영상 비트레이트 값입니다.\r\n이 이상의 영상 비트레이트 값은 출력 " +
        "영상 품질에 영향을 끼치지 않습니다.\r\n클릭하면 값이 복사됩니다. (단축키: Ctrl+D)");
            this.Bitrate_label_ShowValue_최대_영상_비트레이트.Click += new System.EventHandler(this.Bitrate_label_ShowValue_최대_영상_비트레이트_Click);
            // 
            // Bitrate_컨flowLayoutPanel_최대_영상_비트레이트
            // 
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.AutoSize = true;
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.Controls.Add(this.Bitrate_label_최대_영상_비트레이트);
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.Controls.Add(this.Bitrate_comboBox_Bitrate_단위);
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.Location = new System.Drawing.Point(5, 4);
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.Name = "Bitrate_컨flowLayoutPanel_최대_영상_비트레이트";
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.Size = new System.Drawing.Size(261, 32);
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.TabIndex = 1;
            this.Main_toolTip.SetToolTip(this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트, "원본 영상 파일 정보를 토대로 계산된 최대 품질의 영상으로 인코딩 할 수 있는 영상 비트레이트 값입니다.\r\n이 이상의 영상 비트레이트 값은 출력 " +
        "영상 품질에 영향을 끼치지 않습니다.");
            // 
            // Bitrate_label_최대_영상_비트레이트
            // 
            this.Bitrate_label_최대_영상_비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bitrate_label_최대_영상_비트레이트.AutoSize = true;
            this.Bitrate_label_최대_영상_비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bitrate_label_최대_영상_비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bitrate_label_최대_영상_비트레이트.Location = new System.Drawing.Point(2, 4);
            this.Bitrate_label_최대_영상_비트레이트.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bitrate_label_최대_영상_비트레이트.Name = "Bitrate_label_최대_영상_비트레이트";
            this.Bitrate_label_최대_영상_비트레이트.Size = new System.Drawing.Size(179, 23);
            this.Bitrate_label_최대_영상_비트레이트.TabIndex = 0;
            this.Bitrate_label_최대_영상_비트레이트.Text = "최대 영상 비트레이트:";
            this.Bitrate_label_최대_영상_비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.Bitrate_label_최대_영상_비트레이트, "원본 영상 파일 정보를 토대로 계산된 최대 품질의 영상으로 인코딩 할 수 있는 영상 비트레이트 값입니다.\r\n이 이상의 영상 비트레이트 값은 출력 " +
        "영상 품질에 영향을 끼치지 않습니다.\r\n클릭하면 값이 복사됩니다. (단축키: Ctrl+D)");
            this.Bitrate_label_최대_영상_비트레이트.Click += new System.EventHandler(this.Bitrate_label_최대_영상_비트레이트_Click);
            // 
            // Bitrate_comboBox_Bitrate_단위
            // 
            this.Bitrate_comboBox_Bitrate_단위.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Bitrate_comboBox_Bitrate_단위.FormattingEnabled = true;
            this.Bitrate_comboBox_Bitrate_단위.Items.AddRange(new object[] {
            "Kbps",
            "Mbps"});
            this.Bitrate_comboBox_Bitrate_단위.Location = new System.Drawing.Point(185, 2);
            this.Bitrate_comboBox_Bitrate_단위.Margin = new System.Windows.Forms.Padding(2);
            this.Bitrate_comboBox_Bitrate_단위.Name = "Bitrate_comboBox_Bitrate_단위";
            this.Bitrate_comboBox_Bitrate_단위.Size = new System.Drawing.Size(74, 28);
            this.Bitrate_comboBox_Bitrate_단위.TabIndex = 3;
            this.Bitrate_comboBox_Bitrate_단위.Text = "Kbps";
            this.Bitrate_comboBox_Bitrate_단위.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.Bitrate_comboBox_Bitrate_단위.Enter += new System.EventHandler(this.ControlEnter);
            this.Bitrate_comboBox_Bitrate_단위.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.Bitrate_comboBox_Bitrate_단위.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // OutSizeBasedBitrate_컨_groupBox
            // 
            this.OutSizeBasedBitrate_컨_groupBox.Controls.Add(this.OutSizeBasedBitrate_컨_tableLayoutPanel);
            this.OutSizeBasedBitrate_컨_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutSizeBasedBitrate_컨_groupBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutSizeBasedBitrate_컨_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutSizeBasedBitrate_컨_groupBox.Location = new System.Drawing.Point(446, 2);
            this.OutSizeBasedBitrate_컨_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_컨_groupBox.Name = "OutSizeBasedBitrate_컨_groupBox";
            this.OutSizeBasedBitrate_컨_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_컨_groupBox.Size = new System.Drawing.Size(434, 109);
            this.OutSizeBasedBitrate_컨_groupBox.TabIndex = 2;
            this.OutSizeBasedBitrate_컨_groupBox.TabStop = false;
            this.OutSizeBasedBitrate_컨_groupBox.Text = "출력 영상 크기 기준 영상 비트레이트 계산";
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_컨_groupBox, "원본 영상 파일 정보를 토대로 하여 원하는 크기가 되도록 원본 영상을 재 인코딩 할 때의 영상 비트레이트를 계산합니다.");
            // 
            // OutSizeBasedBitrate_컨_tableLayoutPanel
            // 
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.ColumnCount = 2;
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.05882F));
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.94118F));
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Controls.Add(this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기, 1, 0);
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Controls.Add(this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기, 0, 0);
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Controls.Add(this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트, 1, 1);
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Controls.Add(this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트, 0, 1);
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Location = new System.Drawing.Point(2, 24);
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Name = "OutSizeBasedBitrate_컨_tableLayoutPanel";
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.RowCount = 2;
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.Size = new System.Drawing.Size(430, 83);
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.TabIndex = 0;
            // 
            // OutSizeBasedBitrate_textBox_원하는_출력_영상_크기
            // 
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.BackColor = System.Drawing.SystemColors.Window;
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.Location = new System.Drawing.Point(268, 8);
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.MaxLength = 10;
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.Name = "OutSizeBasedBitrate_textBox_원하는_출력_영상_크기";
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.Size = new System.Drawing.Size(85, 27);
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.TabIndex = 2;
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기, "원본 영상을 재 인코딩 할 때 적용되는 출력 영상 크기를 설정합니다.");
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.Enter += new System.EventHandler(this.ControlEnter);
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OutSizeBasedBitrate_textBox_원하는_출력_영상_크기.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기
            // 
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.AutoSize = true;
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.Controls.Add(this.OutSizeBasedBitrate_label_원하는_출력_영상_크기);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.Controls.Add(this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.Location = new System.Drawing.Point(19, 5);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.Name = "OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기";
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.Size = new System.Drawing.Size(245, 32);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.TabIndex = 1;
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기, "원본 영상을 재 인코딩 할 때 적용되는 출력 영상 크기를 설정합니다.");
            // 
            // OutSizeBasedBitrate_label_원하는_출력_영상_크기
            // 
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.AutoSize = true;
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.Location = new System.Drawing.Point(2, 4);
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.Name = "OutSizeBasedBitrate_label_원하는_출력_영상_크기";
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.Size = new System.Drawing.Size(185, 23);
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.TabIndex = 0;
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.Text = "원하는 출력 영상 크기:";
            this.OutSizeBasedBitrate_label_원하는_출력_영상_크기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_label_원하는_출력_영상_크기, "원본 영상을 재 인코딩 할 때 적용되는 출력 영상 크기를 설정합니다.");
            // 
            // OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위
            // 
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.BackColor = System.Drawing.SystemColors.Window;
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.FormattingEnabled = true;
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.Location = new System.Drawing.Point(191, 2);
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.Name = "OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위";
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.Size = new System.Drawing.Size(52, 28);
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.TabIndex = 1;
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.Text = "MB";
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위, "원본 영상을 재 인코딩 할 때 적용되는 출력 영상 크기를 설정합니다.");
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.Enter += new System.EventHandler(this.ControlEnter);
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // OutSizeBasedBitrate_label_ShowValue_영상_비트레이트
            // 
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.AutoSize = true;
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.Location = new System.Drawing.Point(268, 51);
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.Name = "OutSizeBasedBitrate_label_ShowValue_영상_비트레이트";
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.Size = new System.Drawing.Size(16, 23);
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.TabIndex = 0;
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.Text = " ";
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트, "원본 영상을 재 인코딩할 때 원하는 출력 영상 크기가 되도록 하는 영상 비트레이트 값입니다.\r\n클릭하면 값이 복사됩니다. (단축키: Ctrl+F)" +
        "");
            this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트.Click += new System.EventHandler(this.OutSizeBasedBitrate_label_ShowValue_영상_비트레이트_Click);
            // 
            // OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트
            // 
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.AutoSize = true;
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.Controls.Add(this.OutSizeBasedBitrate_label_예상_영상_비트레이트);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.Controls.Add(this.OutSizeBasedBitrate_comboBox_Bitrate_단위);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.Location = new System.Drawing.Point(3, 47);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.Name = "OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트";
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.Size = new System.Drawing.Size(261, 32);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.TabIndex = 3;
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트, "원본 영상을 재 인코딩할 때 원하는 출력 영상 크기가 되도록 하는 영상 비트레이트 값입니다.");
            // 
            // OutSizeBasedBitrate_label_예상_영상_비트레이트
            // 
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.AutoSize = true;
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.Location = new System.Drawing.Point(2, 4);
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.Name = "OutSizeBasedBitrate_label_예상_영상_비트레이트";
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.Size = new System.Drawing.Size(179, 23);
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.TabIndex = 2;
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.Text = "예상 영상 비트레이트:";
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_toolTip.SetToolTip(this.OutSizeBasedBitrate_label_예상_영상_비트레이트, "원본 영상을 재 인코딩할 때 원하는 출력 영상 크기가 되도록 하는 영상 비트레이트 값입니다.\r\n클릭하면 값이 복사됩니다. (단축키: Ctrl+F)" +
        "");
            this.OutSizeBasedBitrate_label_예상_영상_비트레이트.Click += new System.EventHandler(this.OutSizeBasedBitrate_label_예상_영상_비트레이트_Click);
            // 
            // OutSizeBasedBitrate_comboBox_Bitrate_단위
            // 
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.FormattingEnabled = true;
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.Items.AddRange(new object[] {
            "Kbps",
            "Mbps"});
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.Location = new System.Drawing.Point(185, 2);
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.Margin = new System.Windows.Forms.Padding(2);
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.Name = "OutSizeBasedBitrate_comboBox_Bitrate_단위";
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.Size = new System.Drawing.Size(74, 28);
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.TabIndex = 4;
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.Text = "Kbps";
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.Enter += new System.EventHandler(this.ControlEnter);
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.OutSizeBasedBitrate_comboBox_Bitrate_단위.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // ConvertResolution_컨_tableLayoutPanel1
            // 
            this.ConvertResolution_컨_tableLayoutPanel1.ColumnCount = 2;
            this.ConvertResolution_컨_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConvertResolution_컨_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.ConvertResolution_컨_tableLayoutPanel1.Controls.Add(this.Main_button_제작자, 0, 1);
            this.ConvertResolution_컨_tableLayoutPanel1.Controls.Add(this.ConvertResolution_컨_groupBox, 0, 0);
            this.ConvertResolution_컨_tableLayoutPanel1.Controls.Add(this.Main_컨flowLayoutPanel_버튼, 1, 1);
            this.ConvertResolution_컨_tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertResolution_컨_tableLayoutPanel1.Location = new System.Drawing.Point(446, 115);
            this.ConvertResolution_컨_tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_컨_tableLayoutPanel1.Name = "ConvertResolution_컨_tableLayoutPanel1";
            this.ConvertResolution_컨_tableLayoutPanel1.RowCount = 2;
            this.Main_컨tableLayoutPanel.SetRowSpan(this.ConvertResolution_컨_tableLayoutPanel1, 2);
            this.ConvertResolution_컨_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConvertResolution_컨_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.ConvertResolution_컨_tableLayoutPanel1.Size = new System.Drawing.Size(434, 261);
            this.ConvertResolution_컨_tableLayoutPanel1.TabIndex = 6;
            // 
            // Main_button_제작자
            // 
            this.Main_button_제작자.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Main_button_제작자.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Main_button_제작자.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Main_button_제작자.Location = new System.Drawing.Point(2, 221);
            this.Main_button_제작자.Margin = new System.Windows.Forms.Padding(2);
            this.Main_button_제작자.Name = "Main_button_제작자";
            this.Main_button_제작자.Size = new System.Drawing.Size(99, 34);
            this.Main_button_제작자.TabIndex = 4;
            this.Main_button_제작자.Text = "제작자";
            this.Main_button_제작자.UseVisualStyleBackColor = true;
            this.Main_button_제작자.Click += new System.EventHandler(this.Main_button_제작자_Click);
            // 
            // ConvertResolution_컨_groupBox
            // 
            this.ConvertResolution_컨_tableLayoutPanel1.SetColumnSpan(this.ConvertResolution_컨_groupBox, 2);
            this.ConvertResolution_컨_groupBox.Controls.Add(this.ConvertResolution_컨_tableLayoutPanel2);
            this.ConvertResolution_컨_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertResolution_컨_groupBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_컨_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_컨_groupBox.Location = new System.Drawing.Point(2, 2);
            this.ConvertResolution_컨_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_컨_groupBox.Name = "ConvertResolution_컨_groupBox";
            this.ConvertResolution_컨_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_컨_groupBox.Size = new System.Drawing.Size(430, 211);
            this.ConvertResolution_컨_groupBox.TabIndex = 3;
            this.ConvertResolution_컨_groupBox.TabStop = false;
            this.ConvertResolution_컨_groupBox.Text = "해상도 변환";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_컨_groupBox, "원본 영상의 화면 해상도를 변환 기준을 토대로 하여 동일한 비율로 확대하거나 축소합니다.");
            // 
            // ConvertResolution_컨_tableLayoutPanel2
            // 
            this.ConvertResolution_컨_tableLayoutPanel2.ColumnCount = 2;
            this.ConvertResolution_컨_tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.97619F));
            this.ConvertResolution_컨_tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.02381F));
            this.ConvertResolution_컨_tableLayoutPanel2.Controls.Add(this.ConvertResolution_label_현재해상도, 0, 0);
            this.ConvertResolution_컨_tableLayoutPanel2.Controls.Add(this.ConvertResolution_button_적용, 1, 4);
            this.ConvertResolution_컨_tableLayoutPanel2.Controls.Add(this.ConvertResolution_컨flowLayoutPanel_기준, 1, 1);
            this.ConvertResolution_컨_tableLayoutPanel2.Controls.Add(this.ConvertResolution_label_변환예상해상도, 0, 2);
            this.ConvertResolution_컨_tableLayoutPanel2.Controls.Add(this.ConvertResolution_컨flowLayoutPanel_변환예상해상도, 1, 2);
            this.ConvertResolution_컨_tableLayoutPanel2.Controls.Add(this.ConvertResolution_label_변환기준, 0, 1);
            this.ConvertResolution_컨_tableLayoutPanel2.Controls.Add(this.ConvertResolution_컨flowLayoutPanel_현재해상도, 1, 0);
            this.ConvertResolution_컨_tableLayoutPanel2.Controls.Add(this.ConvertResolution_label_ShowValue_변환예상크기, 1, 3);
            this.ConvertResolution_컨_tableLayoutPanel2.Controls.Add(this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기, 0, 3);
            this.ConvertResolution_컨_tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertResolution_컨_tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_컨_tableLayoutPanel2.Location = new System.Drawing.Point(2, 24);
            this.ConvertResolution_컨_tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_컨_tableLayoutPanel2.Name = "ConvertResolution_컨_tableLayoutPanel2";
            this.ConvertResolution_컨_tableLayoutPanel2.RowCount = 5;
            this.ConvertResolution_컨_tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.5F));
            this.ConvertResolution_컨_tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.5F));
            this.ConvertResolution_컨_tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.5F));
            this.ConvertResolution_컨_tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.5F));
            this.ConvertResolution_컨_tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ConvertResolution_컨_tableLayoutPanel2.Size = new System.Drawing.Size(426, 185);
            this.ConvertResolution_컨_tableLayoutPanel2.TabIndex = 0;
            // 
            // ConvertResolution_label_현재해상도
            // 
            this.ConvertResolution_label_현재해상도.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConvertResolution_label_현재해상도.AutoSize = true;
            this.ConvertResolution_label_현재해상도.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_현재해상도.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_현재해상도.Location = new System.Drawing.Point(90, 3);
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
            this.ConvertResolution_button_적용.Location = new System.Drawing.Point(346, 150);
            this.ConvertResolution_button_적용.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_button_적용.Name = "ConvertResolution_button_적용";
            this.ConvertResolution_button_적용.Size = new System.Drawing.Size(78, 33);
            this.ConvertResolution_button_적용.TabIndex = 7;
            this.ConvertResolution_button_적용.Text = "적용";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_button_적용, "변환 예상 해상도를 원본 영상 파일 정보에 적용합니다. (단축키: Ctrl+S)");
            this.ConvertResolution_button_적용.UseVisualStyleBackColor = true;
            this.ConvertResolution_button_적용.Click += new System.EventHandler(this.ConvertResolution_button_적용_Click);
            // 
            // ConvertResolution_컨flowLayoutPanel_기준
            // 
            this.ConvertResolution_컨flowLayoutPanel_기준.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_컨flowLayoutPanel_기준.AutoSize = true;
            this.ConvertResolution_컨flowLayoutPanel_기준.Controls.Add(this.ConvertResolution_comboBox_기준);
            this.ConvertResolution_컨flowLayoutPanel_기준.Controls.Add(this.ConvertResolution_textBox_기준픽셀);
            this.ConvertResolution_컨flowLayoutPanel_기준.Location = new System.Drawing.Point(227, 35);
            this.ConvertResolution_컨flowLayoutPanel_기준.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_컨flowLayoutPanel_기준.Name = "ConvertResolution_컨flowLayoutPanel_기준";
            this.ConvertResolution_컨flowLayoutPanel_기준.Size = new System.Drawing.Size(105, 32);
            this.ConvertResolution_컨flowLayoutPanel_기준.TabIndex = 2;
            this.Main_toolTip.SetToolTip(this.ConvertResolution_컨flowLayoutPanel_기준, "해상도 변환의 기준이 되는 해상도의 가로 길이 또는 세로 길이를 설정합니다.");
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
            this.ConvertResolution_comboBox_기준.TabIndex = 1;
            this.ConvertResolution_comboBox_기준.Text = "가로";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_comboBox_기준, "해상도 변환의 기준이 되는 해상도의 가로 길이 또는 세로 길이를 설정합니다.");
            this.ConvertResolution_comboBox_기준.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.ConvertResolution_comboBox_기준.Enter += new System.EventHandler(this.ControlEnter);
            this.ConvertResolution_comboBox_기준.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.ConvertResolution_comboBox_기준.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // ConvertResolution_textBox_기준픽셀
            // 
            this.ConvertResolution_textBox_기준픽셀.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_textBox_기준픽셀.BackColor = System.Drawing.SystemColors.Window;
            this.ConvertResolution_textBox_기준픽셀.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ConvertResolution_textBox_기준픽셀.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_textBox_기준픽셀.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ConvertResolution_textBox_기준픽셀.Location = new System.Drawing.Point(64, 2);
            this.ConvertResolution_textBox_기준픽셀.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_textBox_기준픽셀.MaxLength = 4;
            this.ConvertResolution_textBox_기준픽셀.Name = "ConvertResolution_textBox_기준픽셀";
            this.ConvertResolution_textBox_기준픽셀.Size = new System.Drawing.Size(39, 27);
            this.ConvertResolution_textBox_기준픽셀.TabIndex = 2;
            this.ConvertResolution_textBox_기준픽셀.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main_toolTip.SetToolTip(this.ConvertResolution_textBox_기준픽셀, "해상도 변환의 기준이 되는 해상도의 가로 길이 또는 세로 길이를 설정합니다.");
            this.ConvertResolution_textBox_기준픽셀.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.ConvertResolution_textBox_기준픽셀.Enter += new System.EventHandler(this.ControlEnter);
            this.ConvertResolution_textBox_기준픽셀.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.ConvertResolution_textBox_기준픽셀.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // ConvertResolution_label_변환예상해상도
            // 
            this.ConvertResolution_label_변환예상해상도.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConvertResolution_label_변환예상해상도.AutoSize = true;
            this.ConvertResolution_label_변환예상해상도.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_변환예상해상도.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_변환예상해상도.Location = new System.Drawing.Point(50, 76);
            this.ConvertResolution_label_변환예상해상도.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_변환예상해상도.Name = "ConvertResolution_label_변환예상해상도";
            this.ConvertResolution_label_변환예상해상도.Size = new System.Drawing.Size(173, 23);
            this.ConvertResolution_label_변환예상해상도.TabIndex = 3;
            this.ConvertResolution_label_변환예상해상도.Text = "변환 예상 해상도(px):";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_변환예상해상도, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            // 
            // ConvertResolution_컨flowLayoutPanel_변환예상해상도
            // 
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.AutoSize = true;
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.Controls.Add(this.ConvertResolution_label_ShowValue_변환예상해상도_가로);
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.Controls.Add(this.ConvertResolution_label_x_2);
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.Controls.Add(this.ConvertResolution_label_ShowValue_변환예상해상도_세로);
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.Location = new System.Drawing.Point(227, 76);
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.Name = "ConvertResolution_컨flowLayoutPanel_변환예상해상도";
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.Size = new System.Drawing.Size(72, 23);
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.TabIndex = 4;
            this.Main_toolTip.SetToolTip(this.ConvertResolution_컨flowLayoutPanel_변환예상해상도, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            // 
            // ConvertResolution_label_ShowValue_변환예상해상도_가로
            // 
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.AutoSize = true;
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.Location = new System.Drawing.Point(2, 0);
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.Name = "ConvertResolution_label_ShowValue_변환예상해상도_가로";
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.Size = new System.Drawing.Size(19, 23);
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.TabIndex = 0;
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.Text = "0";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_ShowValue_변환예상해상도_가로, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            this.ConvertResolution_label_ShowValue_변환예상해상도_가로.TextChanged += new System.EventHandler(this.ControlTextChanged);
            // 
            // ConvertResolution_label_x_2
            // 
            this.ConvertResolution_label_x_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_x_2.AutoSize = true;
            this.ConvertResolution_label_x_2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_x_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_x_2.Location = new System.Drawing.Point(25, 0);
            this.ConvertResolution_label_x_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_x_2.Name = "ConvertResolution_label_x_2";
            this.ConvertResolution_label_x_2.Size = new System.Drawing.Size(22, 23);
            this.ConvertResolution_label_x_2.TabIndex = 2;
            this.ConvertResolution_label_x_2.Text = "×";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_x_2, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            // 
            // ConvertResolution_label_ShowValue_변환예상해상도_세로
            // 
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.AutoSize = true;
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.Location = new System.Drawing.Point(51, 0);
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.Name = "ConvertResolution_label_ShowValue_변환예상해상도_세로";
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.Size = new System.Drawing.Size(19, 23);
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.TabIndex = 3;
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.Text = "0";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_ShowValue_변환예상해상도_세로, "변환 기준을 토대로 계산된 화면 해상도입니다.");
            this.ConvertResolution_label_ShowValue_변환예상해상도_세로.TextChanged += new System.EventHandler(this.ControlTextChanged);
            // 
            // ConvertResolution_label_변환기준
            // 
            this.ConvertResolution_label_변환기준.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConvertResolution_label_변환기준.AutoSize = true;
            this.ConvertResolution_label_변환기준.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_변환기준.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_변환기준.Location = new System.Drawing.Point(107, 40);
            this.ConvertResolution_label_변환기준.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_변환기준.Name = "ConvertResolution_label_변환기준";
            this.ConvertResolution_label_변환기준.Size = new System.Drawing.Size(116, 23);
            this.ConvertResolution_label_변환기준.TabIndex = 1;
            this.ConvertResolution_label_변환기준.Text = "변환 기준(px):";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_변환기준, "해상도 변환의 기준이 되는 해상도의 가로 길이 또는 세로 길이를 설정합니다.");
            // 
            // ConvertResolution_컨flowLayoutPanel_현재해상도
            // 
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.AutoSize = true;
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.Controls.Add(this.ConvertResolution_label_ShowValue_현재해상도_가로);
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.Controls.Add(this.ConvertResolution_label_x_1);
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.Controls.Add(this.ConvertResolution_label_ShowValue_현재해상도_세로);
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.Location = new System.Drawing.Point(227, 3);
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.Name = "ConvertResolution_컨flowLayoutPanel_현재해상도";
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.Size = new System.Drawing.Size(72, 23);
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.TabIndex = 0;
            this.Main_toolTip.SetToolTip(this.ConvertResolution_컨flowLayoutPanel_현재해상도, "원본 영상 파일 정보에서 설정된 화면 해상도입니다.");
            // 
            // ConvertResolution_label_ShowValue_현재해상도_가로
            // 
            this.ConvertResolution_label_ShowValue_현재해상도_가로.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_ShowValue_현재해상도_가로.AutoSize = true;
            this.ConvertResolution_label_ShowValue_현재해상도_가로.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_ShowValue_현재해상도_가로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_ShowValue_현재해상도_가로.Location = new System.Drawing.Point(2, 0);
            this.ConvertResolution_label_ShowValue_현재해상도_가로.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_ShowValue_현재해상도_가로.Name = "ConvertResolution_label_ShowValue_현재해상도_가로";
            this.ConvertResolution_label_ShowValue_현재해상도_가로.Size = new System.Drawing.Size(19, 23);
            this.ConvertResolution_label_ShowValue_현재해상도_가로.TabIndex = 1;
            this.ConvertResolution_label_ShowValue_현재해상도_가로.Text = "0";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_ShowValue_현재해상도_가로, "원본 영상 파일 정보에서 설정된 화면 해상도입니다.");
            // 
            // ConvertResolution_label_x_1
            // 
            this.ConvertResolution_label_x_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_x_1.AutoSize = true;
            this.ConvertResolution_label_x_1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_x_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_x_1.Location = new System.Drawing.Point(25, 0);
            this.ConvertResolution_label_x_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_x_1.Name = "ConvertResolution_label_x_1";
            this.ConvertResolution_label_x_1.Size = new System.Drawing.Size(22, 23);
            this.ConvertResolution_label_x_1.TabIndex = 3;
            this.ConvertResolution_label_x_1.Text = "×";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_x_1, "원본 영상 파일 정보에서 설정된 화면 해상도입니다.");
            // 
            // ConvertResolution_label_ShowValue_현재해상도_세로
            // 
            this.ConvertResolution_label_ShowValue_현재해상도_세로.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_ShowValue_현재해상도_세로.AutoSize = true;
            this.ConvertResolution_label_ShowValue_현재해상도_세로.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_ShowValue_현재해상도_세로.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_ShowValue_현재해상도_세로.Location = new System.Drawing.Point(51, 0);
            this.ConvertResolution_label_ShowValue_현재해상도_세로.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_ShowValue_현재해상도_세로.Name = "ConvertResolution_label_ShowValue_현재해상도_세로";
            this.ConvertResolution_label_ShowValue_현재해상도_세로.Size = new System.Drawing.Size(19, 23);
            this.ConvertResolution_label_ShowValue_현재해상도_세로.TabIndex = 4;
            this.ConvertResolution_label_ShowValue_현재해상도_세로.Text = "0";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_ShowValue_현재해상도_세로, "원본 영상 파일 정보에서 설정된 화면 해상도입니다.");
            // 
            // ConvertResolution_label_ShowValue_변환예상크기
            // 
            this.ConvertResolution_label_ShowValue_변환예상크기.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_ShowValue_변환예상크기.AutoSize = true;
            this.ConvertResolution_label_ShowValue_변환예상크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_ShowValue_변환예상크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_ShowValue_변환예상크기.Location = new System.Drawing.Point(227, 113);
            this.ConvertResolution_label_ShowValue_변환예상크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_ShowValue_변환예상크기.Name = "ConvertResolution_label_ShowValue_변환예상크기";
            this.ConvertResolution_label_ShowValue_변환예상크기.Size = new System.Drawing.Size(16, 23);
            this.ConvertResolution_label_ShowValue_변환예상크기.TabIndex = 0;
            this.ConvertResolution_label_ShowValue_변환예상크기.Text = " ";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_ShowValue_변환예상크기, "변환 예상 해상도로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // ConvertResolution_컨flowLayoutPanel_변환예상파일크기
            // 
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.AutoSize = true;
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.Controls.Add(this.ConvertResolution_label_변환예상영상크기);
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.Controls.Add(this.ConvertResolution_comboBox_변환예상크기단위);
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.Controls.Add(this.ConvertResolution_label_colon);
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.Location = new System.Drawing.Point(23, 108);
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.Name = "ConvertResolution_컨flowLayoutPanel_변환예상파일크기";
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.Size = new System.Drawing.Size(200, 32);
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.TabIndex = 6;
            this.Main_toolTip.SetToolTip(this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기, "변환 예상 해상도로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // ConvertResolution_label_변환예상영상크기
            // 
            this.ConvertResolution_label_변환예상영상크기.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConvertResolution_label_변환예상영상크기.AutoSize = true;
            this.ConvertResolution_label_변환예상영상크기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertResolution_label_변환예상영상크기.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConvertResolution_label_변환예상영상크기.Location = new System.Drawing.Point(2, 4);
            this.ConvertResolution_label_변환예상영상크기.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_변환예상영상크기.Name = "ConvertResolution_label_변환예상영상크기";
            this.ConvertResolution_label_변환예상영상크기.Size = new System.Drawing.Size(124, 23);
            this.ConvertResolution_label_변환예상영상크기.TabIndex = 5;
            this.ConvertResolution_label_변환예상영상크기.Text = "변환 예상 크기";
            this.Main_toolTip.SetToolTip(this.ConvertResolution_label_변환예상영상크기, "변환 예상 해상도로 원본 영상을 재 인코딩할 때 예상되는 영상의 크기입니다.");
            // 
            // ConvertResolution_comboBox_변환예상크기단위
            // 
            this.ConvertResolution_comboBox_변환예상크기단위.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ConvertResolution_comboBox_변환예상크기단위.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ConvertResolution_comboBox_변환예상크기단위.FormattingEnabled = true;
            this.ConvertResolution_comboBox_변환예상크기단위.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ConvertResolution_comboBox_변환예상크기단위.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.ConvertResolution_comboBox_변환예상크기단위.Location = new System.Drawing.Point(130, 2);
            this.ConvertResolution_comboBox_변환예상크기단위.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertResolution_comboBox_변환예상크기단위.Name = "ConvertResolution_comboBox_변환예상크기단위";
            this.ConvertResolution_comboBox_변환예상크기단위.Size = new System.Drawing.Size(52, 28);
            this.ConvertResolution_comboBox_변환예상크기단위.TabIndex = 1;
            this.ConvertResolution_comboBox_변환예상크기단위.Text = "MB";
            this.ConvertResolution_comboBox_변환예상크기단위.TextChanged += new System.EventHandler(this.ControlTextChanged);
            this.ConvertResolution_comboBox_변환예상크기단위.Enter += new System.EventHandler(this.ControlEnter);
            this.ConvertResolution_comboBox_변환예상크기단위.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WritableControlKeyDown);
            this.ConvertResolution_comboBox_변환예상크기단위.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // ConvertResolution_label_colon
            // 
            this.ConvertResolution_label_colon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertResolution_label_colon.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.ConvertResolution_label_colon.Location = new System.Drawing.Point(186, 4);
            this.ConvertResolution_label_colon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConvertResolution_label_colon.Name = "ConvertResolution_label_colon";
            this.ConvertResolution_label_colon.Size = new System.Drawing.Size(12, 24);
            this.ConvertResolution_label_colon.TabIndex = 6;
            this.ConvertResolution_label_colon.Text = ":";
            // 
            // Main_컨flowLayoutPanel_버튼
            // 
            this.Main_컨flowLayoutPanel_버튼.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Main_컨flowLayoutPanel_버튼.AutoSize = true;
            this.Main_컨flowLayoutPanel_버튼.Controls.Add(this.Main_button_모두_초기화);
            this.Main_컨flowLayoutPanel_버튼.Controls.Add(this.Main_button_종료);
            this.Main_컨flowLayoutPanel_버튼.Location = new System.Drawing.Point(185, 219);
            this.Main_컨flowLayoutPanel_버튼.Margin = new System.Windows.Forms.Padding(2);
            this.Main_컨flowLayoutPanel_버튼.Name = "Main_컨flowLayoutPanel_버튼";
            this.Main_컨flowLayoutPanel_버튼.Size = new System.Drawing.Size(247, 38);
            this.Main_컨flowLayoutPanel_버튼.TabIndex = 5;
            // 
            // Main_button_모두_초기화
            // 
            this.Main_button_모두_초기화.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_button_모두_초기화.Enabled = false;
            this.Main_button_모두_초기화.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Main_button_모두_초기화.Location = new System.Drawing.Point(2, 2);
            this.Main_button_모두_초기화.Margin = new System.Windows.Forms.Padding(2);
            this.Main_button_모두_초기화.Name = "Main_button_모두_초기화";
            this.Main_button_모두_초기화.Size = new System.Drawing.Size(161, 34);
            this.Main_button_모두_초기화.TabIndex = 0;
            this.Main_button_모두_초기화.Text = "모두 초기화";
            this.Main_toolTip.SetToolTip(this.Main_button_모두_초기화, "설정된 모든 값을 초기화합니다. (단축키: Ctrl+R)");
            this.Main_button_모두_초기화.UseVisualStyleBackColor = true;
            this.Main_button_모두_초기화.Click += new System.EventHandler(this.Main_button_모두_초기화_Click);
            // 
            // Main_button_종료
            // 
            this.Main_button_종료.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_button_종료.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Main_button_종료.Location = new System.Drawing.Point(167, 2);
            this.Main_button_종료.Margin = new System.Windows.Forms.Padding(2);
            this.Main_button_종료.Name = "Main_button_종료";
            this.Main_button_종료.Size = new System.Drawing.Size(78, 34);
            this.Main_button_종료.TabIndex = 1;
            this.Main_button_종료.Text = "종료";
            this.Main_toolTip.SetToolTip(this.Main_button_종료, "프로그램을 종료합니다.");
            this.Main_button_종료.UseVisualStyleBackColor = true;
            this.Main_button_종료.Click += new System.EventHandler(this.Main_button_종료_Click);
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
            this.Main_toolStripStatusLabel});
            this.Main_statusStrip.Location = new System.Drawing.Point(0, 404);
            this.Main_statusStrip.Name = "Main_statusStrip";
            this.Main_statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.Main_statusStrip.Size = new System.Drawing.Size(882, 29);
            this.Main_statusStrip.SizingGrip = false;
            this.Main_statusStrip.TabIndex = 2;
            this.Main_statusStrip.Text = "statusStrip";
            // 
            // Main_toolStripStatusLabel
            // 
            this.Main_toolStripStatusLabel.Name = "Main_toolStripStatusLabel";
            this.Main_toolStripStatusLabel.Size = new System.Drawing.Size(16, 23);
            this.Main_toolStripStatusLabel.Text = " ";
            // 
            // Main_timer
            // 
            this.Main_timer.Interval = 3000;
            // 
            // Main_ToolStripMenuItem_파일
            // 
            this.Main_ToolStripMenuItem_파일.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_ToolStripMenuItem_해상도변환적용,
            this.Main_ToolStripMenuItem_원본영상파일정보초기화,
            this.Main_ToolStripMenuItem_모두초기화,
            this.Main_toolStripSeparator1,
            this.Main_ToolStripMenuItem_최대영상비트레이트복사,
            this.Main_ToolStripMenuItem_예상영상비트레이트복사,
            this.Main_ToolStripMenuItem_표시소수점정밀도설정,
            this.Main_toolStripSeparator22,
            this.Main_ToolStripMenuItem_종료});
            this.Main_ToolStripMenuItem_파일.Name = "Main_ToolStripMenuItem_파일";
            this.Main_ToolStripMenuItem_파일.Size = new System.Drawing.Size(77, 24);
            this.Main_ToolStripMenuItem_파일.Text = "메뉴(&M)";
            // 
            // Main_ToolStripMenuItem_해상도변환적용
            // 
            this.Main_ToolStripMenuItem_해상도변환적용.Enabled = false;
            this.Main_ToolStripMenuItem_해상도변환적용.Name = "Main_ToolStripMenuItem_해상도변환적용";
            this.Main_ToolStripMenuItem_해상도변환적용.Size = new System.Drawing.Size(364, 26);
            this.Main_ToolStripMenuItem_해상도변환적용.Text = "해상도 변환 적용(&S)                  Ctrl+S";
            this.Main_ToolStripMenuItem_해상도변환적용.Click += new System.EventHandler(this.해상도변환적용ToolStripMenuItem_Click);
            // 
            // Main_ToolStripMenuItem_원본영상파일정보초기화
            // 
            this.Main_ToolStripMenuItem_원본영상파일정보초기화.Enabled = false;
            this.Main_ToolStripMenuItem_원본영상파일정보초기화.Name = "Main_ToolStripMenuItem_원본영상파일정보초기화";
            this.Main_ToolStripMenuItem_원본영상파일정보초기화.Size = new System.Drawing.Size(364, 26);
            this.Main_ToolStripMenuItem_원본영상파일정보초기화.Text = "원본 영상 파일 정보 초기화(&W)  Ctrl+W";
            this.Main_ToolStripMenuItem_원본영상파일정보초기화.Click += new System.EventHandler(this.원본영상파일정보초기화ToolStripMenuItem_Click);
            // 
            // Main_ToolStripMenuItem_모두초기화
            // 
            this.Main_ToolStripMenuItem_모두초기화.Enabled = false;
            this.Main_ToolStripMenuItem_모두초기화.Name = "Main_ToolStripMenuItem_모두초기화";
            this.Main_ToolStripMenuItem_모두초기화.ShortcutKeyDisplayString = "";
            this.Main_ToolStripMenuItem_모두초기화.Size = new System.Drawing.Size(364, 26);
            this.Main_ToolStripMenuItem_모두초기화.Text = "모두 초기화(&R)                         Ctrl+R";
            this.Main_ToolStripMenuItem_모두초기화.Click += new System.EventHandler(this.모두초기화ToolStripMenuItem_Click);
            // 
            // Main_toolStripSeparator1
            // 
            this.Main_toolStripSeparator1.Name = "Main_toolStripSeparator1";
            this.Main_toolStripSeparator1.Size = new System.Drawing.Size(361, 6);
            // 
            // Main_ToolStripMenuItem_최대영상비트레이트복사
            // 
            this.Main_ToolStripMenuItem_최대영상비트레이트복사.Name = "Main_ToolStripMenuItem_최대영상비트레이트복사";
            this.Main_ToolStripMenuItem_최대영상비트레이트복사.Size = new System.Drawing.Size(364, 26);
            this.Main_ToolStripMenuItem_최대영상비트레이트복사.Text = "최대 영상 비트레이트 복사(&D)     Ctrl+D";
            this.Main_ToolStripMenuItem_최대영상비트레이트복사.Click += new System.EventHandler(this.최대영상비트레이트복사MToolStripMenuItem_Click);
            // 
            // Main_ToolStripMenuItem_예상영상비트레이트복사
            // 
            this.Main_ToolStripMenuItem_예상영상비트레이트복사.Name = "Main_ToolStripMenuItem_예상영상비트레이트복사";
            this.Main_ToolStripMenuItem_예상영상비트레이트복사.Size = new System.Drawing.Size(364, 26);
            this.Main_ToolStripMenuItem_예상영상비트레이트복사.Text = "예상 영상 비트레이트 복사(&F)      Ctrl+F";
            this.Main_ToolStripMenuItem_예상영상비트레이트복사.Click += new System.EventHandler(this.예상영상비트레이트복사EToolStripMenuItem_Click);
            // 
            // Main_ToolStripMenuItem_표시소수점정밀도설정
            // 
            this.Main_ToolStripMenuItem_표시소수점정밀도설정.Name = "Main_ToolStripMenuItem_표시소수점정밀도설정";
            this.Main_ToolStripMenuItem_표시소수점정밀도설정.Size = new System.Drawing.Size(364, 26);
            this.Main_ToolStripMenuItem_표시소수점정밀도설정.Text = "표시 소수점 정밀도 설정...";
            this.Main_ToolStripMenuItem_표시소수점정밀도설정.Click += new System.EventHandler(this.영상비트레이트소수점설정ToolStripMenuItem_Click);
            // 
            // Main_toolStripSeparator22
            // 
            this.Main_toolStripSeparator22.Name = "Main_toolStripSeparator22";
            this.Main_toolStripSeparator22.Size = new System.Drawing.Size(361, 6);
            // 
            // Main_ToolStripMenuItem_종료
            // 
            this.Main_ToolStripMenuItem_종료.Name = "Main_ToolStripMenuItem_종료";
            this.Main_ToolStripMenuItem_종료.Size = new System.Drawing.Size(364, 26);
            this.Main_ToolStripMenuItem_종료.Text = "종료(&E)                                   Alt+F4";
            this.Main_ToolStripMenuItem_종료.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Main_ToolStripMenuItem_도움말
            // 
            this.Main_ToolStripMenuItem_도움말.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_ToolStripMenuItem_제작자,
            this.Main_toolStripSeparator4,
            this.Main_ToolStripMenuItem_프로그램정보});
            this.Main_ToolStripMenuItem_도움말.Name = "Main_ToolStripMenuItem_도움말";
            this.Main_ToolStripMenuItem_도움말.Size = new System.Drawing.Size(89, 24);
            this.Main_ToolStripMenuItem_도움말.Text = "도움말(&H)";
            // 
            // Main_ToolStripMenuItem_제작자
            // 
            this.Main_ToolStripMenuItem_제작자.Name = "Main_ToolStripMenuItem_제작자";
            this.Main_ToolStripMenuItem_제작자.Size = new System.Drawing.Size(224, 26);
            this.Main_ToolStripMenuItem_제작자.Text = "제작자(&P)...";
            this.Main_ToolStripMenuItem_제작자.Click += new System.EventHandler(this.제작자ToolStripMenuItem_Click);
            // 
            // Main_toolStripSeparator4
            // 
            this.Main_toolStripSeparator4.Name = "Main_toolStripSeparator4";
            this.Main_toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // Main_ToolStripMenuItem_프로그램정보
            // 
            this.Main_ToolStripMenuItem_프로그램정보.Name = "Main_ToolStripMenuItem_프로그램정보";
            this.Main_ToolStripMenuItem_프로그램정보.Size = new System.Drawing.Size(224, 26);
            this.Main_ToolStripMenuItem_프로그램정보.Text = "프로그램 정보(&I)...";
            this.Main_ToolStripMenuItem_프로그램정보.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // Main_menuStrip
            // 
            this.Main_menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.Main_menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_ToolStripMenuItem_파일,
            this.Main_ToolStripMenuItem_편집,
            this.Main_ToolStripMenuItem_도움말});
            this.Main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Main_menuStrip.Name = "Main_menuStrip";
            this.Main_menuStrip.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.Main_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Main_menuStrip.Size = new System.Drawing.Size(882, 26);
            this.Main_menuStrip.TabIndex = 1;
            this.Main_menuStrip.Text = "menuStrip";
            // 
            // Main_ToolStripMenuItem_편집
            // 
            this.Main_ToolStripMenuItem_편집.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_ToolStripMenuItem_전체선택,
            this.Main_toolStripSeparator33,
            this.Main_ToolStripMenuItem_잘라내기,
            this.Main_ToolStripMenuItem_복사,
            this.Main_ToolStripMenuItem_붙여넣기});
            this.Main_ToolStripMenuItem_편집.Name = "Main_ToolStripMenuItem_편집";
            this.Main_ToolStripMenuItem_편집.Size = new System.Drawing.Size(71, 24);
            this.Main_ToolStripMenuItem_편집.Text = "편집(&E)";
            // 
            // Main_ToolStripMenuItem_전체선택
            // 
            this.Main_ToolStripMenuItem_전체선택.Name = "Main_ToolStripMenuItem_전체선택";
            this.Main_ToolStripMenuItem_전체선택.Size = new System.Drawing.Size(252, 26);
            this.Main_ToolStripMenuItem_전체선택.Text = "전체 선택(&A)      Ctrl+A";
            this.Main_ToolStripMenuItem_전체선택.Click += new System.EventHandler(this.전체선택AToolStripMenuItem_Click);
            // 
            // Main_toolStripSeparator33
            // 
            this.Main_toolStripSeparator33.Name = "Main_toolStripSeparator33";
            this.Main_toolStripSeparator33.Size = new System.Drawing.Size(249, 6);
            // 
            // Main_ToolStripMenuItem_잘라내기
            // 
            this.Main_ToolStripMenuItem_잘라내기.Name = "Main_ToolStripMenuItem_잘라내기";
            this.Main_ToolStripMenuItem_잘라내기.Size = new System.Drawing.Size(252, 26);
            this.Main_ToolStripMenuItem_잘라내기.Text = "잘라내기(&X)       Ctrl+X";
            this.Main_ToolStripMenuItem_잘라내기.Click += new System.EventHandler(this.잘라내기XToolStripMenuItem_Click);
            // 
            // Main_ToolStripMenuItem_복사
            // 
            this.Main_ToolStripMenuItem_복사.Name = "Main_ToolStripMenuItem_복사";
            this.Main_ToolStripMenuItem_복사.Size = new System.Drawing.Size(252, 26);
            this.Main_ToolStripMenuItem_복사.Text = "복사(&C)             Ctrl+C";
            this.Main_ToolStripMenuItem_복사.Click += new System.EventHandler(this.복사CToolStripMenuItem_Click);
            // 
            // Main_ToolStripMenuItem_붙여넣기
            // 
            this.Main_ToolStripMenuItem_붙여넣기.Name = "Main_ToolStripMenuItem_붙여넣기";
            this.Main_ToolStripMenuItem_붙여넣기.Size = new System.Drawing.Size(252, 26);
            this.Main_ToolStripMenuItem_붙여넣기.Text = "붙여넣기(&V)       Ctrl+V";
            this.Main_ToolStripMenuItem_붙여넣기.Click += new System.EventHandler(this.붙여넣기VToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(882, 433);
            this.Controls.Add(this.Main_컨tableLayoutPanel);
            this.Controls.Add(this.Main_menuStrip);
            this.Controls.Add(this.Main_statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Main_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "비트레이트 계산기";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Main_컨tableLayoutPanel.ResumeLayout(false);
            this.OriginVidInfo_컨_groupBox.ResumeLayout(false);
            this.OriginVidInfo_컨_tableLayoutPanel1.ResumeLayout(false);
            this.OriginVidInfo_컨_tableLayoutPanel1.PerformLayout();
            this.OriginVidInfo_컨flowLayoutPanel_적용_코덱.ResumeLayout(false);
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.ResumeLayout(false);
            this.OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트.PerformLayout();
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.ResumeLayout(false);
            this.OriginVidInfo_컨flowLayoutPanel_영상_길이.PerformLayout();
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.ResumeLayout(false);
            this.OriginVidInfo_컨flowLayoutPanel_초당_프레임.PerformLayout();
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.ResumeLayout(false);
            this.OriginVidInfo_컨flowLayoutPanel_화면_해상도.PerformLayout();
            this.Bitrate_컨_groupBox_영상_비트레이트.ResumeLayout(false);
            this.Bitrate_컨_tableLayoutPanel.ResumeLayout(false);
            this.Bitrate_컨_tableLayoutPanel.PerformLayout();
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.ResumeLayout(false);
            this.Bitrate_컨flowLayoutPanel_예상_출력물_크기.PerformLayout();
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.ResumeLayout(false);
            this.Bitrate_컨flowLayoutPanel_최대_영상_비트레이트.PerformLayout();
            this.OutSizeBasedBitrate_컨_groupBox.ResumeLayout(false);
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.ResumeLayout(false);
            this.OutSizeBasedBitrate_컨_tableLayoutPanel.PerformLayout();
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.ResumeLayout(false);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기.PerformLayout();
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.ResumeLayout(false);
            this.OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트.PerformLayout();
            this.ConvertResolution_컨_tableLayoutPanel1.ResumeLayout(false);
            this.ConvertResolution_컨_tableLayoutPanel1.PerformLayout();
            this.ConvertResolution_컨_groupBox.ResumeLayout(false);
            this.ConvertResolution_컨_tableLayoutPanel2.ResumeLayout(false);
            this.ConvertResolution_컨_tableLayoutPanel2.PerformLayout();
            this.ConvertResolution_컨flowLayoutPanel_기준.ResumeLayout(false);
            this.ConvertResolution_컨flowLayoutPanel_기준.PerformLayout();
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.ResumeLayout(false);
            this.ConvertResolution_컨flowLayoutPanel_변환예상해상도.PerformLayout();
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.ResumeLayout(false);
            this.ConvertResolution_컨flowLayoutPanel_현재해상도.PerformLayout();
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.ResumeLayout(false);
            this.ConvertResolution_컨flowLayoutPanel_변환예상파일크기.PerformLayout();
            this.Main_컨flowLayoutPanel_버튼.ResumeLayout(false);
            this.Main_statusStrip.ResumeLayout(false);
            this.Main_statusStrip.PerformLayout();
            this.Main_menuStrip.ResumeLayout(false);
            this.Main_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Main_컨tableLayoutPanel;
        private System.Windows.Forms.GroupBox OriginVidInfo_컨_groupBox;
        private System.Windows.Forms.FlowLayoutPanel OriginVidInfo_컨flowLayoutPanel_화면_해상도;
        private System.Windows.Forms.Label OriginVidInfo_label_화면_해상도;
        private System.Windows.Forms.Label OriginVidInfo_label_곱하기;
        private System.Windows.Forms.Label OriginVidInfo_label_영상_길이;
        private System.Windows.Forms.Label OriginVidInfo_label_초당_프레임;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_FPS;
        private System.Windows.Forms.Label OriginVidInfo_label_오디오_비트레이트;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_오디오_비트레이트;
        private System.Windows.Forms.Label OriginVidInfo_label_코덱_값;
        private System.Windows.Forms.GroupBox Bitrate_컨_groupBox_영상_비트레이트;
        private System.Windows.Forms.TableLayoutPanel Bitrate_컨_tableLayoutPanel;
        private System.Windows.Forms.Label Bitrate_label_최대_영상_비트레이트;
        private System.Windows.Forms.Label Bitrate_label_ShowValue_최대_영상_비트레이트;
        private System.Windows.Forms.Label Bitrate_label_예상_출력_영상_크기;
        private System.Windows.Forms.Label Bitrate_label_ShowValue_예상_출력_영상_크기;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_화면_해상도_가로;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_화면_해상도_세로;
        private System.Windows.Forms.FlowLayoutPanel OriginVidInfo_컨flowLayoutPanel_오디오_비트레이트;
        private System.Windows.Forms.Label OriginVidInfo_label_Kbps;
        private System.Windows.Forms.FlowLayoutPanel OriginVidInfo_컨flowLayoutPanel_초당_프레임;
        private System.Windows.Forms.Label OriginVidInfo_label_FPS;
        private System.Windows.Forms.Button OriginVidInfo_button_초기화;
        private System.Windows.Forms.FlowLayoutPanel Bitrate_컨flowLayoutPanel_최대_영상_비트레이트;
        private System.Windows.Forms.FlowLayoutPanel Bitrate_컨flowLayoutPanel_예상_출력물_크기;
        private System.Windows.Forms.TableLayoutPanel OriginVidInfo_컨_tableLayoutPanel1;
        private System.Windows.Forms.Button Main_button_제작자;
        private System.Windows.Forms.ToolTip Main_toolTip;
        private System.Windows.Forms.FlowLayoutPanel Main_컨flowLayoutPanel_버튼;
        private System.Windows.Forms.Button Main_button_모두_초기화;
        private System.Windows.Forms.Button Main_button_종료;
        private System.Windows.Forms.GroupBox OutSizeBasedBitrate_컨_groupBox;
        private System.Windows.Forms.TableLayoutPanel OutSizeBasedBitrate_컨_tableLayoutPanel;
        private System.Windows.Forms.Label OutSizeBasedBitrate_label_원하는_출력_영상_크기;
        private System.Windows.Forms.FlowLayoutPanel OutSizeBasedBitrate_컨flowLayoutPanel_원하는_출력물_크기;
        private System.Windows.Forms.TextBox OutSizeBasedBitrate_textBox_원하는_출력_영상_크기;
        private System.Windows.Forms.ComboBox OutSizeBasedBitrate_comboBox_원하는_출력물_크기_단위;
        private System.Windows.Forms.Label OutSizeBasedBitrate_label_예상_영상_비트레이트;
        private System.Windows.Forms.FlowLayoutPanel OutSizeBasedBitrate_컨flowLayoutPanel_최적_영상_비트레이트;
        private System.Windows.Forms.Label OutSizeBasedBitrate_label_ShowValue_영상_비트레이트;
        private System.Windows.Forms.GroupBox ConvertResolution_컨_groupBox;
        private System.Windows.Forms.TableLayoutPanel ConvertResolution_컨_tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel ConvertResolution_컨flowLayoutPanel_기준;
        private System.Windows.Forms.ComboBox ConvertResolution_comboBox_기준;
        private System.Windows.Forms.TextBox ConvertResolution_textBox_기준픽셀;
        private System.Windows.Forms.Label ConvertResolution_label_변환예상해상도;
        private System.Windows.Forms.FlowLayoutPanel ConvertResolution_컨flowLayoutPanel_변환예상해상도;
        private System.Windows.Forms.Label ConvertResolution_label_ShowValue_변환예상해상도_가로;
        private System.Windows.Forms.Label ConvertResolution_label_x_2;
        private System.Windows.Forms.Label ConvertResolution_label_ShowValue_변환예상해상도_세로;
        private System.Windows.Forms.Label ConvertResolution_label_변환예상영상크기;
        private System.Windows.Forms.FlowLayoutPanel ConvertResolution_컨flowLayoutPanel_변환예상파일크기;
        private System.Windows.Forms.Label ConvertResolution_label_ShowValue_변환예상크기;
        private System.Windows.Forms.Button ConvertResolution_button_적용;
        private System.Windows.Forms.FlowLayoutPanel ConvertResolution_컨flowLayoutPanel_현재해상도;
        private System.Windows.Forms.Label ConvertResolution_label_현재해상도;
        private System.Windows.Forms.Label ConvertResolution_label_ShowValue_현재해상도_가로;
        private System.Windows.Forms.Label ConvertResolution_label_x_1;
        private System.Windows.Forms.Label ConvertResolution_label_ShowValue_현재해상도_세로;
        private System.Windows.Forms.Label ConvertResolution_label_변환기준;
        private System.Windows.Forms.FlowLayoutPanel OriginVidInfo_컨flowLayoutPanel_적용_코덱;
        private System.Windows.Forms.ComboBox OriginVidInfo_comboBox_적용_코덱;
        private System.Windows.Forms.TableLayoutPanel ConvertResolution_컨_tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip Main_statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Main_toolStripStatusLabel;
        private System.Windows.Forms.Timer Main_timer;
        private System.Windows.Forms.ComboBox Bitrate_comboBox_예상_출력_영상_크기_단위;
        private System.Windows.Forms.ComboBox ConvertResolution_comboBox_변환예상크기단위;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_파일;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_해상도변환적용;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_원본영상파일정보초기화;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_모두초기화;
        private System.Windows.Forms.ToolStripSeparator Main_toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_최대영상비트레이트복사;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_예상영상비트레이트복사;
        private System.Windows.Forms.ToolStripSeparator Main_toolStripSeparator22;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_종료;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_도움말;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_제작자;
        private System.Windows.Forms.ToolStripSeparator Main_toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_프로그램정보;
        private System.Windows.Forms.MenuStrip Main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_편집;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_전체선택;
        private System.Windows.Forms.ToolStripSeparator Main_toolStripSeparator33;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_잘라내기;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_복사;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_붙여넣기;
        private System.Windows.Forms.Label ConvertResolution_label_colon;
        private System.Windows.Forms.ComboBox Bitrate_comboBox_Bitrate_단위;
        private System.Windows.Forms.ComboBox OutSizeBasedBitrate_comboBox_Bitrate_단위;
        private System.Windows.Forms.ToolStripMenuItem Main_ToolStripMenuItem_표시소수점정밀도설정;
        private System.Windows.Forms.FlowLayoutPanel OriginVidInfo_컨flowLayoutPanel_영상_길이;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_시간;
        private System.Windows.Forms.Label OriginVidInfo_label_시간;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_분;
        private System.Windows.Forms.Label OriginVidInfo_label_분;
        private System.Windows.Forms.TextBox OriginVidInfo_textBox_초;
        private System.Windows.Forms.Label OriginVidInfo_label_초;
    }
}

