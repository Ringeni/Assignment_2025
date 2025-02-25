using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double num1, num2, res = 0;
            if (double.TryParse(numText1.Text, out num1) && double.TryParse(numText2.Text, out num2) && option.SelectedIndex != -1)
            {
                bool invalid = false;
                switch (option.SelectedIndex)
                {
                    case 0: res = num1 + num2; break;
                    case 1: res = num1 - num2; break;
                    case 2: res = num1 * num2; break;
                    case 3:
                        {
                            if (num2 != 0) res = num1 / num2;
                            else invalid = true;
                        }
                        break;
                    default: break;
                }
                if (!invalid)
                {
                    string v = res.ToString();
                    result.Text = v;
                }
                else
                {
                    result.Text = "invalid:divided by 0.";
                }
            }
        }
    }
}
