using System.Timers;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] arabalar = { "ford", "bwm", "volvo" };
            listBox1.Items.AddRange(arabalar);

            
            string[] modeller = { "Focus", "320i", "XC60" };
            listBox2.Items.AddRange(modeller);

           
            string[] paketler = { "Titanium", "M Sport", "Inscription" };
            listBox3.Items.AddRange(paketler);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH.mm.ss");
        }

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index >= 0)
            {
                listBox2.SelectedIndex = index;
                listBox3.SelectedIndex = index;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                listBox3.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
        }
    }
}



