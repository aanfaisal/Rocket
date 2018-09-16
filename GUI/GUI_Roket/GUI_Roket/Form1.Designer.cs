namespace GUI_Roket
{
    partial class GCS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGPS = new System.Windows.Forms.TextBox();
            this.txtEDF = new System.Windows.Forms.TextBox();
            this.txtEMU = new System.Windows.Forms.TextBox();
            this.txtPacRecei = new System.Windows.Forms.TextBox();
            this.txtPacEror = new System.Windows.Forms.TextBox();
            this.txtPacSent = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtCompass = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNavstate = new System.Windows.Forms.TextBox();
            this.txtGPSmode = new System.Windows.Forms.TextBox();
            this.txtLongi = new System.Windows.Forms.TextBox();
            this.txtLatt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chcYawAcc = new System.Windows.Forms.CheckBox();
            this.chcPitchAcc = new System.Windows.Forms.CheckBox();
            this.checkRollAcc = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chcYawGyro = new System.Windows.Forms.CheckBox();
            this.chcPitchGyro = new System.Windows.Forms.CheckBox();
            this.chcRollGyro = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.chcYawMag = new System.Windows.Forms.CheckBox();
            this.chcPitchMag = new System.Windows.Forms.CheckBox();
            this.chcRollMag = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToolStripMenuItem,
            this.exitAltF4ToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.homeToolStripMenuItem.Text = "Main";
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveDataToolStripMenuItem.Text = "Save Data ( Ctrl + S )";
            // 
            // exitAltF4ToolStripMenuItem
            // 
            this.exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            this.exitAltF4ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitAltF4ToolStripMenuItem.Text = "Exit ( Alt+F4 )";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(7, 22);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(24, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(507, 369);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 20);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Data1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(573, 234);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI_Roket.Properties.Resources.IndicatorHeading;
            this.pictureBox4.Location = new System.Drawing.Point(7, 20);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(179, 178);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI_Roket.Properties.Resources.IndicatorAttitude;
            this.pictureBox3.Location = new System.Drawing.Point(369, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 178);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI_Roket.Properties.Resources.IndicatorAirSpeed;
            this.pictureBox2.Location = new System.Drawing.Point(189, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 178);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_Roket.Properties.Resources.Unwahas;
            this.pictureBox1.Location = new System.Drawing.Point(26, 486);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 194);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 720);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1589, 10);
            this.progressBar1.TabIndex = 14;
            // 
            // btnEmergency
            // 
            this.btnEmergency.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmergency.Location = new System.Drawing.Point(8, 104);
            this.btnEmergency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(220, 39);
            this.btnEmergency.TabIndex = 8;
            this.btnEmergency.Text = "EMERGENCY PARACHUTE";
            this.btnEmergency.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisconnect.Location = new System.Drawing.Point(130, 74);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(102, 25);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnect.Location = new System.Drawing.Point(6, 74);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 25);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownHeight = 120;
            this.comboBox2.DropDownWidth = 170;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(3, 47);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(229, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 120;
            this.comboBox1.DropDownWidth = 170;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13"});
            this.comboBox1.Location = new System.Drawing.Point(3, 20);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "EMU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "EDF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Code Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "GPS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Packet\'s Sent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Packet\'s Received";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Packet Error";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnEmergency);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 149);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect Arduino";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGPS);
            this.groupBox2.Controls.Add(this.txtEDF);
            this.groupBox2.Controls.Add(this.txtEMU);
            this.groupBox2.Controls.Add(this.txtPacRecei);
            this.groupBox2.Controls.Add(this.txtPacEror);
            this.groupBox2.Controls.Add(this.txtPacSent);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(8, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 247);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // txtGPS
            // 
            this.txtGPS.Location = new System.Drawing.Point(63, 75);
            this.txtGPS.Name = "txtGPS";
            this.txtGPS.Size = new System.Drawing.Size(147, 21);
            this.txtGPS.TabIndex = 17;
            // 
            // txtEDF
            // 
            this.txtEDF.Location = new System.Drawing.Point(63, 50);
            this.txtEDF.Name = "txtEDF";
            this.txtEDF.Size = new System.Drawing.Size(147, 21);
            this.txtEDF.TabIndex = 16;
            // 
            // txtEMU
            // 
            this.txtEMU.Location = new System.Drawing.Point(64, 24);
            this.txtEMU.Name = "txtEMU";
            this.txtEMU.Size = new System.Drawing.Size(147, 21);
            this.txtEMU.TabIndex = 15;
            // 
            // txtPacRecei
            // 
            this.txtPacRecei.Location = new System.Drawing.Point(148, 155);
            this.txtPacRecei.Name = "txtPacRecei";
            this.txtPacRecei.Size = new System.Drawing.Size(63, 21);
            this.txtPacRecei.TabIndex = 14;
            // 
            // txtPacEror
            // 
            this.txtPacEror.Location = new System.Drawing.Point(148, 176);
            this.txtPacEror.Name = "txtPacEror";
            this.txtPacEror.Size = new System.Drawing.Size(63, 21);
            this.txtPacEror.TabIndex = 13;
            // 
            // txtPacSent
            // 
            this.txtPacSent.Location = new System.Drawing.Point(148, 134);
            this.txtPacSent.Name = "txtPacSent";
            this.txtPacSent.Size = new System.Drawing.Size(63, 21);
            this.txtPacSent.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(249, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 402);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPS Maps";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(249, 446);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(662, 266);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Graph Sensor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtHeading);
            this.groupBox5.Controls.Add(this.txtSpeed);
            this.groupBox5.Controls.Add(this.txtCompass);
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Controls.Add(this.pictureBox3);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(783, 40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(559, 235);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sensor";
            // 
            // txtHeading
            // 
            this.txtHeading.Location = new System.Drawing.Point(438, 204);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(44, 21);
            this.txtHeading.TabIndex = 17;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(260, 204);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(44, 21);
            this.txtSpeed.TabIndex = 16;
            // 
            // txtCompass
            // 
            this.txtCompass.Location = new System.Drawing.Point(74, 204);
            this.txtCompass.Name = "txtCompass";
            this.txtCompass.Size = new System.Drawing.Size(44, 21);
            this.txtCompass.TabIndex = 15;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox6.Controls.Add(this.txtNavstate);
            this.groupBox6.Controls.Add(this.txtGPSmode);
            this.groupBox6.Controls.Add(this.txtLongi);
            this.groupBox6.Controls.Add(this.txtLatt);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(972, 281);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(370, 161);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Waypoint ";
            // 
            // txtNavstate
            // 
            this.txtNavstate.Location = new System.Drawing.Point(112, 100);
            this.txtNavstate.Name = "txtNavstate";
            this.txtNavstate.Size = new System.Drawing.Size(90, 21);
            this.txtNavstate.TabIndex = 7;
            // 
            // txtGPSmode
            // 
            this.txtGPSmode.Location = new System.Drawing.Point(112, 74);
            this.txtGPSmode.Name = "txtGPSmode";
            this.txtGPSmode.Size = new System.Drawing.Size(90, 21);
            this.txtGPSmode.TabIndex = 6;
            // 
            // txtLongi
            // 
            this.txtLongi.Location = new System.Drawing.Point(112, 47);
            this.txtLongi.Name = "txtLongi";
            this.txtLongi.Size = new System.Drawing.Size(90, 21);
            this.txtLongi.TabIndex = 5;
            // 
            // txtLatt
            // 
            this.txtLatt.Location = new System.Drawing.Point(112, 21);
            this.txtLatt.Name = "txtLatt";
            this.txtLatt.Size = new System.Drawing.Size(90, 21);
            this.txtLatt.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "NAV. State  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "GPS Mode    :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Longitude   :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lattitude   :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chcYawAcc);
            this.groupBox7.Controls.Add(this.chcPitchAcc);
            this.groupBox7.Controls.Add(this.checkRollAcc);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Location = new System.Drawing.Point(925, 449);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 129);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Accelerometer";
            // 
            // chcYawAcc
            // 
            this.chcYawAcc.AutoSize = true;
            this.chcYawAcc.Location = new System.Drawing.Point(6, 87);
            this.chcYawAcc.Name = "chcYawAcc";
            this.chcYawAcc.Size = new System.Drawing.Size(47, 17);
            this.chcYawAcc.TabIndex = 2;
            this.chcYawAcc.Text = "YAW";
            this.chcYawAcc.UseVisualStyleBackColor = true;
            // 
            // chcPitchAcc
            // 
            this.chcPitchAcc.AutoSize = true;
            this.chcPitchAcc.Location = new System.Drawing.Point(6, 53);
            this.chcPitchAcc.Name = "chcPitchAcc";
            this.chcPitchAcc.Size = new System.Drawing.Size(61, 17);
            this.chcPitchAcc.TabIndex = 1;
            this.chcPitchAcc.Text = "PITCH";
            this.chcPitchAcc.UseVisualStyleBackColor = true;
            // 
            // checkRollAcc
            // 
            this.checkRollAcc.AutoSize = true;
            this.checkRollAcc.Location = new System.Drawing.Point(6, 20);
            this.checkRollAcc.Name = "checkRollAcc";
            this.checkRollAcc.Size = new System.Drawing.Size(54, 17);
            this.checkRollAcc.TabIndex = 0;
            this.checkRollAcc.Text = "ROLL";
            this.checkRollAcc.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chcYawGyro);
            this.groupBox8.Controls.Add(this.chcPitchGyro);
            this.groupBox8.Controls.Add(this.chcRollGyro);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox8.Location = new System.Drawing.Point(925, 583);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 128);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Gyroscope";
            // 
            // chcYawGyro
            // 
            this.chcYawGyro.AutoSize = true;
            this.chcYawGyro.Location = new System.Drawing.Point(6, 89);
            this.chcYawGyro.Name = "chcYawGyro";
            this.chcYawGyro.Size = new System.Drawing.Size(47, 17);
            this.chcYawGyro.TabIndex = 3;
            this.chcYawGyro.Text = "YAW";
            this.chcYawGyro.UseVisualStyleBackColor = true;
            // 
            // chcPitchGyro
            // 
            this.chcPitchGyro.AutoSize = true;
            this.chcPitchGyro.Location = new System.Drawing.Point(6, 52);
            this.chcPitchGyro.Name = "chcPitchGyro";
            this.chcPitchGyro.Size = new System.Drawing.Size(61, 17);
            this.chcPitchGyro.TabIndex = 2;
            this.chcPitchGyro.Text = "PITCH";
            this.chcPitchGyro.UseVisualStyleBackColor = true;
            // 
            // chcRollGyro
            // 
            this.chcRollGyro.AutoSize = true;
            this.chcRollGyro.Location = new System.Drawing.Point(6, 20);
            this.chcRollGyro.Name = "chcRollGyro";
            this.chcRollGyro.Size = new System.Drawing.Size(54, 17);
            this.chcRollGyro.TabIndex = 1;
            this.chcRollGyro.Text = "ROLL";
            this.chcRollGyro.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.chcYawMag);
            this.groupBox9.Controls.Add(this.chcPitchMag);
            this.groupBox9.Controls.Add(this.chcRollMag);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox9.Location = new System.Drawing.Point(1142, 449);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 129);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Magnetometer";
            // 
            // chcYawMag
            // 
            this.chcYawMag.AutoSize = true;
            this.chcYawMag.Location = new System.Drawing.Point(6, 87);
            this.chcYawMag.Name = "chcYawMag";
            this.chcYawMag.Size = new System.Drawing.Size(47, 17);
            this.chcYawMag.TabIndex = 3;
            this.chcYawMag.Text = "YAW";
            this.chcYawMag.UseVisualStyleBackColor = true;
            // 
            // chcPitchMag
            // 
            this.chcPitchMag.AutoSize = true;
            this.chcPitchMag.Location = new System.Drawing.Point(6, 53);
            this.chcPitchMag.Name = "chcPitchMag";
            this.chcPitchMag.Size = new System.Drawing.Size(61, 17);
            this.chcPitchMag.TabIndex = 2;
            this.chcPitchMag.Text = "PITCH";
            this.chcPitchMag.UseVisualStyleBackColor = true;
            // 
            // chcRollMag
            // 
            this.chcRollMag.AutoSize = true;
            this.chcRollMag.Location = new System.Drawing.Point(6, 20);
            this.chcRollMag.Name = "chcRollMag";
            this.chcRollMag.Size = new System.Drawing.Size(54, 17);
            this.chcRollMag.TabIndex = 1;
            this.chcRollMag.Text = "ROLL";
            this.chcRollMag.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox10.Location = new System.Drawing.Point(780, 281);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(186, 162);
            this.groupBox10.TabIndex = 24;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Camera";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "5 Hz,",
            "10 Hz,",
            "15 Hz,",
            "20 Hz,",
            "25 Hz,",
            "30 Hz,",
            "35 Hz,",
            "40 Hz,",
            "45 Hz,",
            "50 Hz"});
            this.comboBox3.Location = new System.Drawing.Point(10, 46);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(102, 21);
            this.comboBox3.TabIndex = 25;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.comboBox3);
            this.groupBox11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox11.Location = new System.Drawing.Point(1142, 589);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(200, 122);
            this.groupBox11.TabIndex = 26;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Config";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Refresh Rate";
            // 
            // GCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Fira Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GCS";
            this.Text = "GROUND CONTROL STATION ( G C S ) EDF ROCKET UNIVERSITAS WAHID HASYIM SEMARANG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPacRecei;
        private System.Windows.Forms.TextBox txtPacEror;
        private System.Windows.Forms.TextBox txtPacSent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtCompass;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chcYawAcc;
        private System.Windows.Forms.CheckBox chcPitchAcc;
        private System.Windows.Forms.CheckBox checkRollAcc;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chcYawGyro;
        private System.Windows.Forms.CheckBox chcPitchGyro;
        private System.Windows.Forms.CheckBox chcRollGyro;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox chcYawMag;
        private System.Windows.Forms.CheckBox chcPitchMag;
        private System.Windows.Forms.CheckBox chcRollMag;
        private System.Windows.Forms.TextBox txtGPS;
        private System.Windows.Forms.TextBox txtEDF;
        private System.Windows.Forms.TextBox txtEMU;
        private System.Windows.Forms.TextBox txtNavstate;
        private System.Windows.Forms.TextBox txtGPSmode;
        private System.Windows.Forms.TextBox txtLongi;
        private System.Windows.Forms.TextBox txtLatt;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label11;
    }
}

