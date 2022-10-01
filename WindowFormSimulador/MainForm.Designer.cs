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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejectuarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarYEjecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.compilarToolStripMenuItem1,
            this.ejectuarToolStripMenuItem,
            this.compilarYEjecutarToolStripMenuItem});
            this.compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            this.compilarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.compilarToolStripMenuItem.Text = "Acciones";
            // 
            // compilarToolStripMenuItem1
            // 
            this.compilarToolStripMenuItem1.Name = "compilarToolStripMenuItem1";
            this.compilarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.compilarToolStripMenuItem1.Text = "Compilar";
            // 
            // ejectuarToolStripMenuItem
            // 
            this.ejectuarToolStripMenuItem.Name = "ejectuarToolStripMenuItem";
            this.ejectuarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejectuarToolStripMenuItem.Text = "Ejectuar";
            // 
            // compilarYEjecutarToolStripMenuItem
            // 
            this.compilarYEjecutarToolStripMenuItem.Name = "compilarYEjecutarToolStripMenuItem";
            this.compilarYEjecutarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compilarYEjecutarToolStripMenuItem.Text = "Compilar y ejecutar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
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
        private ToolStripMenuItem compilarToolStripMenuItem1;
        private ToolStripMenuItem ejectuarToolStripMenuItem;
        private ToolStripMenuItem compilarYEjecutarToolStripMenuItem;
    }
}