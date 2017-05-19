namespace 通信
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUnvisible = new System.Windows.Forms.Button();
            this.cbbcheckoutbit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbstopbits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbdatabits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMssage = new System.Windows.Forms.Label();
            this.cbbbaudrate = new System.Windows.Forms.ComboBox();
            this.label_serialport = new System.Windows.Forms.Label();
            this.cbbCOMPorts = new System.Windows.Forms.ComboBox();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Location = new System.Drawing.Point(447, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 145);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接受数据";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 99);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(810, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "寻卡";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUnvisible);
            this.groupBox3.Controls.Add(this.cbbcheckoutbit);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbbstopbits);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cbbdatabits);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labelMssage);
            this.groupBox3.Controls.Add(this.cbbbaudrate);
            this.groupBox3.Controls.Add(this.label_serialport);
            this.groupBox3.Controls.Add(this.cbbCOMPorts);
            this.groupBox3.Controls.Add(this.label_baudrate);
            this.groupBox3.Location = new System.Drawing.Point(135, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 227);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "初始化";
            // 
            // btnUnvisible
            // 
            this.btnUnvisible.Location = new System.Drawing.Point(18, 185);
            this.btnUnvisible.Name = "btnUnvisible";
            this.btnUnvisible.Size = new System.Drawing.Size(71, 23);
            this.btnUnvisible.TabIndex = 20;
            this.btnUnvisible.Text = "status";
            this.btnUnvisible.UseVisualStyleBackColor = true;
            this.btnUnvisible.Visible = false;
            // 
            // cbbcheckoutbit
            // 
            this.cbbcheckoutbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbcheckoutbit.FormattingEnabled = true;
            this.cbbcheckoutbit.Location = new System.Drawing.Point(47, 120);
            this.cbbcheckoutbit.Name = "cbbcheckoutbit";
            this.cbbcheckoutbit.Size = new System.Drawing.Size(62, 20);
            this.cbbcheckoutbit.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "校验位";
            // 
            // cbbstopbits
            // 
            this.cbbstopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbstopbits.FormattingEnabled = true;
            this.cbbstopbits.Location = new System.Drawing.Point(47, 94);
            this.cbbstopbits.Name = "cbbstopbits";
            this.cbbstopbits.Size = new System.Drawing.Size(62, 20);
            this.cbbstopbits.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "停止位";
            // 
            // cbbdatabits
            // 
            this.cbbdatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdatabits.FormattingEnabled = true;
            this.cbbdatabits.Location = new System.Drawing.Point(47, 69);
            this.cbbdatabits.Name = "cbbdatabits";
            this.cbbdatabits.Size = new System.Drawing.Size(62, 20);
            this.cbbdatabits.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "数据位";
            // 
            // labelMssage
            // 
            this.labelMssage.AutoSize = true;
            this.labelMssage.Location = new System.Drawing.Point(26, 190);
            this.labelMssage.Name = "labelMssage";
            this.labelMssage.Size = new System.Drawing.Size(0, 12);
            this.labelMssage.TabIndex = 6;
            // 
            // cbbbaudrate
            // 
            this.cbbbaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbbaudrate.FormattingEnabled = true;
            this.cbbbaudrate.Location = new System.Drawing.Point(47, 44);
            this.cbbbaudrate.Name = "cbbbaudrate";
            this.cbbbaudrate.Size = new System.Drawing.Size(62, 20);
            this.cbbbaudrate.TabIndex = 1;
            // 
            // label_serialport
            // 
            this.label_serialport.AutoSize = true;
            this.label_serialport.Location = new System.Drawing.Point(6, 26);
            this.label_serialport.Name = "label_serialport";
            this.label_serialport.Size = new System.Drawing.Size(41, 12);
            this.label_serialport.TabIndex = 0;
            this.label_serialport.Text = "串口号";
            // 
            // cbbCOMPorts
            // 
            this.cbbCOMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCOMPorts.FormattingEnabled = true;
            this.cbbCOMPorts.Location = new System.Drawing.Point(47, 18);
            this.cbbCOMPorts.Name = "cbbCOMPorts";
            this.cbbCOMPorts.Size = new System.Drawing.Size(62, 20);
            this.cbbCOMPorts.Sorted = true;
            this.cbbCOMPorts.TabIndex = 1;
            // 
            // label_baudrate
            // 
            this.label_baudrate.AutoSize = true;
            this.label_baudrate.Location = new System.Drawing.Point(6, 47);
            this.label_baudrate.Name = "label_baudrate";
            this.label_baudrate.Size = new System.Drawing.Size(41, 12);
            this.label_baudrate.TabIndex = 1;
            this.label_baudrate.Text = "波特率";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 354);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbcheckoutbit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbstopbits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbdatabits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMssage;
        private System.Windows.Forms.ComboBox cbbbaudrate;
        private System.Windows.Forms.Label label_serialport;
        private System.Windows.Forms.ComboBox cbbCOMPorts;
        private System.Windows.Forms.Label label_baudrate;
        private System.Windows.Forms.Button btnUnvisible;
    }
}

