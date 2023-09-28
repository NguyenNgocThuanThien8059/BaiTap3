using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai3_3_MDI
{
    public partial class Form1 : Form
    {
        int number = 1;
        string ID;
        string Name;
        string Faculty;
        float Score;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 AddStudent = new Form2();
            AddStudent.Show();
        }
    }
}
