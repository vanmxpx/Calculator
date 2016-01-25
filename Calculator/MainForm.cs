using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int action = 0;
        bool dot = false;
        double resolution = 0;

        /*
        public event EventHandler ButtonPlusMinusClick;
        public event EventHandler ButtonDotClick;
        public event EventHandler ButtonMultClick;
        public event EventHandler ButtonDivClick;
        public event EventHandler ButtonPlusClick;
        public event EventHandler ButtonMinusClick;
        public event EventHandler ButtonResolClick;
        public event EventHandler ButtonBSClick;
        public event EventHandler ButtonDelClick;*/

        #region Number buttons
        private void button1_Click(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "1";
                    break;
                case "+":
                    ResolutionTextBox.Text = "1";
                    break;
                case "-":
                    ResolutionTextBox.Text = "1";
                    break;
                case "*":
                    ResolutionTextBox.Text = "1";
                    break;
                case "/":
                    ResolutionTextBox.Text = "1";
                    break;
                default:
                    ResolutionTextBox.Text += "1";
                    break;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "2";
                    break;
                case "+":
                    ResolutionTextBox.Text = "2";
                    break;
                case "-":
                    ResolutionTextBox.Text = "2";
                    break;
                case "*":
                    ResolutionTextBox.Text = "2";
                    break;
                case "/":
                    ResolutionTextBox.Text = "2";
                    break;
                default:
                    ResolutionTextBox.Text += "2";
                    break;
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "3";
                    break;
                case "+":
                    ResolutionTextBox.Text = "3";
                    break;
                case "-":
                    ResolutionTextBox.Text = "3";
                    break;
                case "*":
                    ResolutionTextBox.Text = "3";
                    break;
                case "/":
                    ResolutionTextBox.Text = "3";
                    break;
                default:
                    ResolutionTextBox.Text += "3";
                    break;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "4";
                    break;
                case "+":
                    ResolutionTextBox.Text = "4";
                    break;
                case "-":
                    ResolutionTextBox.Text = "4";
                    break;
                case "*":
                    ResolutionTextBox.Text = "4";
                    break;
                case "/":
                    ResolutionTextBox.Text = "4";
                    break;
                default:
                    ResolutionTextBox.Text += "4";
                    break;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "5";
                    break;
                case "+":
                    ResolutionTextBox.Text = "5";
                    break;
                case "-":
                    ResolutionTextBox.Text = "5";
                    break;
                case "*":
                    ResolutionTextBox.Text = "5";
                    break;
                case "/":
                    ResolutionTextBox.Text = "5";
                    break;
                default:
                    ResolutionTextBox.Text += "5";
                    break;
            }
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "6";
                    break;
                case "+":
                    ResolutionTextBox.Text = "6";
                    break;
                case "-":
                    ResolutionTextBox.Text = "6";
                    break;
                case "*":
                    ResolutionTextBox.Text = "6";
                    break;
                case "/":
                    ResolutionTextBox.Text = "6";
                    break;
                default:
                    ResolutionTextBox.Text += "6";
                    break;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "7";
                    break;
                case "+":
                    ResolutionTextBox.Text = "7";
                    break;
                case "-":
                    ResolutionTextBox.Text = "7";
                    break;
                case "*":
                    ResolutionTextBox.Text = "7";
                    break;
                case "/":
                    ResolutionTextBox.Text = "7";
                    break;
                default:
                    ResolutionTextBox.Text += "7";
                    break;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "8";
                    break;
                case "+":
                    ResolutionTextBox.Text = "8";
                    break;
                case "-":
                    ResolutionTextBox.Text = "8";
                    break;
                case "*":
                    ResolutionTextBox.Text = "8";
                    break;
                case "/":
                    ResolutionTextBox.Text = "8";
                    break;
                default:
                    ResolutionTextBox.Text += "8";
                    break;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "9";
                    break;
                case "+":
                    ResolutionTextBox.Text = "9";
                    break;
                case "-":
                    ResolutionTextBox.Text = "9";
                    break;
                case "*":
                    ResolutionTextBox.Text = "9";
                    break;
                case "/":
                    ResolutionTextBox.Text = "9";
                    break;
                default:
                    ResolutionTextBox.Text += "9";
                    break;
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = "0";
                    break;
                case "+":
                    ResolutionTextBox.Text = "0";
                    break;
                case "-":
                    ResolutionTextBox.Text = "0";
                    break;
                case "*":
                    ResolutionTextBox.Text = "0";
                    break;
                case "/":
                    ResolutionTextBox.Text = "0";
                    break;
                default:
                    ResolutionTextBox.Text += "0";
                    break;
            }
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!dot)
            {
                ResolutionTextBox.Text += ",";
                dot = true;
            }
        }
        #endregion

        private void buttonResolution_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case 1:
                    resolution += Convert.ToDouble(ResolutionTextBox.Text);
                    break;
                case 2:
                    resolution -= Convert.ToDouble(ResolutionTextBox.Text);
                    break;
                case 3:
                    resolution *= Convert.ToDouble(ResolutionTextBox.Text);
                    break;
                case 4:
                    resolution /= Convert.ToDouble(ResolutionTextBox.Text);
                    break;
            }
            HistoryTextBox.Text += ResolutionTextBox.Text + "=" + resolution + ";";
            ResolutionTextBox.Text = Convert.ToString(resolution);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            HistoryTextBox.Clear();
            ResolutionTextBox.Text = "0";
            resolution = 0;
            action = 0;
            dot = false;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if ( action == 0 ) resolution = Convert.ToDouble(ResolutionTextBox.Text);
            else resolution -= Convert.ToDouble(ResolutionTextBox.Text); 
            HistoryTextBox.Text += Convert.ToDouble(ResolutionTextBox.Text) + "-";
            ResolutionTextBox.Text = "-";
            action = 2;
            dot = false;
        }

        private void buttonMyltiply_Click(object sender, EventArgs e)
        {
            if (action == 0) resolution = Convert.ToDouble(ResolutionTextBox.Text);
            else resolution *= Convert.ToDouble(ResolutionTextBox.Text);
            HistoryTextBox.Text += Convert.ToDouble(ResolutionTextBox.Text) + "*";
            ResolutionTextBox.Text = "*";
            action = 3;
            dot = false;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (action == 0) resolution = Convert.ToDouble(ResolutionTextBox.Text);
            else resolution /= Convert.ToDouble(ResolutionTextBox.Text);
            HistoryTextBox.Text += Convert.ToDouble(ResolutionTextBox.Text) + "/";
            ResolutionTextBox.Text = "/";
            action = 4;
            dot = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            resolution += Convert.ToDouble(ResolutionTextBox.Text);
            HistoryTextBox.Text += Convert.ToDouble(ResolutionTextBox.Text) + "+";
            ResolutionTextBox.Text = "+";
            action = 1;
            dot = false;
        }

    }
}
