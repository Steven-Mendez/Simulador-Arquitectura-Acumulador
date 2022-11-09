﻿using SimulatorAcc;
using SimulatorAcc.Memory;

namespace WindowFormSimulador
{
    public partial class CPUForm : Form
    {
        private Accumulator _compiler;
        private int i = 0;
        private int len = 0;
        private Dictionary<string, (string, int)> variables;
        const int MAddress = 0, MType = 3, MValue = 2, MText = 1;

        public CPUForm(Accumulator compiler)
        {
            InitializeComponent();
            _compiler = compiler;
            variables = new Dictionary<string, (string, int)>();
        }

        private void CPUForm_Load(object sender, EventArgs e)
        {
            _compiler.MemoryCells = new List<MemoryCell>();
            var padding = new Random().Next(0, 100);
            for (int i = 0; i < _compiler.SymbolTable.Count + _compiler.Code.Count; i++)
            {
                _compiler.MemoryCells.Add(
                    new MemoryCell()
                    {
                        Address = (i + padding).ToString().PadLeft(3, '0'),
                        Value = "0"
                    });
            }

            int pc = _compiler!.LoadProgram();
            dataGridViewMemory.DataSource = _compiler!.MemoryCells;
            dataGridViewMemory.Columns[MAddress].HeaderText = "Dir";
            dataGridViewMemory.Columns[MAddress].Width = 26;
            dataGridViewMemory.Columns[MText].HeaderText = "Código";
            dataGridViewMemory.Columns[MText].Width = 105;
            dataGridViewMemory.Columns[MValue].HeaderText = "Valor";
            dataGridViewMemory.Columns[MValue].Width = 62;
            dataGridViewMemory.Columns[MType].Visible = false;
            textBoxMAR.Text = "0";
            textBoxMDR.Text = "0";
            textBoxPC.Text = "0";
            textBoxIR.Text = "0";
            textBoxACC.Text = "0";
            len = dataGridViewMemory.Rows.Count;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            if (i >= len)
            {
                timer1.Stop();
                return;
            }

            // Print the selected row
            dataGridViewMemory.CurrentRow.Selected = false;
            dataGridViewMemory.Rows[i].Selected = true;
            textBoxPC.Text = i.ToString();

            // Obtaining the data
            string address = dataGridViewMemory.Rows[i].Cells[MAddress].Value.ToString()!;
            string text = dataGridViewMemory.Rows[i].Cells[MText].Value.ToString()!;
            string value = dataGridViewMemory.Rows[i].Cells[MValue].Value.ToString()!;
            string type = dataGridViewMemory.Rows[i].Cells[MType].Value.ToString()!;

            if (!Equals("Variable", type) && !Equals("Label", type))
            {
                fetch(ref address, ref value);

                execute(ref text);
            }
            else if (!variables.TryGetValue(text, out _))
            {
                variables.Add(text, (address, Convert.ToInt32(value)));
            }
            i++;
        }

        private void CPUForm_Shown(object sender, EventArgs e)
        {
            labelCpu.Focus();
            timer1.Start();
        }

        private void CPUForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void fetch(ref string address, ref string value)
        {
            // Load the address to MAR
            textBoxMAR.Text = address;

            // Load the content of the address to MDR
            textBoxMDR.Text = value;

            // Put content of the instruction to IR
            textBoxIR.Text = textBoxMDR.Text;

            // Increment PC
            textBoxPC.Text = (i + 1).ToString();
        }

        private void execute(ref string text)
        {
            if (text.Contains("LOAD"))
            {
                text = text.Replace("LOAD", "").Trim();
                if (variables.TryGetValue(text, out (string, int) value))
                {
                    // MAR pointing to the address of the variable.
                    textBoxMAR.Text = value.Item1;

                    // MDR now its containing the value
                    textBoxMDR.Text = value.Item2.ToString();

                    // Then place it to the ACC
                    textBoxACC.Text = textBoxMDR.Text;
                }
                else
                {
                    // MDR now its containing the value
                    textBoxMDR.Text = text;

                    // Then place it to the ACC
                    textBoxACC.Text = textBoxMDR.Text;
                }
                return;
            }

            if (text.Contains("STORE"))
            {
                text = text.Replace("STORE", "").Trim();
                if (variables.TryGetValue(text, out (string, int) value))
                {
                    // MAR pointing to the address of the variable.
                    textBoxMAR.Text = value.Item1;

                    // MDR now its containing the value
                    textBoxMDR.Text = value.Item2.ToString();

                    // Then place it to the Variable
                    var newValue = Convert.ToInt32(textBoxACC.Text);
                    variables[text] = (value.Item1, newValue);

                    foreach (DataGridViewRow row in dataGridViewMemory.Rows)
                    {
                        if (string.Equals(row.Cells[MText].Value, text))
                        {
                            row.Cells[MValue].Value = newValue;
                            return;
                        }
                    }
                }
                return;
            }

            if (text.Contains("ADD"))
            {
                text = text.Replace("ADD", "").Trim();
                if (variables.TryGetValue(text, out (string, int) value))
                {
                    // MAR pointing to the address of the variable.
                    textBoxMAR.Text = value.Item1;

                    // MDR now its containing the value
                    textBoxMDR.Text = value.Item2.ToString();

                    // Then add it to the ACC
                    var sum1 = Convert.ToInt32(textBoxACC.Text);
                    var sum2 = Convert.ToInt32(textBoxMDR.Text);
                    textBoxACC.Text = $"{sum1 + sum2}";
                }
                else
                {
                    // MDR now its containing the value
                    textBoxMDR.Text = text;

                    // Then add it to the ACC
                    var sum1 = Convert.ToInt32(textBoxACC.Text);
                    var sum2 = Convert.ToInt32(textBoxMDR.Text);
                    textBoxACC.Text = $"{sum1 + sum2}";
                }
                return;
            }

            if (text.Contains("SUB"))
            {
                text = text.Replace("SUB", "").Trim();
                if (variables.TryGetValue(text, out (string, int) value))
                {
                    // MAR pointing to the address of the variable.
                    textBoxMAR.Text = value.Item1;

                    // MDR now its containing the value
                    textBoxMDR.Text = value.Item2.ToString();

                    // Then sub it to the ACC
                    var sum1 = Convert.ToInt32(textBoxACC.Text);
                    var sum2 = Convert.ToInt32(textBoxMDR.Text);
                    textBoxACC.Text = $"{sum1 - sum2}";
                }
                else
                {
                    // MDR now its containing the value
                    textBoxMDR.Text = text;

                    // Then sub it to the ACC
                    var sum1 = Convert.ToInt32(textBoxACC.Text);
                    var sum2 = Convert.ToInt32(textBoxMDR.Text);
                    textBoxACC.Text = $"{sum1 - sum2}";
                }
                return;
            }

            if (text.Contains("MUL"))
            {
                text = text.Replace("MUL", "").Trim();
                if (variables.TryGetValue(text, out (string, int) value))
                {
                    // MAR pointing to the address of the variable.
                    textBoxMAR.Text = value.Item1;

                    // MDR now its containing the value
                    textBoxMDR.Text = value.Item2.ToString();

                    // Then mul it to the ACC
                    var sum1 = Convert.ToInt32(textBoxACC.Text);
                    var sum2 = Convert.ToInt32(textBoxMDR.Text);
                    textBoxACC.Text = $"{sum1 * sum2}";
                }
                else
                {
                    // MDR now its containing the value
                    textBoxMDR.Text = text;

                    // Then mul it to the ACC
                    var sum1 = Convert.ToInt32(textBoxACC.Text);
                    var sum2 = Convert.ToInt32(textBoxMDR.Text);
                    textBoxACC.Text = $"{sum1 * sum2}";
                }
                return;
            }

            if (text.Contains("DIV"))
            {
                text = text.Replace("DIV", "").Trim();
                if (variables.TryGetValue(text, out (string, int) value))
                {
                    // MAR pointing to the address of the variable.
                    textBoxMAR.Text = value.Item1;

                    // MDR now its containing the value
                    textBoxMDR.Text = value.Item2.ToString();

                    // Then div it to the ACC
                    var sum1 = Convert.ToInt32(textBoxACC.Text);
                    var sum2 = Convert.ToInt32(textBoxMDR.Text);
                    textBoxACC.Text = $"{sum1 / sum2}";
                }
                else
                {
                    // MDR now its containing the value
                    textBoxMDR.Text = text;

                    // Then div it to the ACC
                    var sum1 = Convert.ToInt32(textBoxACC.Text);
                    var sum2 = Convert.ToInt32(textBoxMDR.Text);
                    textBoxACC.Text = $"{sum1 / sum2}";
                }
                return;
            }

            if (text.Contains("JMP"))
            {
                text = text.Replace("JMP", "").Trim();
                if (variables.TryGetValue(text, out (string, int) value))
                {
                    // MAR pointing to the address of the variable.
                    textBoxMAR.Text = value.Item1;

                    // MDR now its containing the value
                    textBoxMDR.Text = (value.Item2 - 1).ToString();

                    // PC pointing to the same value
                    textBoxPC.Text = textBoxMDR.Text;
                    i = value.Item2 - 1;
                }
                return;
            }

        }
    }
}