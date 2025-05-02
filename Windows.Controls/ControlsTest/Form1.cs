using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Controls;
using static Windows.Controls.WinApi;

namespace ControlsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void editControl1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            editControl1.HideBalloonTip();

            if (editControl1.Text == "")
                editControl1.ShowBalloonTip("Search", "Enter a search string", Windows.Controls.EditBallonTipIcons.Error);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskDialogResults result = TaskDialog.ShowMessage(this.Handle, "Test message", "This is a Task Dialog.", "Hello world!", TaskDialogButtons.Yes | TaskDialogButtons.No, TaskDialogIcons.Warning);

            labelTdResult.Text = string.Format("Task Dialog Result: {0:G}", result);
        }

        private void searchBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                if(searchBox1.Text == "")
                {
                    searchBox1.ShowBalloonTip("Search", "Please enter a search string.", EditBallonTipIcons.Error);
                    return;
                }

                MessageBox.Show("Searching...");
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.State = Windows.Controls.ProgressBar.States.Normal;
            splitButton2.Text = "Normal";
        }

        private void errorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.State = Windows.Controls.ProgressBar.States.Error;
            splitButton2.Text = "Error";
        }

        private void pausedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.State = Windows.Controls.ProgressBar.States.Paused;
            splitButton2.Text = "Paused";
        }

        private void splitButton2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            progressBar1.Value = random.Next(0, 100);
        }

        private void contextMenuStripProgressBar_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
