namespace WindowFormSimulador
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblMemoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMAR = new System.Windows.Forms.Label();
            this.lblMDR = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblES = new System.Windows.Forms.Label();
            this.lblACC = new System.Windows.Forms.Label();
            this.lblALU = new System.Windows.Forms.Label();
            this.lblFlags = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejectuarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dgvErrors = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSymbols = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInstrucctions = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymbols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrucctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.BackColor = System.Drawing.Color.Transparent;
            this.lblMemoria.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMemoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMemoria.Location = new System.Drawing.Point(134, 290);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(101, 30);
            this.lblMemoria.TabIndex = 0;
            this.lblMemoria.Text = "Memoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(599, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU";
            // 
            // lblMAR
            // 
            this.lblMAR.AutoSize = true;
            this.lblMAR.BackColor = System.Drawing.Color.Transparent;
            this.lblMAR.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMAR.Location = new System.Drawing.Point(601, 141);
            this.lblMAR.Name = "lblMAR";
            this.lblMAR.Size = new System.Drawing.Size(60, 30);
            this.lblMAR.TabIndex = 2;
            this.lblMAR.Text = "MAR";
            // 
            // lblMDR
            // 
            this.lblMDR.AutoSize = true;
            this.lblMDR.BackColor = System.Drawing.Color.Transparent;
            this.lblMDR.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMDR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMDR.Location = new System.Drawing.Point(601, 272);
            this.lblMDR.Name = "lblMDR";
            this.lblMDR.Size = new System.Drawing.Size(61, 30);
            this.lblMDR.TabIndex = 3;
            this.lblMDR.Text = "MDR";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.BackColor = System.Drawing.Color.Transparent;
            this.lblPC.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblPC.Location = new System.Drawing.Point(612, 402);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(39, 30);
            this.lblPC.TabIndex = 4;
            this.lblPC.Text = "PC";
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.BackColor = System.Drawing.Color.Transparent;
            this.lblIR.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblIR.Location = new System.Drawing.Point(616, 541);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(32, 30);
            this.lblIR.TabIndex = 5;
            this.lblIR.Text = "IR";
            // 
            // lblES
            // 
            this.lblES.AutoSize = true;
            this.lblES.BackColor = System.Drawing.Color.Transparent;
            this.lblES.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblES.Location = new System.Drawing.Point(166, 590);
            this.lblES.Name = "lblES";
            this.lblES.Size = new System.Drawing.Size(45, 30);
            this.lblES.TabIndex = 6;
            this.lblES.Text = "E/S";
            // 
            // lblACC
            // 
            this.lblACC.AutoSize = true;
            this.lblACC.BackColor = System.Drawing.Color.Transparent;
            this.lblACC.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblACC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblACC.Location = new System.Drawing.Point(932, 184);
            this.lblACC.Name = "lblACC";
            this.lblACC.Size = new System.Drawing.Size(54, 30);
            this.lblACC.TabIndex = 7;
            this.lblACC.Text = "ACC";
            // 
            // lblALU
            // 
            this.lblALU.AutoSize = true;
            this.lblALU.BackColor = System.Drawing.Color.Transparent;
            this.lblALU.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblALU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblALU.Location = new System.Drawing.Point(995, 312);
            this.lblALU.Name = "lblALU";
            this.lblALU.Size = new System.Drawing.Size(52, 30);
            this.lblALU.TabIndex = 8;
            this.lblALU.Text = "ALU";
            // 
            // lblFlags
            // 
            this.lblFlags.AutoSize = true;
            this.lblFlags.BackColor = System.Drawing.Color.Transparent;
            this.lblFlags.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFlags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblFlags.Location = new System.Drawing.Point(947, 576);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(62, 30);
            this.lblFlags.TabIndex = 9;
            this.lblFlags.Text = "Flags";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.compilarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.archivoToolStripMenuItem.Text = "Opciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(156, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // compilarToolStripMenuItem
            // 
            this.compilarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejectuarToolStripMenuItem,
            this.verCPUToolStripMenuItem});
            this.compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            this.compilarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.compilarToolStripMenuItem.Text = "Acciones";
            // 
            // ejectuarToolStripMenuItem
            // 
            this.ejectuarToolStripMenuItem.Name = "ejectuarToolStripMenuItem";
            this.ejectuarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ejectuarToolStripMenuItem.Text = "Ejectuar";
            this.ejectuarToolStripMenuItem.Click += new System.EventHandler(this.EjectuarToolStripMenuItem_Click);
            // 
            // verCPUToolStripMenuItem
            // 
            this.verCPUToolStripMenuItem.Name = "verCPUToolStripMenuItem";
            this.verCPUToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.verCPUToolStripMenuItem.Text = "Ver CPU";
            this.verCPUToolStripMenuItem.Click += new System.EventHandler(this.VerCPUToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1184, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.listBox1);
            this.mainPanel.Controls.Add(this.dgvErrors);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.dgvSymbols);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.dgvInstrucctions);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.dgvRules);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.txtBoxCode);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1184, 637);
            this.mainPanel.TabIndex = 12;
            // 
            // dgvErrors
            // 
            this.dgvErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrors.Location = new System.Drawing.Point(292, 510);
            this.dgvErrors.Name = "dgvErrors";
            this.dgvErrors.RowTemplate.Height = 25;
            this.dgvErrors.Size = new System.Drawing.Size(880, 113);
            this.dgvErrors.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Errores:";
            // 
            // dgvSymbols
            // 
            this.dgvSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSymbols.Location = new System.Drawing.Point(292, 350);
            this.dgvSymbols.Name = "dgvSymbols";
            this.dgvSymbols.RowTemplate.Height = 25;
            this.dgvSymbols.Size = new System.Drawing.Size(880, 113);
            this.dgvSymbols.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tabla de Simbolos:";
            // 
            // dgvInstrucctions
            // 
            this.dgvInstrucctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrucctions.Location = new System.Drawing.Point(292, 190);
            this.dgvInstrucctions.Name = "dgvInstrucctions";
            this.dgvInstrucctions.RowTemplate.Height = 25;
            this.dgvInstrucctions.Size = new System.Drawing.Size(880, 113);
            this.dgvInstrucctions.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Instrucciones:";
            // 
            // dgvRules
            // 
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Location = new System.Drawing.Point(292, 30);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowTemplate.Height = 25;
            this.dgvRules.Size = new System.Drawing.Size(880, 113);
            this.dgvRules.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reglas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.Location = new System.Drawing.Point(12, 26);
            this.txtBoxCode.Multiline = true;
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(264, 277);
            this.txtBoxCode.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 316);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 304);
            this.listBox1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.lblFlags);
            this.Controls.Add(this.lblALU);
            this.Controls.Add(this.lblACC);
            this.Controls.Add(this.lblES);
            this.Controls.Add(this.lblIR);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.lblMDR);
            this.Controls.Add(this.lblMAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMemoria);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Accumulador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymbols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrucctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMemoria;
        private Label label1;
        private Label lblMAR;
        private Label lblMDR;
        private Label lblPC;
        private Label lblIR;
        private Label lblES;
        private Label lblACC;
        private Label lblALU;
        private Label lblFlags;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripSeparator salirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem compilarToolStripMenuItem;
        private ToolStripMenuItem ejectuarToolStripMenuItem;
        private ToolStripMenuItem verCPUToolStripMenuItem;
        private Panel mainPanel;
        private Label label2;
        private TextBox txtBoxCode;
        private DataGridView dgvErrors;
        private Label label6;
        private DataGridView dgvSymbols;
        private Label label5;
        private DataGridView dgvInstrucctions;
        private Label label4;
        private DataGridView dgvRules;
        private Label label3;
        private ListBox listBox1;
    }
}