namespace Char_Çalışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            char harf;
            harf = Convert.ToChar(textBox1.Text);
            label1.Text = harf.ToString();

        }
    }
}