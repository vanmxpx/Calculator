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

        /*public event EventHandler Button0Click;
        public event EventHandler Button1Click;
        public event EventHandler Button2Click;
        public event EventHandler Button3Click;
        public event EventHandler Button4Click;
        public event EventHandler Button5Click;
        public event EventHandler Button6Click;
        public event EventHandler Button7Click;
        public event EventHandler Button8Click;
        public event EventHandler Button9Click;
        public event EventHandler ButtonPlusMinusClick;
        public event EventHandler ButtonDotClick;
        public event EventHandler ButtonMultClick;
        public event EventHandler ButtonDivClick;
        public event EventHandler ButtonPlusClick;
        public event EventHandler ButtonMinusClick;
        public event EventHandler ButtonResolClick;
        public event EventHandler ButtonBSClick;
        public event EventHandler ButtonDelClick;*/




        private void button1_Click(object sender, EventArgs e)
        {
            switch (ResolutionTextBox.Text)
            {
                case "0":
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
                default:
                    ResolutionTextBox.Text += "0";
                    break;
            }
        }

    }
}
