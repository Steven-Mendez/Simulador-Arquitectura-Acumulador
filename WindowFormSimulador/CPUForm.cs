using SimulatorAcc;
using SimulatorAcc.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormSimulador
{
    public partial class CPUForm : Form
    {
        private Accumulator _compiler;
        public CPUForm(Accumulator compiler)
        {
            InitializeComponent();
            _compiler = compiler;
        }

        private void CPUForm_Load(object sender, EventArgs e)
        {
            _compiler.MemoryCells = new List<MemoryCell>();
            for (int i = 0; i < 1024; i++)
            {
                _compiler.MemoryCells.Add(
                    new MemoryCell()
                    {
                        Address = i.ToString().PadLeft(4, '0'),
                        Value = "0"
                    });
            }

            int pc = _compiler!.LoadProgram();
            dataGridViewMemory.DataSource = _compiler!.MemoryCells;
            textBoxMAR.Text = "0000";
            textBoxMDR.Text = "0000";
            textBoxPC.Text = pc.ToString().PadLeft(4, '0');
            textBoxIR.Text = "0000";
        }
    }
}
