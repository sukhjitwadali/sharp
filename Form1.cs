using System;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the button click Event
        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }
    }
}
