namespace SmartPITdebuger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label5;
            this.comboBoxSerialports = new System.Windows.Forms.ComboBox();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxRescv = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxChooseCommand = new System.Windows.Forms.ComboBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRMS = new System.Windows.Forms.ComboBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPageConnect = new System.Windows.Forms.TabPage();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.tabPageFW = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxBoard = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            label5 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPageConnect.SuspendLayout();
            this.tabPageDebug.SuspendLayout();
            this.tabPageFW.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label5.Location = new System.Drawing.Point(20, 62);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(290, 2);
            label5.TabIndex = 20;
            label5.Text = "label5";
            // 
            // comboBoxSerialports
            // 
            this.comboBoxSerialports.FormattingEnabled = true;
            this.comboBoxSerialports.Location = new System.Drawing.Point(63, 24);
            this.comboBoxSerialports.Name = "comboBoxSerialports";
            this.comboBoxSerialports.Size = new System.Drawing.Size(155, 21);
            this.comboBoxSerialports.TabIndex = 0;
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Location = new System.Drawing.Point(63, 51);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(155, 21);
            this.comboBoxSpeed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(234, 51);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(234, 24);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxRescv
            // 
            this.textBoxRescv.Location = new System.Drawing.Point(23, 67);
            this.textBoxRescv.Multiline = true;
            this.textBoxRescv.Name = "textBoxRescv";
            this.textBoxRescv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRescv.Size = new System.Drawing.Size(284, 168);
            this.textBoxRescv.TabIndex = 6;
            this.textBoxRescv.TextChanged += new System.EventHandler(this.textBoxRescv_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(340, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(232, 240);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(244, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoCheck = false;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(224, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoCheck = false;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(204, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoCheck = false;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(184, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoCheck = false;
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(164, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoCheck = false;
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(144, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 14;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoCheck = false;
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(124, 3);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(14, 13);
            this.radioButton7.TabIndex = 15;
            this.radioButton7.TabStop = true;
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.radioButton7_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoCheck = false;
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(105, 3);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(14, 13);
            this.radioButton8.TabIndex = 16;
            this.radioButton8.TabStop = true;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Click += new System.EventHandler(this.radioButton8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Command bits";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Location = new System.Drawing.Point(46, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 26);
            this.panel1.TabIndex = 18;
            // 
            // comboBoxChooseCommand
            // 
            this.comboBoxChooseCommand.FormattingEnabled = true;
            this.comboBoxChooseCommand.Location = new System.Drawing.Point(46, 6);
            this.comboBoxChooseCommand.Name = "comboBoxChooseCommand";
            this.comboBoxChooseCommand.Size = new System.Drawing.Size(170, 21);
            this.comboBoxChooseCommand.TabIndex = 21;
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Location = new System.Drawing.Point(232, 4);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(75, 23);
            this.buttonSendCommand.TabIndex = 22;
            this.buttonSendCommand.Text = "Send";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Reset device";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(173, 84);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(68, 22);
            this.buttonUpload.TabIndex = 24;
            this.buttonUpload.Text = "Upload FW";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "RMS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxRMS
            // 
            this.comboBoxRMS.FormattingEnabled = true;
            this.comboBoxRMS.Location = new System.Drawing.Point(115, 33);
            this.comboBoxRMS.Name = "comboBoxRMS";
            this.comboBoxRMS.Size = new System.Drawing.Size(128, 21);
            this.comboBoxRMS.TabIndex = 25;
            this.comboBoxRMS.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageConnect);
            this.TabControl.Controls.Add(this.tabPageDebug);
            this.TabControl.Controls.Add(this.tabPageFW);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(340, 304);
            this.TabControl.TabIndex = 27;
            // 
            // tabPageConnect
            // 
            this.tabPageConnect.Controls.Add(this.buttonRefresh);
            this.tabPageConnect.Controls.Add(this.comboBoxSerialports);
            this.tabPageConnect.Controls.Add(this.comboBoxSpeed);
            this.tabPageConnect.Controls.Add(this.label1);
            this.tabPageConnect.Controls.Add(this.label2);
            this.tabPageConnect.Controls.Add(this.buttonConnect);
            this.tabPageConnect.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnect.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageConnect.Name = "tabPageConnect";
            this.tabPageConnect.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageConnect.Size = new System.Drawing.Size(332, 278);
            this.tabPageConnect.TabIndex = 0;
            this.tabPageConnect.Text = "Connect";
            this.tabPageConnect.UseVisualStyleBackColor = true;
            this.tabPageConnect.Click += new System.EventHandler(this.tabPageConnect_Click);
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.Controls.Add(this.comboBoxChooseCommand);
            this.tabPageDebug.Controls.Add(this.textBoxRescv);
            this.tabPageDebug.Controls.Add(this.buttonClear);
            this.tabPageDebug.Controls.Add(this.panel1);
            this.tabPageDebug.Controls.Add(this.button3);
            this.tabPageDebug.Controls.Add(label5);
            this.tabPageDebug.Controls.Add(this.buttonSendCommand);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebug.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDebug.Size = new System.Drawing.Size(332, 278);
            this.tabPageDebug.TabIndex = 1;
            this.tabPageDebug.Text = "Debug & Control";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // tabPageFW
            // 
            this.tabPageFW.Controls.Add(this.label7);
            this.tabPageFW.Controls.Add(this.comboBoxBoard);
            this.tabPageFW.Controls.Add(this.comboBoxRMS);
            this.tabPageFW.Controls.Add(this.label6);
            this.tabPageFW.Controls.Add(this.buttonUpload);
            this.tabPageFW.Location = new System.Drawing.Point(4, 22);
            this.tabPageFW.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageFW.Name = "tabPageFW";
            this.tabPageFW.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageFW.Size = new System.Drawing.Size(332, 278);
            this.tabPageFW.TabIndex = 2;
            this.tabPageFW.Text = "FW upgrade";
            this.tabPageFW.UseVisualStyleBackColor = true;
            this.tabPageFW.Click += new System.EventHandler(this.tabPageFW_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Board";
            // 
            // comboBoxBoard
            // 
            this.comboBoxBoard.FormattingEnabled = true;
            this.comboBoxBoard.Location = new System.Drawing.Point(115, 59);
            this.comboBoxBoard.Name = "comboBoxBoard";
            this.comboBoxBoard.Size = new System.Drawing.Size(128, 21);
            this.comboBoxBoard.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 324);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "SmartSensor Utilillity 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPageConnect.ResumeLayout(false);
            this.tabPageConnect.PerformLayout();
            this.tabPageDebug.ResumeLayout(false);
            this.tabPageDebug.PerformLayout();
            this.tabPageFW.ResumeLayout(false);
            this.tabPageFW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSerialports;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxRescv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxChooseCommand;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRMS;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPageConnect;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.TabPage tabPageFW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxBoard;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

