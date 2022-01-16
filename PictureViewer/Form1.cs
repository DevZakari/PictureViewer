using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // show the open File dialog to the user for choosing the picture : if it's choosen then the result is OK; then we load it;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the picture
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // show the color dialog to the user for choosing color of background if the result is Ok : so change the BG:
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // close the form : 
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            // checkbox for the SizeMode : 
            // if it's Stretch so checked is true else it's normal :
            if(checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
