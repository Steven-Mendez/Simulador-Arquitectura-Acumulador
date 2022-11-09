using FastColoredTextBoxNS;

namespace WindowFormSimulador
{
    public partial class CodeEditor : Form
    {
        public CodeEditor()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear all text from textbox
            fastColoredTextBox1.Clear();
            Text = "Accumulator Simulator - Code Editor";
        }

        private void OpenDlg()
        {
            // Create new open file dialog
            OpenFileDialog of = new()
            {
                Filter = "Assambly code|*.asm|Any File|*.*"
            };

            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new(of.FileName);
                fastColoredTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                Text = of.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDlg();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new(Text);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
            catch (Exception)
            {
                SaveDlg();
            }
        }

        private void SaveDlg()
        {
            SaveFileDialog sf = new()
            {
                Filter = "Assambly code|*.asm|Any File|*.*"
            };

            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new(sf.FileName);
                sr.Write(fastColoredTextBox1.Text);
                sr.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDlg();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.BackColor = cd.Color;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.ForeColor = cd.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Font = fd.Font;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void selectLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.FindForm();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AnalysisForm(fastColoredTextBox1.Lines.ToArray());
            form.ShowDialog();
        }

        readonly Style StatementStyle = new TextStyle(Brushes.Blue, null, FontStyle.Italic);
        readonly Style OperationStyle = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Italic);
        readonly string operations = "DW|LOAD|ADD|SUB|MUL|DIV|STORE|JMP|JG|JGE|JL|JLE|JZ|NOP|HLT|CMP";

        private void fastColoredTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //clear style of changed range
            e.ChangedRange.ClearStyle(StatementStyle);
            e.ChangedRange.ClearStyle(OperationStyle);

            //comment highlighting
            e.ChangedRange.SetStyle(StatementStyle, @".Data|.Code|.DATA|.CODE|:[A-Z|a-z|0-9]+");
           
            e.ChangedRange.SetStyle(OperationStyle, @$"{operations}|{operations.ToLower()}");
        }
    }
}
