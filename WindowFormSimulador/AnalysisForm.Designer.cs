namespace WindowFormSimulador
{
    partial class AnalysisForm
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
            this.lblIR = new System.Windows.Forms.Label();
            this.lblES = new System.Windows.Forms.Label();
            this.lblACC = new System.Windows.Forms.Label();
            this.lblALU = new System.Windows.Forms.Label();
            this.lblFlags = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verCPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dgvErrors = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSymbols = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInstrucctions = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSymbols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrucctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.SuspendLayout();
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
            this.verCPUToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verCPUToolStripMenuItem
            // 
            this.verCPUToolStripMenuItem.Name = "verCPUToolStripMenuItem";
            this.verCPUToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.verCPUToolStripMenuItem.Text = "Ejecutar";
            this.verCPUToolStripMenuItem.Click += new System.EventHandler(this.verCPUToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.dgvErrors);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.dgvSymbols);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.dgvInstrucctions);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.dgvRules);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 12;
            // 
            // dgvErrors
            // 
            this.dgvErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrors.Location = new System.Drawing.Point(398, 259);
            this.dgvErrors.Name = "dgvErrors";
            this.dgvErrors.RowTemplate.Height = 25;
            this.dgvErrors.Size = new System.Drawing.Size(381, 177);
            this.dgvErrors.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Errores:";
            // 
            // dgvSymbols
            // 
            this.dgvSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSymbols.Location = new System.Drawing.Point(3, 259);
            this.dgvSymbols.Name = "dgvSymbols";
            this.dgvSymbols.RowTemplate.Height = 25;
            this.dgvSymbols.Size = new System.Drawing.Size(381, 177);
            this.dgvSymbols.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tabla de Simbolos:";
            // 
            // dgvInstrucctions
            // 
            this.dgvInstrucctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrucctions.Location = new System.Drawing.Point(3, 49);
            this.dgvInstrucctions.Name = "dgvInstrucctions";
            this.dgvInstrucctions.RowTemplate.Height = 25;
            this.dgvInstrucctions.Size = new System.Drawing.Size(381, 177);
            this.dgvInstrucctions.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Instrucciones:";
            // 
            // dgvRules
            // 
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Location = new System.Drawing.Point(398, 49);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowTemplate.Height = 25;
            this.dgvRules.Size = new System.Drawing.Size(381, 177);
            this.dgvRules.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reglas:";
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFlags);
            this.Controls.Add(this.lblALU);
            this.Controls.Add(this.lblACC);
            this.Controls.Add(this.lblES);
            this.Controls.Add(this.lblIR);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AnalysisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Accumulador";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private Label lblIR;
        private Label lblES;
        private Label lblACC;
        private Label lblALU;
        private Label lblFlags;
        private MenuStrip menuStrip1;
        private Panel mainPanel;
        private DataGridView dgvErrors;
        private Label label6;
        private DataGridView dgvSymbols;
        private Label label5;
        private DataGridView dgvInstrucctions;
        private Label label4;
        private DataGridView dgvRules;
        private Label label3;
        private ToolStripMenuItem verCPUToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}