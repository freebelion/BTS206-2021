using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2_HesapMakinesi
{
    public partial class AnaForm : Form
    {
        double FirstNumber;
        string Operation;
        private const int bosluk = 5;

        public AnaForm()
        {
            InitializeComponent();

            this.Load += AnaForm_Load;
            this.SizeChanged += AnaForm_BoyutDegisti;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(textBox1);
            this.MinimumSize = new Size(495, 766);



            FormDuzenle();
        }

        private void AnaForm_BoyutDegisti(object sender, EventArgs e)
        {
            FormDuzenle();
        }

        private void FormDuzenle()
        {
            textBox1.Left = bosluk;
            textBox1.Top = bosluk;
            textBox1.Width = this.ClientRectangle.Width - 2 * bosluk;

        }
        private void button1_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "1";

            }

            else

            {

                textBox1.Text = textBox1.Text + "1";

            }

        }

        private void button2_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "2";

            }

            else

            {

                textBox1.Text = textBox1.Text + "2";

            }

        }

        private void button3_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "3";

            }

            else

            {

                textBox1.Text = textBox1.Text + "3";

            }

        }

        private void button4_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "4";

            }

            else

            {

                textBox1.Text = textBox1.Text + "4";

            }

        }

        private void button5_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "5";

            }

            else

            {

                textBox1.Text = textBox1.Text + "5";

            }

        }

        private void button6_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "6";

            }

            else

            {

                textBox1.Text = textBox1.Text + "6";

            }

        }

        private void button7_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "7";

            }

            else

            {

                textBox1.Text = textBox1.Text + "7";

            }

        }

        private void button8_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "8";

            }

            else

            {

                textBox1.Text = textBox1.Text + "8";

            }

        }

        private void button9_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "9";

            }

            else

            {

                textBox1.Text = textBox1.Text + "9";

            }

        }

        private void button0_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "0";

            }

            else

            {

                textBox1.Text = textBox1.Text + "0";

            }

        }

        private void button10_Click(object sender, EventArgs e)

        {

            textBox1.Text = textBox1.Text + ",";

        }

        private void button12_Click(object sender, EventArgs e)

        {

            FirstNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "+";

        }

        private void button13_Click(object sender, EventArgs e)

        {

            FirstNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "-";

        }

        private void button14_Click(object sender, EventArgs e)

        {

            FirstNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "*";

        }

        private void button15_Click(object sender, EventArgs e)

        {

            FirstNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "/";

        }

        private void button16_Click(object sender, EventArgs e)

        {

            double SecondNumber;

            double Result;



            SecondNumber = Convert.ToDouble(textBox1.Text);



            if (Operation == "+")

            {

                Result = (FirstNumber + SecondNumber);

                textBox1.Text = Convert.ToString(Result);

                FirstNumber = Result;

            }

            if (Operation == "-")

            {

                Result = (FirstNumber - SecondNumber);

                textBox1.Text = Convert.ToString(Result);

                FirstNumber = Result;



            }

            if (Operation == "*")

            {

                Result = (FirstNumber * SecondNumber);

                textBox1.Text = Convert.ToString(Result);

                FirstNumber = Result;

            }

            if (Operation == "/")

                if (SecondNumber == 0)

                {

                    textBox1.Text = "";

                }

                else

                {

                    Result = (FirstNumber / SecondNumber);

                    textBox1.Text = Convert.ToString(Result);

                    FirstNumber = Result;

                }

        }

        private void button17_Click(object sender, EventArgs e)

        {

            textBox1.Text = null;

        }

        private void AnaForm_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
