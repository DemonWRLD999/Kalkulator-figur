namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Kwadrat");
            comboBox1.Items.Add("Koło");
            comboBox1.Items.Add("Trójkąt");
            comboBox1.Items.Add("Prostokąt");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = 0;
                double pole = 0;
                double obwod = 0;

                string figura = comboBox1.SelectedItem.ToString();

                if (figura == "Prostokąt")
                {
                    b = Convert.ToDouble(textBox2.Text);
                    pole = a * b;
                    obwod = 2 * (a + b);
                }
                else if (figura == "Kwadrat")
                {
                    pole = a * a;
                    obwod = 4 * a;
                }
                else if (figura == "Trójkąt")
                {
                    b = Convert.ToDouble(textBox2.Text);
                    pole = (a * b) / 2;
                    double c = Math.Sqrt(a * a + b * b);
                    obwod = a + b + c;
                }
                else if (figura == "Koło")
                {
                    pole = Math.PI * a * a;
                    obwod = 2 * Math.PI * a;
                }

                label6.Text = "Pole: " + pole.ToString("0.00");
                label7.Text = "Obwód: " + obwod.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }
    }
}