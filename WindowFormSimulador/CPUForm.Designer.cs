namespace WindowFormSimulador
{
    partial class CPUForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPUForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxMAR = new System.Windows.Forms.TextBox();
            this.labelCpu = new System.Windows.Forms.Label();
            this.textBoxMDR = new System.Windows.Forms.TextBox();
            this.textBoxPC = new System.Windows.Forms.TextBox();
            this.textBoxIR = new System.Windows.Forms.TextBox();
            this.textBoxACC = new System.Windows.Forms.TextBox();
            this.textBoxFlags = new System.Windows.Forms.TextBox();
            this.dataGridViewMemory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LED0 = new System.Windows.Forms.PictureBox();
            this.LED1 = new System.Windows.Forms.PictureBox();
            this.LED2 = new System.Windows.Forms.PictureBox();
            this.Switch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Switch)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxMAR
            // 
            this.textBoxMAR.BackColor = System.Drawing.Color.White;
            this.textBoxMAR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMAR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxMAR.Location = new System.Drawing.Point(355, 78);
            this.textBoxMAR.Multiline = true;
            this.textBoxMAR.Name = "textBoxMAR";
            this.textBoxMAR.ReadOnly = true;
            this.textBoxMAR.Size = new System.Drawing.Size(142, 30);
            this.textBoxMAR.TabIndex = 3;
            this.textBoxMAR.Text = "MAR";
            this.textBoxMAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.BackColor = System.Drawing.Color.White;
            this.labelCpu.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelCpu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelCpu.Location = new System.Drawing.Point(342, 9);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(40, 21);
            this.labelCpu.TabIndex = 1;
            this.labelCpu.Text = "CPU";
            // 
            // textBoxMDR
            // 
            this.textBoxMDR.BackColor = System.Drawing.Color.White;
            this.textBoxMDR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMDR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMDR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxMDR.Location = new System.Drawing.Point(355, 171);
            this.textBoxMDR.Multiline = true;
            this.textBoxMDR.Name = "textBoxMDR";
            this.textBoxMDR.ReadOnly = true;
            this.textBoxMDR.Size = new System.Drawing.Size(142, 30);
            this.textBoxMDR.TabIndex = 4;
            this.textBoxMDR.Text = "MDR";
            this.textBoxMDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPC
            // 
            this.textBoxPC.BackColor = System.Drawing.Color.White;
            this.textBoxPC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxPC.Location = new System.Drawing.Point(355, 265);
            this.textBoxPC.Multiline = true;
            this.textBoxPC.Name = "textBoxPC";
            this.textBoxPC.ReadOnly = true;
            this.textBoxPC.Size = new System.Drawing.Size(142, 30);
            this.textBoxPC.TabIndex = 5;
            this.textBoxPC.Text = "PC";
            this.textBoxPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIR
            // 
            this.textBoxIR.BackColor = System.Drawing.Color.White;
            this.textBoxIR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxIR.Location = new System.Drawing.Point(355, 359);
            this.textBoxIR.Multiline = true;
            this.textBoxIR.Name = "textBoxIR";
            this.textBoxIR.ReadOnly = true;
            this.textBoxIR.Size = new System.Drawing.Size(142, 30);
            this.textBoxIR.TabIndex = 6;
            this.textBoxIR.Text = "IR";
            this.textBoxIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxACC
            // 
            this.textBoxACC.BackColor = System.Drawing.Color.White;
            this.textBoxACC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxACC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxACC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxACC.Location = new System.Drawing.Point(611, 143);
            this.textBoxACC.Multiline = true;
            this.textBoxACC.Name = "textBoxACC";
            this.textBoxACC.ReadOnly = true;
            this.textBoxACC.Size = new System.Drawing.Size(74, 30);
            this.textBoxACC.TabIndex = 7;
            this.textBoxACC.Text = "ACC";
            this.textBoxACC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFlags
            // 
            this.textBoxFlags.BackColor = System.Drawing.Color.White;
            this.textBoxFlags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFlags.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFlags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxFlags.Location = new System.Drawing.Point(586, 384);
            this.textBoxFlags.Multiline = true;
            this.textBoxFlags.Name = "textBoxFlags";
            this.textBoxFlags.ReadOnly = true;
            this.textBoxFlags.Size = new System.Drawing.Size(153, 30);
            this.textBoxFlags.TabIndex = 9;
            this.textBoxFlags.Text = "Flags";
            this.textBoxFlags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewMemory
            // 
            this.dataGridViewMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemory.Location = new System.Drawing.Point(23, 61);
            this.dataGridViewMemory.MultiSelect = false;
            this.dataGridViewMemory.Name = "dataGridViewMemory";
            this.dataGridViewMemory.RowHeadersVisible = false;
            this.dataGridViewMemory.RowTemplate.Height = 25;
            this.dataGridViewMemory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMemory.Size = new System.Drawing.Size(213, 299);
            this.dataGridViewMemory.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(407, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "MAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(407, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "MDR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(416, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "PC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(418, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "IR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(91, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Memoria";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(629, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "ACC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(670, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "ALU";
            // 
            // LED0
            // 
            this.LED0.BackColor = System.Drawing.Color.White;
            this.LED0.Image = global::WindowFormSimulador.Properties.Resources.green_led_off_hi;
            this.LED0.Location = new System.Drawing.Point(186, 384);
            this.LED0.Name = "LED0";
            this.LED0.Size = new System.Drawing.Size(50, 50);
            this.LED0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LED0.TabIndex = 20;
            this.LED0.TabStop = false;
            // 
            // LED1
            // 
            this.LED1.BackColor = System.Drawing.Color.White;
            this.LED1.Image = global::WindowFormSimulador.Properties.Resources.green_led_off_hi;
            this.LED1.Location = new System.Drawing.Point(129, 384);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(50, 50);
            this.LED1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LED1.TabIndex = 22;
            this.LED1.TabStop = false;
            // 
            // LED2
            // 
            this.LED2.BackColor = System.Drawing.Color.White;
            this.LED2.Image = global::WindowFormSimulador.Properties.Resources.green_led_off_hi;
            this.LED2.Location = new System.Drawing.Point(73, 384);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(50, 50);
            this.LED2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LED2.TabIndex = 23;
            this.LED2.TabStop = false;
            // 
            // Switch
            // 
            this.Switch.BackColor = System.Drawing.Color.White;
            this.Switch.Image = global::WindowFormSimulador.Properties.Resources.switch_off;
            this.Switch.Location = new System.Drawing.Point(17, 384);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(50, 50);
            this.Switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Switch.TabIndex = 24;
            this.Switch.TabStop = false;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // CPUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.LED2);
            this.Controls.Add(this.LED1);
            this.Controls.Add(this.LED0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMemory);
            this.Controls.Add(this.textBoxFlags);
            this.Controls.Add(this.textBoxACC);
            this.Controls.Add(this.textBoxIR);
            this.Controls.Add(this.textBoxPC);
            this.Controls.Add(this.textBoxMDR);
            this.Controls.Add(this.textBoxMAR);
            this.Controls.Add(this.labelCpu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CPUForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Acumulador - CPU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CPUForm_FormClosing);
            this.Load += new System.EventHandler(this.CPUForm_Load);
            this.Shown += new System.EventHandler(this.CPUForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LED2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Switch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxMAR;
        private Label labelCpu;
        private TextBox textBoxMDR;
        private TextBox textBoxPC;
        private TextBox textBoxIR;
        private TextBox textBoxACC;
        private TextBox textBoxFlags;
        private DataGridView dataGridViewMemory;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Label label1;
        private PictureBox LED0;
        private PictureBox LED1;
        private PictureBox LED2;
        private PictureBox Switch;
    }
}