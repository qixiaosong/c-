namespace RS232
{
    partial class fclsRS232Tester
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
            this.txtIn = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.cmbComSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIn.Location = new System.Drawing.Point(13, 71);
            this.txtIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIn.Size = new System.Drawing.Size(0, 459);
            this.txtIn.TabIndex = 0;
            this.txtIn.Visible = false;
            this.txtIn.TextChanged += new System.EventHandler(this.txtIn_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 760);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1047, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsStatus
            // 
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(137, 20);
            this.stsStatus.Text = "Select serial port!";
            this.stsStatus.Visible = false;
            // 
            // port
            // 
            this.port.PortName = "X";
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived_1);
            // 
            // cmbComSelect
            // 
            this.cmbComSelect.FormattingEnabled = true;
            this.cmbComSelect.Location = new System.Drawing.Point(13, 25);
            this.cmbComSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmbComSelect.Name = "cmbComSelect";
            this.cmbComSelect.Size = new System.Drawing.Size(100, 23);
            this.cmbComSelect.Sorted = true;
            this.cmbComSelect.TabIndex = 9;
            this.cmbComSelect.SelectionChangeCommitted += new System.EventHandler(this.cmbComSelect_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select COM:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(-149, 538);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 22);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Receive data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox20);
            this.groupBox1.Controls.Add(this.textBox19);
            this.groupBox1.Controls.Add(this.textBox18);
            this.groupBox1.Controls.Add(this.textBox17);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox21);
            this.groupBox1.Controls.Add(this.textBox22);
            this.groupBox1.Controls.Add(this.textBox23);
            this.groupBox1.Controls.Add(this.textBox24);
            this.groupBox1.Controls.Add(this.textBox25);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox26);
            this.groupBox1.Controls.Add(this.textBox27);
            this.groupBox1.Controls.Add(this.textBox28);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox29);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox30);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(121, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(898, 785);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "history";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(44, 37);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 15);
            this.label32.TabIndex = 78;
            this.label32.Text = "第1路";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(192, 36);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(45, 15);
            this.label31.TabIndex = 77;
            this.label31.Text = "第2路";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(323, 37);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(45, 15);
            this.label30.TabIndex = 76;
            this.label30.Text = "第3路";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(468, 36);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(45, 15);
            this.label29.TabIndex = 75;
            this.label29.Text = "第4路";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(604, 37);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 15);
            this.label28.TabIndex = 74;
            this.label28.Text = "第5路";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(739, 37);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 15);
            this.label27.TabIndex = 73;
            this.label27.Text = "第6路";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(44, 182);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 15);
            this.label26.TabIndex = 72;
            this.label26.Text = "第7路";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(192, 182);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 15);
            this.label25.TabIndex = 71;
            this.label25.Text = "第8路";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(323, 182);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 15);
            this.label24.TabIndex = 70;
            this.label24.Text = "第9路";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(468, 182);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 15);
            this.label23.TabIndex = 69;
            this.label23.Text = "第10路";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(604, 182);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 15);
            this.label22.TabIndex = 68;
            this.label22.Text = "第11路";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(739, 182);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 15);
            this.label21.TabIndex = 67;
            this.label21.Text = "第12路";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(44, 318);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 15);
            this.label20.TabIndex = 66;
            this.label20.Text = "第13路";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(192, 318);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 15);
            this.label19.TabIndex = 65;
            this.label19.Text = "第14路";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(323, 318);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 15);
            this.label18.TabIndex = 64;
            this.label18.Text = "第15路";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(468, 318);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 15);
            this.label17.TabIndex = 63;
            this.label17.Text = "第16路";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(604, 318);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 15);
            this.label16.TabIndex = 62;
            this.label16.Text = "第17路";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(739, 318);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 61;
            this.label15.Text = "第18路";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 464);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 15);
            this.label14.TabIndex = 60;
            this.label14.Text = "第19路";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(184, 464);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 59;
            this.label13.Text = "第20路";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(148, 483);
            this.textBox20.Margin = new System.Windows.Forms.Padding(4);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox20.Size = new System.Drawing.Size(132, 108);
            this.textBox20.TabIndex = 58;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(8, 483);
            this.textBox19.Margin = new System.Windows.Forms.Padding(4);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox19.Size = new System.Drawing.Size(132, 108);
            this.textBox19.TabIndex = 57;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(708, 337);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox18.Size = new System.Drawing.Size(132, 108);
            this.textBox18.TabIndex = 56;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(570, 337);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox17.Size = new System.Drawing.Size(132, 108);
            this.textBox17.TabIndex = 55;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(428, 337);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox16.Size = new System.Drawing.Size(132, 108);
            this.textBox16.TabIndex = 54;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(288, 337);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox15.Size = new System.Drawing.Size(132, 108);
            this.textBox15.TabIndex = 53;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(148, 337);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox14.Size = new System.Drawing.Size(132, 108);
            this.textBox14.TabIndex = 52;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(708, 198);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox12.Size = new System.Drawing.Size(132, 108);
            this.textBox12.TabIndex = 50;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(8, 337);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox13.Size = new System.Drawing.Size(132, 108);
            this.textBox13.TabIndex = 51;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(568, 198);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox11.Size = new System.Drawing.Size(132, 108);
            this.textBox11.TabIndex = 49;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(428, 198);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox10.Size = new System.Drawing.Size(132, 108);
            this.textBox10.TabIndex = 48;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(288, 198);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox9.Size = new System.Drawing.Size(132, 108);
            this.textBox9.TabIndex = 47;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(148, 198);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox8.Size = new System.Drawing.Size(132, 108);
            this.textBox8.TabIndex = 46;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(8, 198);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox7.Size = new System.Drawing.Size(132, 108);
            this.textBox7.TabIndex = 45;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(710, 55);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox6.Size = new System.Drawing.Size(132, 108);
            this.textBox6.TabIndex = 44;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(570, 55);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(132, 108);
            this.textBox5.TabIndex = 43;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(430, 55);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(132, 108);
            this.textBox4.TabIndex = 42;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(288, 55);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(132, 108);
            this.textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 55);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(132, 108);
            this.textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(132, 108);
            this.textBox1.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 464);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "第21路";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(468, 464);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "第22路";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 464);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "第23路";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(739, 464);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "第24路";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 603);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "第25路";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(288, 483);
            this.textBox21.Margin = new System.Windows.Forms.Padding(4);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox21.Size = new System.Drawing.Size(132, 108);
            this.textBox21.TabIndex = 33;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(428, 483);
            this.textBox22.Margin = new System.Windows.Forms.Padding(4);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox22.Size = new System.Drawing.Size(132, 108);
            this.textBox22.TabIndex = 32;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(568, 483);
            this.textBox23.Margin = new System.Windows.Forms.Padding(4);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox23.Size = new System.Drawing.Size(132, 108);
            this.textBox23.TabIndex = 31;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(708, 483);
            this.textBox24.Margin = new System.Windows.Forms.Padding(4);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox24.Size = new System.Drawing.Size(132, 108);
            this.textBox24.TabIndex = 30;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(8, 622);
            this.textBox25.Margin = new System.Windows.Forms.Padding(4);
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox25.Size = new System.Drawing.Size(132, 108);
            this.textBox25.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 603);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "第26路";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 604);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "第27路";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 604);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "第28路";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(148, 622);
            this.textBox26.Margin = new System.Windows.Forms.Padding(4);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox26.Size = new System.Drawing.Size(132, 108);
            this.textBox26.TabIndex = 25;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(288, 623);
            this.textBox27.Margin = new System.Windows.Forms.Padding(4);
            this.textBox27.Multiline = true;
            this.textBox27.Name = "textBox27";
            this.textBox27.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox27.Size = new System.Drawing.Size(132, 108);
            this.textBox27.TabIndex = 24;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(428, 622);
            this.textBox28.Margin = new System.Windows.Forms.Padding(4);
            this.textBox28.Multiline = true;
            this.textBox28.Name = "textBox28";
            this.textBox28.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox28.Size = new System.Drawing.Size(132, 108);
            this.textBox28.TabIndex = 23;
            this.textBox28.TextChanged += new System.EventHandler(this.textBox28_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 604);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "第29路";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(568, 623);
            this.textBox29.Margin = new System.Windows.Forms.Padding(4);
            this.textBox29.Multiline = true;
            this.textBox29.Name = "textBox29";
            this.textBox29.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox29.Size = new System.Drawing.Size(132, 108);
            this.textBox29.TabIndex = 1;
            this.textBox29.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 739);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 739);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(708, 623);
            this.textBox30.Margin = new System.Windows.Forms.Padding(4);
            this.textBox30.Multiline = true;
            this.textBox30.Name = "textBox30";
            this.textBox30.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox30.Size = new System.Drawing.Size(132, 108);
            this.textBox30.TabIndex = 1;
            this.textBox30.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(739, 604);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "第30路";
            // 
            // fclsRS232Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1047, 782);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbComSelect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtIn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(261, 222);
            this.Name = "fclsRS232Tester";
            this.Text = "智能昆虫测速仪（河南科技学院）";
            this.Load += new System.EventHandler(this.fclsRS232Tester_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsStatus;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.ComboBox cmbComSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

