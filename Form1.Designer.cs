
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lisPort = new System.Windows.Forms.ComboBox();
            this.lisBaul = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.txtAveValue = new System.Windows.Forms.TextBox();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtnhietdo = new System.Windows.Forms.TextBox();
            this.btnLED1 = new System.Windows.Forms.Button();
            this.btnLED2 = new System.Windows.Forms.Button();
            this.btnLED3 = new System.Windows.Forms.Button();
            this.btnLED4 = new System.Windows.Forms.Button();
            this.btnLED5 = new System.Windows.Forms.Button();
            this.btnLED6 = new System.Windows.Forms.Button();
            this.btnLED7 = new System.Windows.Forms.Button();
            this.btnLED8 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUDRATE";
            // 
            // lisPort
            // 
            this.lisPort.FormattingEnabled = true;
            this.lisPort.Location = new System.Drawing.Point(83, 11);
            this.lisPort.Name = "lisPort";
            this.lisPort.Size = new System.Drawing.Size(99, 21);
            this.lisPort.TabIndex = 2;
            // 
            // lisBaul
            // 
            this.lisBaul.FormattingEnabled = true;
            this.lisBaul.Location = new System.Drawing.Point(83, 40);
            this.lisBaul.Name = "lisBaul";
            this.lisBaul.Size = new System.Drawing.Size(99, 21);
            this.lisBaul.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(205, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 49);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(123, 328);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(100, 20);
            this.txtMinValue.TabIndex = 8;
            this.txtMinValue.TextChanged += new System.EventHandler(this.txtMinValue_TextChanged);
            // 
            // txtAveValue
            // 
            this.txtAveValue.Location = new System.Drawing.Point(123, 363);
            this.txtAveValue.Name = "txtAveValue";
            this.txtAveValue.Size = new System.Drawing.Size(100, 20);
            this.txtAveValue.TabIndex = 9;
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(123, 395);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(100, 20);
            this.txtMaxValue.TabIndex = 10;
            this.txtMaxValue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "MIN VALUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "AVERAGE VALUE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "MAX VALUE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnStart
            // 
            this.btnStart.ImageKey = "(none)";
            this.btnStart.Location = new System.Drawing.Point(78, 98);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 29);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "MODE";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtnhietdo
            // 
            this.txtnhietdo.Location = new System.Drawing.Point(82, 184);
            this.txtnhietdo.Name = "txtnhietdo";
            this.txtnhietdo.Size = new System.Drawing.Size(100, 20);
            this.txtnhietdo.TabIndex = 18;
            // 
            // btnLED1
            // 
            this.btnLED1.Location = new System.Drawing.Point(82, 221);
            this.btnLED1.Name = "btnLED1";
            this.btnLED1.Size = new System.Drawing.Size(40, 40);
            this.btnLED1.TabIndex = 19;
            this.btnLED1.Text = "LED1 ";
            this.btnLED1.UseVisualStyleBackColor = true;
            this.btnLED1.Click += new System.EventHandler(this.btnLED1_Click);
            // 
            // btnLED2
            // 
            this.btnLED2.Location = new System.Drawing.Point(83, 267);
            this.btnLED2.Name = "btnLED2";
            this.btnLED2.Size = new System.Drawing.Size(40, 40);
            this.btnLED2.TabIndex = 20;
            this.btnLED2.Text = "LED2";
            this.btnLED2.UseVisualStyleBackColor = true;
            this.btnLED2.Click += new System.EventHandler(this.btnLED2_Click);
            // 
            // btnLED3
            // 
            this.btnLED3.Location = new System.Drawing.Point(129, 221);
            this.btnLED3.Name = "btnLED3";
            this.btnLED3.Size = new System.Drawing.Size(40, 40);
            this.btnLED3.TabIndex = 21;
            this.btnLED3.Text = "LED3";
            this.btnLED3.UseVisualStyleBackColor = true;
            this.btnLED3.Click += new System.EventHandler(this.btnLED3_Click);
            // 
            // btnLED4
            // 
            this.btnLED4.Location = new System.Drawing.Point(129, 267);
            this.btnLED4.Name = "btnLED4";
            this.btnLED4.Size = new System.Drawing.Size(40, 40);
            this.btnLED4.TabIndex = 22;
            this.btnLED4.Text = "LED4";
            this.btnLED4.UseVisualStyleBackColor = true;
            this.btnLED4.Click += new System.EventHandler(this.btnLED4_Click);
            // 
            // btnLED5
            // 
            this.btnLED5.Location = new System.Drawing.Point(175, 221);
            this.btnLED5.Name = "btnLED5";
            this.btnLED5.Size = new System.Drawing.Size(40, 40);
            this.btnLED5.TabIndex = 23;
            this.btnLED5.Text = "LED5";
            this.btnLED5.UseVisualStyleBackColor = true;
            this.btnLED5.Click += new System.EventHandler(this.btnLED5_Click);
            // 
            // btnLED6
            // 
            this.btnLED6.Location = new System.Drawing.Point(175, 267);
            this.btnLED6.Name = "btnLED6";
            this.btnLED6.Size = new System.Drawing.Size(40, 40);
            this.btnLED6.TabIndex = 24;
            this.btnLED6.Text = "LED6";
            this.btnLED6.UseVisualStyleBackColor = true;
            this.btnLED6.Click += new System.EventHandler(this.btnLED6_Click);
            // 
            // btnLED7
            // 
            this.btnLED7.Location = new System.Drawing.Point(221, 221);
            this.btnLED7.Name = "btnLED7";
            this.btnLED7.Size = new System.Drawing.Size(40, 40);
            this.btnLED7.TabIndex = 25;
            this.btnLED7.Text = "LED7";
            this.btnLED7.UseVisualStyleBackColor = true;
            this.btnLED7.Click += new System.EventHandler(this.btnLED7_Click);
            // 
            // btnLED8
            // 
            this.btnLED8.Location = new System.Drawing.Point(221, 267);
            this.btnLED8.Name = "btnLED8";
            this.btnLED8.Size = new System.Drawing.Size(40, 40);
            this.btnLED8.TabIndex = 26;
            this.btnLED8.Text = "LED8";
            this.btnLED8.UseVisualStyleBackColor = true;
            this.btnLED8.Click += new System.EventHandler(this.btnLED8_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(31, 436);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(135, 23);
            this.exit.TabIndex = 28;
            this.exit.Text = "EXIT PROGRAM";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(310, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(611, 447);
            this.zedGraphControl1.TabIndex = 29;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.on;
            this.pictureBox3.Location = new System.Drawing.Point(11, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.png_clipart_ampoule_lumiere_creativite_ampoule_a_incandescence_idee_dessin_logo_bijoux_de_corps;
            this.pictureBox2.Location = new System.Drawing.Point(11, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(11, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(933, 471);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnLED8);
            this.Controls.Add(this.btnLED7);
            this.Controls.Add(this.btnLED6);
            this.Controls.Add(this.btnLED5);
            this.Controls.Add(this.btnLED4);
            this.Controls.Add(this.btnLED3);
            this.Controls.Add(this.btnLED2);
            this.Controls.Add(this.btnLED1);
            this.Controls.Add(this.txtnhietdo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.txtAveValue);
            this.Controls.Add(this.txtMinValue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lisBaul);
            this.Controls.Add(this.lisPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lisPort;
        private System.Windows.Forms.ComboBox lisBaul;
        private System.Windows.Forms.Button btnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.TextBox txtAveValue;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtnhietdo;
        private System.Windows.Forms.Button btnLED1;
        private System.Windows.Forms.Button btnLED2;
        private System.Windows.Forms.Button btnLED3;
        private System.Windows.Forms.Button btnLED4;
        private System.Windows.Forms.Button btnLED5;
        private System.Windows.Forms.Button btnLED6;
        private System.Windows.Forms.Button btnLED7;
        private System.Windows.Forms.Button btnLED8;
        private System.Windows.Forms.Button exit;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

