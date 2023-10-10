using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsinf
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Мужской");
            comboBox1.Items.Add("Женский");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.mas[0] = textBox1.Text;
            Data.mas[1] = textBox2.Text;
            Data.mas[2] = textBox3.Text;
            Data.mas[3] = comboBox1.Text;
            Data.mas[4] = dateTimePicker1.Text;
            Data.mas[5] = textBox4.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Data.mas[0];
            textBox2.Text = Data.mas[1];
            textBox3.Text = Data.mas[2];
            comboBox1.Text = Data.mas[3];
            dateTimePicker1.Text = Data.mas[4];
            textBox4.Text = Data.mas[5];
        }
    }
}
