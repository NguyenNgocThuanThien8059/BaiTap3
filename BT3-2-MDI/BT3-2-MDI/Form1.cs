using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BT3_2_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontdlg = new FontDialog();
            fontdlg.ShowColor = true;
            fontdlg.ShowApply = true;
            fontdlg.ShowEffects = true;
            fontdlg.ShowHelp = true;
            if(fontdlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontdlg.Color;
                richTextBox1.Font = fontdlg.Font;
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox2.SelectedIndex = 5;
            foreach(FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            toolStripComboBox1.SelectedText = "Tahoma";
            richTextBox1.SelectionFont = new Font("Tahoma", 14);
            
        }
        private void tạoVănBảnMớiCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lưuNộiDungVănBảnCtrlSToolStripMenuItem_Click(sender, e);
            richTextBox1.Clear();
        }

        private void lưuNộiDungVănBảnCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog slg = new SaveFileDialog();
            slg.Filter = " Rich Text File | *.rtf | Plain Text File | *.txt ";
            if(slg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(slg.FileName, richTextBox1.Text);
            }
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog olg = new OpenFileDialog();
            olg.Filter = " Rich Text Box File | *.rtf | Plain Text File | *.txt ";
            if(olg.ShowDialog() == DialogResult.OK)
            {
                var ReadFile = new StreamReader(olg.FileName);
                richTextBox1.Text = ReadFile.ReadToEnd();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tạoVănBảnMớiCtrlNToolStripMenuItem_Click(sender, e);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lưuNộiDungVănBảnCtrlSToolStripMenuItem_Click((object)sender, e);
        }
        public void ComboRTBTextChanged()
        {
            richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Regular);
            if (activateB == true)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Bold);
            }
            if (activateI == true)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Italic);
            }
            if (activateU == true)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Underline);
            }
        }
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            ComboRTBTextChanged();
        }

        private void toolStripComboBox2_TextChanged(object sender, EventArgs e)
        {
            ComboRTBTextChanged();
        }
        bool activeB = true;
        bool activateB = false;
        bool activateI = false;
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (activeB)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Bold);
                activeB = false;
                activateB = true;
                activeI = true;
                activateI = false;
                activeU = true;
                activateU = false;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Regular);
                activeB = true;
                activateB = false;
            }
        }
        private void toolStripButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
        bool activeI = true;
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (activeI)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Italic);
                activeI = false;
                activateI = true;
                activeB = true;
                activateB = false;
                activeU = true;
                activateU = false;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Regular);
                activeI = true;
                activateI = false;
            }
        }
        bool activeU = true;
        bool activateU = false;
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if(activeU)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Underline);
                activeU = false;
                activateU = true;
                activeB = true;
                activateB = false;
                activeI = true;
                activateI = false;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, int.Parse(toolStripComboBox2.Text), FontStyle.Regular);
                activeU = true;
                activateU = false;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lưuNộiDungVănBảnCtrlSToolStripMenuItem_Click(sender, e);
            this.Close();
        }
    }
}
