using SimulatorAcc;

namespace WindowFormSimulador
{
    public partial class MainForm : Form
    {
        private Accumulator? Compiler;

        public MainForm()
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.White;
        }

        private void VerCPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var isMainPanel = verCPUToolStripMenuItem.Text.Equals("Ver CPU");

            if (isMainPanel)
            {
                verCPUToolStripMenuItem.Text = "Ver Pantalla Principal";
                mainPanel.SendToBack();
                return;
            }

            verCPUToolStripMenuItem.Text = "Ver CPU";
            mainPanel.BringToFront();
        }

        private void EjectuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compiler = new Accumulator(@"C:\Users\steve\source\repos\sample.asm");

            var errorsCount = Compiler.AssembleSourceFile();

            txtBoxCode.Lines = Compiler.inputFileContent;
            dgvRules.DataSource = Compiler.ProgramConstructs;
            dgvInstrucctions.DataSource = Compiler.Code;
            dgvSymbols.DataSource = Compiler.SymbolTable;
            dgvErrors.DataSource = Compiler.Errors;
            listBox1.DataSource = Compiler.LeanFileContent;

            string text, caption = "Result";

            if (errorsCount != 0)
            {
                text = $"Assembled was not entirely successful. {Compiler.LexErrors} lexical errors and {Compiler.ParseErrors} parsing errors were detected.";
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            text = "Assembly done successfully.";
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
