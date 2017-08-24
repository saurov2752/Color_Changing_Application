using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChange
{
    public partial class ColorChangeUI : Form
    {
        public ColorChangeUI()
        {
            InitializeComponent();
        }
        
        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blueRadioButton.Checked)
            {
                panel.BackColor = Color.Blue;
            }
            else panel.BackColor = Color.Black;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton.Checked)
            {
                panel.BackColor = Color.Red;
            }
            else panel.BackColor = Color.Black;
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (greenRadioButton.Checked)
            {
                panel.BackColor = Color.Green;
            }
            else panel.BackColor = Color.Black;
        }
    }
}
