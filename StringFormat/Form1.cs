namespace StringFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("C : " + String.Format("{0:C1}", 25.50));
            listBox1.Items.Add("C : " + String.Format("{0:C2}", 25.50));
            listBox1.Items.Add("C : " + String.Format("{0:C3}", 25.50));
            listBox1.Items.Add("C : " + String.Format("{0:C4}", 25.50));
            listBox1.Items.Add("D : " + String.Format("{0:D3}", 18));
            listBox1.Items.Add("D : " + String.Format("{0:D5}", 18));
            listBox1.Items.Add("E : " + String.Format("{0:E}", 85000));
            listBox1.Items.Add("F : " + String.Format("{0:F1}", 12.5));
            listBox1.Items.Add("F : " + String.Format("{0:F2}", 12.5));
            listBox1.Items.Add("F : " + String.Format("{0:F3}", 12.5));
            listBox1.Items.Add("N : " + String.Format("{0:N}", 1700000));
            listBox1.Items.Add("X : " + String.Format("{0:X}", 950));
            listBox1.Items.Add("0 : " + String.Format("{0:000000.00}", 18.2));
            listBox1.Items.Add("# : " + String.Format("{0:###.##}", 15.551));

        }
    }
}
