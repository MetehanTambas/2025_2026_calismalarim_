namespace Hesap_Makinesi_Ödevi
{
    public partial class Form1 : Form
    {
        double sayi1, sayi2, sonuc;
        int tiklandi = 0, ekran1;
        string islem;
        bool sonucGosterildi = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        private void SayiyaBas(int rakam)
        {
            if (sonucGosterildi)
            {
                richTextBox1.Clear();
                sonucGosterildi = false;
            }

            ekran1 = rakam;
            richTextBox1.Text += ekran1;

            if (tiklandi == 0)
                sayi1 = double.Parse(richTextBox1.Text);
            else
                sayi2 = double.Parse(richTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e) => SayiyaBas(1);
        private void button6_Click(object sender, EventArgs e) => SayiyaBas(2);
        private void button5_Click(object sender, EventArgs e) => SayiyaBas(3);
        private void button4_Click(object sender, EventArgs e) => SayiyaBas(4);
        private void button3_Click(object sender, EventArgs e) => SayiyaBas(5);
        private void button2_Click(object sender, EventArgs e) => SayiyaBas(6);
        private void button10_Click(object sender, EventArgs e) => SayiyaBas(7);
        private void button9_Click(object sender, EventArgs e) => SayiyaBas(8);
        private void button8_Click(object sender, EventArgs e) => SayiyaBas(9);
        private void button7_Click(object sender, EventArgs e) => SayiyaBas(0);

 
        private void IslemSec(string secilenIslem)
        {
            tiklandi = 1;
            richTextBox1.Clear();
            islem = secilenIslem;
            sonuc = 0;
        }

        private void button11_Click(object sender, EventArgs e) => IslemSec("+");
        private void button15_Click(object sender, EventArgs e) => IslemSec("-");
        private void button14_Click(object sender, EventArgs e) => IslemSec("*");
        private void button13_Click(object sender, EventArgs e) => IslemSec("/");
        private void button12_Click(object sender, EventArgs e) => IslemSec("%");
        private void button20_Click(object sender, EventArgs e) => IslemSec("**"); 

       
        private void button16_Click(object sender, EventArgs e)
        {
            sonucGosterildi = true;
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                case "%":
                    sonuc = sayi1 % sayi2;
                    break;
                case "**":
                    sonuc = Math.Pow(sayi1, sayi2);
                    break;
                default:
                    richTextBox1.Text = "Hata";
                    return;
            }
            if (sonuc == 16)
            {
                Form2 x = new Form2();
                x.Show();
                Hide();
            }

            richTextBox1.Text = sonuc.ToString();
            sayi1 = 0;
            sayi2 = 0;
            tiklandi = 0;
        }

     
        private void button19_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim().Length > 0)
            {
                double current;
                if (double.TryParse(richTextBox1.Text.Trim(), out current))
                {
                    if (current < 0)
                        richTextBox1.Text = "Hata";
                    else
                    {
                        double r = Math.Sqrt(current);
                        richTextBox1.Text = r.ToString();
                        sayi1 = r;
                        tiklandi = 0;
                        sonucGosterildi = true;
                    }
                }

                sayi2 = 0;
                sonuc = 0;
            }
        }

      
        private void button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);

                if (tiklandi == 1)
                    sayi2 = richTextBox1.Text.Length > 0 ? double.Parse(richTextBox1.Text) : 0;
                else
                    sayi1 = richTextBox1.Text.Length > 0 ? double.Parse(richTextBox1.Text) : 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            sayi1 = 0;
            sayi2 = 0;
            sonuc = 0;
            tiklandi = 0;
            sonucGosterildi = false;
        }

     
        private void radioButton2_CheckedChanged(object sender, EventArgs e) => BackColor = Color.White;
        private void radioButton1_CheckedChanged(object sender, EventArgs e) => BackColor = Color.Black;
        private void radioButton3_CheckedChanged(object sender, EventArgs e) => BackColor = Color.Olive;
    }
}
