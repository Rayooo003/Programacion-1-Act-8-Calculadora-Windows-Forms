using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaeación de variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textScreen.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textScreen.TextLength == 1) textScreen.Text = "0";
            else textScreen.Text = Text.Substring(0, textScreen.TextLength - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + ",";
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textScreen.Text);
            switch (operador)
            {
                case "+":
                    textScreen.Text = $"{num1 + num2}";
                    break;
                case "-":
                    textScreen.Text = $"{num1 - num2}";
                    break;
                case "*":
                    textScreen.Text = $"{num1 * num2}";
                    break;
                case "/":
                    textScreen.Text = $"{num1 / num2}";
                    break;
            }
        }
    }
}
