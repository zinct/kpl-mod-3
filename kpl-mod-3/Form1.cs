using System.Numerics;

namespace kpl_mod_3
{
    public partial class Form1 : Form
    {
        List<String> calculator = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void updateUI()
        {
            String label = "Operator : ";
            for (int i = 0; i < calculator.Count; i++)
            {
                label = label + " " + calculator[i];
            }

            label3.Text = label;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tambah
            if(calculator.Count == 0) 
            {
                return;
            }
            if (calculator[calculator.Count - 1] == "+")
            {
                return;
            }
            calculator.Add(button1.Text);
            updateUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sama
            int hasil = 0;
            foreach (var cal in calculator)
            {
                int number;
                if(int.TryParse(cal, out number))
                {
                    hasil += number;
                }
            }

            label2.Text = "Hasil : " + hasil.ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            calculator.Add(button3.Text);
            updateUI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            
            calculator.Add(button4.Text);
            updateUI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            calculator.Add(button5.Text);
            updateUI();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            calculator.Add(button6.Text);
            updateUI();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            calculator.Add(button7.Text);
            updateUI();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            calculator.Add(button8.Text);
            updateUI();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            calculator.Add(button9.Text);
            updateUI();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            calculator.Add(button10.Text);
            updateUI();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            calculator.Add(button11.Text);
            updateUI();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (calculator.Count > 0)
            {
                if (calculator[calculator.Count - 1] != "+")
                {
                    return;
                }
            }
            calculator.Add(button12.Text);
            updateUI();
        }
    }
}
