using SimulatorAcc;

namespace WindowFormSimulador
{
    public partial class AnalysisForm : Form
    {
        private Accumulator? _compiler;
        private readonly string[]? _code;

        public AnalysisForm(string[] code)
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.White;
            _code = code;
        }

        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            _compiler = new Accumulator(_code!);

            var errorsCount = _compiler.AssembleSourceFile();

            dgvRules.DataSource = _compiler.RulesTable;
            dgvInstrucctions.DataSource = _compiler.Code;
            dgvSymbols.DataSource = _compiler.SymbolTable;
            dgvErrors.DataSource = _compiler.Errors;

            string text, caption = "Resultado";

            if (errorsCount > 0)
            {
                text = $"El ensamblado no fue del todo Ensamblado no fue del todo exitoso exitoso. {_compiler.LexErrors} errores léxicos y {_compiler.ParseErrors} errores de análisis fueron detectados.";
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            text = "El ensamblado fue realizado con éxito.";
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvInstrucctions.Focus();
        }

        private void verCPUToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new CPUForm(_compiler!);
            form.ShowDialog();
        }
    }
}
