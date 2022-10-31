using SimulatorAcc;

namespace WindowFormSimulador
{
    public partial class MainForm : Form
    {
        private Accumulator? _compiler;
        private string[]? _code;

        public MainForm(string[] code)
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.White;
            _code = code;
            txtBoxCode.Lines = code;
        }

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
            _compiler = new Accumulator(@"C:\Users\steve\source\repos\sample.asm");

            var errorsCount = _compiler.AssembleSourceFile();

            txtBoxCode.Lines = _compiler.InputFileContent;
            dgvRules.DataSource = _compiler.RulesTable;
            dgvInstrucctions.DataSource = _compiler.Code;
            dgvSymbols.DataSource = _compiler.SymbolTable;
            dgvErrors.DataSource = _compiler.Errors;
            listBox1.DataSource = _compiler.LeanFileContent;

            string text, caption = "Result";

            if (errorsCount > 0)
            {
                text = $"Assembled was not entirely successful. {_compiler.LexErrors} lexical errors and {_compiler.ParseErrors} parsing errors were detected.";
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            text = "Assembly done successfully.";
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvInstrucctions.Focus();
        }
    }
}
