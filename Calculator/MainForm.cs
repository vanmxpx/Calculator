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

        int action = 0;
        bool dot = false;
        double resolution = 0;


        public MainForm()
        {
            InitializeComponent();
        }

        #region Number buttons
        private void button1_Click(object sender, EventArgs e)
        {
            CheckNums("1");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CheckNums("2");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CheckNums("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckNums("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckNums("5");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            CheckNums("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckNums("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckNums("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckNums("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
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
                    if (action == 5)
                    {
                        ResolutionTextBox.Text = "0";
                        action = 0;
                    }
                    else ResolutionTextBox.Text += "0";
                    break;
            }
        }

        #endregion

        #region Action buttons
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!dot)
            {
                ResolutionTextBox.Text += ",";
                dot = true;
            }
        }

        private void buttonResolution_Click(object sender, EventArgs e)
        {
            if (CheckActions(action))
            {
                HistoryTextBox.Text += ResolutionTextBox.Text + "=" + resolution + ";";
                ResolutionTextBox.Text = Convert.ToString(resolution);
                action = 5;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            HistoryTextBox.Clear();
            ResolutionTextBox.Text = "0";
            resolution = 0;
            action = 0;
            dot = false;
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                ResolutionTextBox.Text = Convert.ToString(-Convert.ToDouble(ResolutionTextBox.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Invalid action. Please retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (ResolutionTextBox.Text.Length == 1) ResolutionTextBox.Text = "0";
            else  ResolutionTextBox.Text = ResolutionTextBox.Text.Remove(ResolutionTextBox.Text.Length - 1);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            UseAction("+", 1);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            UseAction("-", 2);
        }

        private void buttonMyltiply_Click(object sender, EventArgs e)
        {
            UseAction("*", 3);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            UseAction("/", 4);
        }

        #endregion

        #region Progr logic
        private bool CheckActions(int act)
        {
            try
            {
                switch (act)
                {
                    case 0:
                        resolution = Convert.ToDouble(ResolutionTextBox.Text);
                        return true;
                    case 1:
                        resolution += Convert.ToDouble(ResolutionTextBox.Text);
                        return true;
                    case 2:
                        resolution -= Convert.ToDouble(ResolutionTextBox.Text);
                        return true;
                    case 3:
                        resolution *= Convert.ToDouble(ResolutionTextBox.Text);
                        return true;
                    case 4:
                        resolution /= Convert.ToDouble(ResolutionTextBox.Text);
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid action. Please retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void UseAction(String sym, int act)
        {
            if (CheckActions(act))
            { 
                HistoryTextBox.Text += Convert.ToDouble(ResolutionTextBox.Text) + sym;
                ResolutionTextBox.Text = sym;
                action = act;
                dot = false;
            }
        }

        public void CheckNums(String num)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
                    ResolutionTextBox.Text = num;
                    break;
                case "+":
                    ResolutionTextBox.Text = num;
                    break;
                case "-":
                    ResolutionTextBox.Text = num;
                    break;
                case "*":
                    ResolutionTextBox.Text = num;
                    break;
                case "/":
                    ResolutionTextBox.Text = num;
                    break;
                default:
                    if (action == 5) ResolutionTextBox.Text = num;
                    else ResolutionTextBox.Text += num;
                    action = 0;
                    break;
            }
        }

        #endregion

    }
}
