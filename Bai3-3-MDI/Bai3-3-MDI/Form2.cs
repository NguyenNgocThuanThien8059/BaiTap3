using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_3_MDI
{
    public partial class Form2 : Form
    {
        private int STT;
        private string MSSV;
        private string HoTenSV;
        private string DiemTB;
        public Form2()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            MSSV = textBox1.Text;
            HoTenSV = textBox2.Text;
            DiemTB = textBox3.Text;
            if (MSSV == "" || HoTenSV == "" || DiemTB == "")
            {
                MessageBox.Show(" Vui lòng nhập đầy đủ thông tin ");
            }
            if (DiemTB != "" && MSSV != "" && HoTenSV != "")
            {
                try
                {
                    float DTB = float.Parse(textBox3.Text);
                    if (DTB < 0 || DTB > 10)
                    {
                        MessageBox.Show(" Điểm trung bình chỉ từ 0 đến 10 thôi ");
                    }
                }
                catch
                {
                    MessageBox.Show(" Không cho phép nhập chữ vào khung Điểm TB. Vui lòng nhập số ");
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
       
    }
}
