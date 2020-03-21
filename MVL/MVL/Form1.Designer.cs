namespace MVL
{
    partial class Form1
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
            this.send_btn = new System.Windows.Forms.Button();
            this.setting_gbx = new System.Windows.Forms.GroupBox();
            this.bits_cb = new System.Windows.Forms.ComboBox();
            this.bits_lb = new System.Windows.Forms.Label();
            this.cycle_lb = new System.Windows.Forms.Label();
            this.cycle_track = new System.Windows.Forms.TrackBar();
            this.pinnum_tb = new System.Windows.Forms.TextBox();
            this.pinnum_lb = new System.Windows.Forms.Label();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.port_lb = new System.Windows.Forms.Label();
            this.connect_lb = new System.Windows.Forms.Label();
            this.uart_setting_gbx = new System.Windows.Forms.GroupBox();
            this.stopbits_cb = new System.Windows.Forms.ComboBox();
            this.stopbits_lb = new System.Windows.Forms.Label();
            this.parity_cb = new System.Windows.Forms.ComboBox();
            this.Parity_lb = new System.Windows.Forms.Label();
            this.databits_cb = new System.Windows.Forms.ComboBox();
            this.databits_lb = new System.Windows.Forms.Label();
            this.baudlate_cb = new System.Windows.Forms.ComboBox();
            this.baudlate_lb = new System.Windows.Forms.Label();
            this.port_cbx = new System.Windows.Forms.ComboBox();
            this.com_lb = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.connect_bt = new System.Windows.Forms.Button();
            this.setting_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycle_track)).BeginInit();
            this.uart_setting_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(378, 163);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(88, 74);
            this.send_btn.TabIndex = 0;
            this.send_btn.Text = "send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // setting_gbx
            // 
            this.setting_gbx.Controls.Add(this.bits_cb);
            this.setting_gbx.Controls.Add(this.bits_lb);
            this.setting_gbx.Controls.Add(this.cycle_lb);
            this.setting_gbx.Controls.Add(this.cycle_track);
            this.setting_gbx.Controls.Add(this.pinnum_tb);
            this.setting_gbx.Controls.Add(this.pinnum_lb);
            this.setting_gbx.Controls.Add(this.port_tb);
            this.setting_gbx.Controls.Add(this.port_lb);
            this.setting_gbx.Location = new System.Drawing.Point(12, 105);
            this.setting_gbx.Name = "setting_gbx";
            this.setting_gbx.Size = new System.Drawing.Size(360, 132);
            this.setting_gbx.TabIndex = 4;
            this.setting_gbx.TabStop = false;
            this.setting_gbx.Text = "Settings";
            // 
            // bits_cb
            // 
            this.bits_cb.FormattingEnabled = true;
            this.bits_cb.Items.AddRange(new object[] {
            "16bit",
            "32bit",
            "64bit",
            "128bit",
            "256bit",
            "512bit",
            "1024bit"});
            this.bits_cb.Location = new System.Drawing.Point(252, 28);
            this.bits_cb.Name = "bits_cb";
            this.bits_cb.Size = new System.Drawing.Size(89, 20);
            this.bits_cb.TabIndex = 16;
            // 
            // bits_lb
            // 
            this.bits_lb.AutoSize = true;
            this.bits_lb.Location = new System.Drawing.Point(218, 32);
            this.bits_lb.Name = "bits_lb";
            this.bits_lb.Size = new System.Drawing.Size(37, 12);
            this.bits_lb.TabIndex = 16;
            this.bits_lb.Text = "bits : ";
            this.bits_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cycle_lb
            // 
            this.cycle_lb.AutoSize = true;
            this.cycle_lb.Location = new System.Drawing.Point(120, 105);
            this.cycle_lb.Name = "cycle_lb";
            this.cycle_lb.Size = new System.Drawing.Size(48, 12);
            this.cycle_lb.TabIndex = 8;
            this.cycle_lb.Text = "cycle : ";
            // 
            // cycle_track
            // 
            this.cycle_track.Location = new System.Drawing.Point(55, 63);
            this.cycle_track.Maximum = 5;
            this.cycle_track.Name = "cycle_track";
            this.cycle_track.Size = new System.Drawing.Size(248, 45);
            this.cycle_track.TabIndex = 6;
            this.cycle_track.Scroll += new System.EventHandler(this.cycle_track_Scroll);
            // 
            // pinnum_tb
            // 
            this.pinnum_tb.Location = new System.Drawing.Point(166, 27);
            this.pinnum_tb.Name = "pinnum_tb";
            this.pinnum_tb.Size = new System.Drawing.Size(46, 21);
            this.pinnum_tb.TabIndex = 7;
            // 
            // pinnum_lb
            // 
            this.pinnum_lb.AutoSize = true;
            this.pinnum_lb.Location = new System.Drawing.Point(107, 32);
            this.pinnum_lb.Name = "pinnum_lb";
            this.pinnum_lb.Size = new System.Drawing.Size(53, 12);
            this.pinnum_lb.TabIndex = 6;
            this.pinnum_lb.Text = "PINNUM";
            // 
            // port_tb
            // 
            this.port_tb.Location = new System.Drawing.Point(50, 27);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(46, 21);
            this.port_tb.TabIndex = 5;
            // 
            // port_lb
            // 
            this.port_lb.AutoSize = true;
            this.port_lb.Location = new System.Drawing.Point(6, 32);
            this.port_lb.Name = "port_lb";
            this.port_lb.Size = new System.Drawing.Size(38, 12);
            this.port_lb.TabIndex = 4;
            this.port_lb.Text = "PORT";
            // 
            // connect_lb
            // 
            this.connect_lb.AutoSize = true;
            this.connect_lb.Location = new System.Drawing.Point(382, 143);
            this.connect_lb.Name = "connect_lb";
            this.connect_lb.Size = new System.Drawing.Size(79, 12);
            this.connect_lb.TabIndex = 5;
            this.connect_lb.Text = "connecting...";
            this.connect_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uart_setting_gbx
            // 
            this.uart_setting_gbx.Controls.Add(this.stopbits_cb);
            this.uart_setting_gbx.Controls.Add(this.stopbits_lb);
            this.uart_setting_gbx.Controls.Add(this.parity_cb);
            this.uart_setting_gbx.Controls.Add(this.Parity_lb);
            this.uart_setting_gbx.Controls.Add(this.databits_cb);
            this.uart_setting_gbx.Controls.Add(this.databits_lb);
            this.uart_setting_gbx.Controls.Add(this.baudlate_cb);
            this.uart_setting_gbx.Controls.Add(this.baudlate_lb);
            this.uart_setting_gbx.Location = new System.Drawing.Point(12, 12);
            this.uart_setting_gbx.Name = "uart_setting_gbx";
            this.uart_setting_gbx.Size = new System.Drawing.Size(360, 83);
            this.uart_setting_gbx.TabIndex = 6;
            this.uart_setting_gbx.TabStop = false;
            this.uart_setting_gbx.Text = "uart_setting";
            // 
            // stopbits_cb
            // 
            this.stopbits_cb.FormattingEnabled = true;
            this.stopbits_cb.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbits_cb.Location = new System.Drawing.Point(258, 51);
            this.stopbits_cb.Name = "stopbits_cb";
            this.stopbits_cb.Size = new System.Drawing.Size(51, 20);
            this.stopbits_cb.TabIndex = 15;
            this.stopbits_cb.SelectedIndexChanged += new System.EventHandler(this.stopbits_cb_SelectedIndexChanged);
            // 
            // stopbits_lb
            // 
            this.stopbits_lb.AutoSize = true;
            this.stopbits_lb.Location = new System.Drawing.Point(191, 55);
            this.stopbits_lb.Name = "stopbits_lb";
            this.stopbits_lb.Size = new System.Drawing.Size(66, 12);
            this.stopbits_lb.TabIndex = 14;
            this.stopbits_lb.Text = "Stop bits : ";
            this.stopbits_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parity_cb
            // 
            this.parity_cb.FormattingEnabled = true;
            this.parity_cb.Items.AddRange(new object[] {
            "none",
            "odd",
            "even",
            "mark",
            "space"});
            this.parity_cb.Location = new System.Drawing.Point(258, 20);
            this.parity_cb.Name = "parity_cb";
            this.parity_cb.Size = new System.Drawing.Size(83, 20);
            this.parity_cb.TabIndex = 12;
            this.parity_cb.SelectedIndexChanged += new System.EventHandler(this.parity_cb_SelectedIndexChanged);
            // 
            // Parity_lb
            // 
            this.Parity_lb.AutoSize = true;
            this.Parity_lb.Location = new System.Drawing.Point(208, 23);
            this.Parity_lb.Name = "Parity_lb";
            this.Parity_lb.Size = new System.Drawing.Size(49, 12);
            this.Parity_lb.TabIndex = 13;
            this.Parity_lb.Text = "Parity : ";
            this.Parity_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // databits_cb
            // 
            this.databits_cb.FormattingEnabled = true;
            this.databits_cb.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databits_cb.Location = new System.Drawing.Point(87, 51);
            this.databits_cb.Name = "databits_cb";
            this.databits_cb.Size = new System.Drawing.Size(51, 20);
            this.databits_cb.TabIndex = 11;
            this.databits_cb.SelectedIndexChanged += new System.EventHandler(this.databits_cb_SelectedIndexChanged);
            // 
            // databits_lb
            // 
            this.databits_lb.AutoSize = true;
            this.databits_lb.Location = new System.Drawing.Point(20, 55);
            this.databits_lb.Name = "databits_lb";
            this.databits_lb.Size = new System.Drawing.Size(66, 12);
            this.databits_lb.TabIndex = 10;
            this.databits_lb.Text = "Data bits : ";
            this.databits_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baudlate_cb
            // 
            this.baudlate_cb.FormattingEnabled = true;
            this.baudlate_cb.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudlate_cb.Location = new System.Drawing.Point(87, 20);
            this.baudlate_cb.Name = "baudlate_cb";
            this.baudlate_cb.Size = new System.Drawing.Size(83, 20);
            this.baudlate_cb.TabIndex = 9;
            this.baudlate_cb.SelectedIndexChanged += new System.EventHandler(this.baudlate_cb_SelectedIndexChanged);
            // 
            // baudlate_lb
            // 
            this.baudlate_lb.AutoSize = true;
            this.baudlate_lb.Location = new System.Drawing.Point(20, 24);
            this.baudlate_lb.Name = "baudlate_lb";
            this.baudlate_lb.Size = new System.Drawing.Size(66, 12);
            this.baudlate_lb.TabIndex = 9;
            this.baudlate_lb.Text = "Baudlate : ";
            this.baudlate_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // port_cbx
            // 
            this.port_cbx.FormattingEnabled = true;
            this.port_cbx.Location = new System.Drawing.Point(378, 37);
            this.port_cbx.Name = "port_cbx";
            this.port_cbx.Size = new System.Drawing.Size(83, 20);
            this.port_cbx.TabIndex = 7;
            this.port_cbx.SelectedIndexChanged += new System.EventHandler(this.port_cbx_SelectedIndexChanged);
            // 
            // com_lb
            // 
            this.com_lb.AutoSize = true;
            this.com_lb.Location = new System.Drawing.Point(378, 22);
            this.com_lb.Name = "com_lb";
            this.com_lb.Size = new System.Drawing.Size(46, 12);
            this.com_lb.TabIndex = 8;
            this.com_lb.Text = "COM : ";
            this.com_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // connect_bt
            // 
            this.connect_bt.Location = new System.Drawing.Point(378, 63);
            this.connect_bt.Name = "connect_bt";
            this.connect_bt.Size = new System.Drawing.Size(83, 23);
            this.connect_bt.TabIndex = 9;
            this.connect_bt.Text = "connect";
            this.connect_bt.UseVisualStyleBackColor = true;
            this.connect_bt.Click += new System.EventHandler(this.connect_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 249);
            this.Controls.Add(this.connect_bt);
            this.Controls.Add(this.com_lb);
            this.Controls.Add(this.port_cbx);
            this.Controls.Add(this.uart_setting_gbx);
            this.Controls.Add(this.connect_lb);
            this.Controls.Add(this.setting_gbx);
            this.Controls.Add(this.send_btn);
            this.Name = "Form1";
            this.Text = "MVL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.setting_gbx.ResumeLayout(false);
            this.setting_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycle_track)).EndInit();
            this.uart_setting_gbx.ResumeLayout(false);
            this.uart_setting_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.GroupBox setting_gbx;
        private System.Windows.Forms.TrackBar cycle_track;
        private System.Windows.Forms.TextBox pinnum_tb;
        private System.Windows.Forms.Label pinnum_lb;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.Label port_lb;
        private System.Windows.Forms.Label connect_lb;
        private System.Windows.Forms.Label cycle_lb;
        private System.Windows.Forms.GroupBox uart_setting_gbx;
        private System.Windows.Forms.ComboBox stopbits_cb;
        private System.Windows.Forms.Label stopbits_lb;
        private System.Windows.Forms.ComboBox parity_cb;
        private System.Windows.Forms.Label Parity_lb;
        private System.Windows.Forms.ComboBox databits_cb;
        private System.Windows.Forms.Label databits_lb;
        private System.Windows.Forms.ComboBox baudlate_cb;
        private System.Windows.Forms.Label baudlate_lb;
        private System.Windows.Forms.ComboBox port_cbx;
        private System.Windows.Forms.Label com_lb;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button connect_bt;
        private System.Windows.Forms.ComboBox bits_cb;
        private System.Windows.Forms.Label bits_lb;
    }
}

