namespace formsinf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.mas[0] = "";
            Data.mas[1] = "";
            Data.mas[2] = "";
            Data.mas[3] = "";
            Data.mas[4] = "";
            Data.mas[5] = "";

            Form2 form2 = new Form2();

            DialogResult result = form2.ShowDialog();

            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Add(Data.mas);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(row);
            }
            catch
            {
                MessageBox.Show("Строка уже удалена!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            DialogResult result = form3.ShowDialog();
            int row = dataGridView1.CurrentRow.Index;

            for (int i = 0; i < Data.mas.Length; i++)
            {
                Data.mas[0] = dataGridView1.Rows[row].Cells[0].Value.ToString();
                Data.mas[1] = dataGridView1.Rows[row].Cells[1].Value.ToString();
                Data.mas[2] = dataGridView1.Rows[row].Cells[2].Value.ToString();
                Data.mas[3] = dataGridView1.Rows[row].Cells[3].Value.ToString();
                Data.mas[4] = dataGridView1.Rows[row].Cells[4].Value.ToString();
                Data.mas[5] = dataGridView1.Rows[row].Cells[5].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Иванов", "Иван", "Иванович", "муж.", "01.01.1973", "Москва");
        }
    }
}