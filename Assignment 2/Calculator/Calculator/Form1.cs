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
    public partial class Form1 : Form
    {
        public bool needChange = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void angleButton_Click(object sender, EventArgs e)
        {
            if (angleButton.Text == "DEG")
            {
                angleButton.Text = "RAD";
            }
            else if (angleButton.Text == "RAD")
            {
                angleButton.Text = "GRAD";
            }
            else
            {
                angleButton.Text = "DEG";
            }
        }

        private void changeTrigoButton_Click(object sender, EventArgs e)
        {
            //change trigometry buttons and others
            if (needChange)
            {
                Button[] buttons = new Button[] {sinButton, cosButton, tanButton,
                secButton, scsButton, cotButton};
                string[] buttonsName = new string[] {"sin", "cos", "tan",
                "sec", "scs", "cot"};
                var buttonsAndName = buttons.Zip(buttonsName, (t, n) =>
                    new { ButtonsObj = t, ButtonNames = n });
                foreach (var x in buttonsAndName)
                {
                    x.ButtonsObj.Image = null;
                    x.ButtonsObj.Text = x.ButtonNames;
                }

                buttons = new Button[]
                {
                    xSquaredButton, squareRootButton, exponentButton, exponentialTen,
                    logButton, lnButton
                };
                buttonsName = new string[]
                {
                    "x^2", "2√x", "x^y", "10^x", "log", "ln"
                };
                buttonsAndName = buttons.Zip(buttonsName, (t, n) =>
                    new { ButtonsObj = t, ButtonNames = n });
                foreach (var x in buttonsAndName)
                {
                    x.ButtonsObj.Text = x.ButtonNames;
                }

                needChange = false;
            }
            else
            {
                Button[] buttons = new Button[] {sinButton, cosButton, tanButton,
                secButton, scsButton, cotButton};
                string[] buttonsName = new string[] {"arcsin.png", "arccos.png", "arctan.png",
                "arcsec.png", "arcscs.png", "arccot.png"};
                var buttonsAndName = buttons.Zip(buttonsName, (t, n) =>
                    new { ButtonsObj = t, ButtonNames = n });
                foreach (var x in buttonsAndName)
                {
                    x.ButtonsObj.Text = null;
                    x.ButtonsObj.Image = Image.FromFile("data/image/" + x.ButtonNames);
                }

                buttons = new Button[]
                {
                    xSquaredButton, squareRootButton, exponentButton, exponentialTen,
                    logButton, lnButton
                };
                buttonsName = new string[]
                {
                    "x^3", "3√x", "y√x", "2^x", "logx^y", "e^x"
                };
                buttonsAndName = buttons.Zip(buttonsName, (t, n) =>
                    new { ButtonsObj = t, ButtonNames = n });
                foreach (var x in buttonsAndName)
                {
                    x.ButtonsObj.Text = x.ButtonNames;
                }

                needChange = true;
            }
        }
    }
}
