using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;

namespace wowow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create and configure the rounded panel
            RoundedPanel roundedPanel = new RoundedPanel
            {
                Size = new Size(300, 200),
                Location = new Point(50, 50),
                BackColor = Color.White,
                CornerRadius = 30 // Adjust the corner radius
            };

            // Add the rounded panel to the form
            this.Controls.Add(roundedPanel);


        }

        private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void RoundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void RoundedButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void RoundedButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
