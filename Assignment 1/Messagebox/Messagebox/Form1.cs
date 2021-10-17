using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messagebox
{
    public partial class instructionManual : Form
    {
        public instructionManual()
        {
            InitializeComponent();
        }

        private void nameCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (nameCheck.Checked == false & yearCheck.Checked == false &
                     courseCheck.Checked == false)
            {
                nameCheck.Checked = true;
            }

            if (nameCheck.Checked == true)
            {
                yearCheck.Checked = false;
                courseCheck.Checked = false;
            }
        }

        private void yearCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (nameCheck.Checked == false & yearCheck.Checked == false &
                 courseCheck.Checked == false)
            {
                yearCheck.Checked = true;
            }

            if (yearCheck.Checked == true)
            {
                nameCheck.Checked = false;
                courseCheck.Checked = false;
            }
        }

        private void courseCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (nameCheck.Checked == false & yearCheck.Checked == false
                & courseCheck.Checked == false)
            {
                courseCheck.Checked = true;
            }

            if (courseCheck.Checked == true)
            {
                nameCheck.Checked = false;
                yearCheck.Checked = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(nameCheck.Checked == true)
            {
                MessageBox.Show("Johndell S. Kitts", "Full Name");
            }
            if(yearCheck.Checked == true)
            {
                MessageBox.Show("5th year", "Year Level");
            }
            if(courseCheck.Checked == true)
            {
                MessageBox.Show("Bachelor of Science in Computer Engineering", "Course");
            }
        }
    }
}
