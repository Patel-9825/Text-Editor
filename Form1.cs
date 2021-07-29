/* 
 * Author: Dhruv Patel
 * Date: July 29, 2021
 * Title: Lab 5 for NETD class.
 * Description: This lab is based on text editor which is made with putting all basic components which are used in Menu bar of any editor.
 *              Every menu item has click event defined and coding is done based on different events and performs different tasks.
 * */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab5DhruvP
{
    public partial class FormEditor : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        public FormEditor()
        {
            InitializeComponent();
        }

        #region Events of Menu Strip
        private void toolStripFileMenuNew_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.textBoxMain.Text))
            {
                if(MessageBox.Show("You sure you want to open new file?","Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.textBoxMain.Text = string.Empty;
                    this.Text = "";
                }
            }
            else
            {
                this.textBoxMain.Text = string.Empty;
                this.Text = "";
            }
        }

        private void toolStripFileMenuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxMain.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void toolStripFileMenuSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxMain.Text))
            {
                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|DOCX Files (*.docx)|*.docx|Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, this.textBoxMain.Text);
                    this.Text = saveFileDialog.FileName;
                }
            }
            else
            {
                MessageBox.Show("Oops! Error Occurred.");
            }
        }

        private void toolStripFileMenuSaveAs_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxMain.Text))
            {
                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|DOCX Files (*.docx)|*.docx|Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, this.textBoxMain.Text);
                    this.Text = saveFileDialog.FileName;
                }
            }
            else
            {
                MessageBox.Show("Oops! Error Occurred.");
            }
        }

        private void toolStripFileMenuClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The changes you have made to this file have not been saved. Are You sure you want to exit without saving?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripFileMenuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The changes you have made to this file have not been saved. Are You sure you want to exit without saving?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripEditMenuCopy_Click(object sender, EventArgs e)
        {
            textBoxMain.Copy();
        }

        private void toolStripFileMenuCut_Click(object sender, EventArgs e)
        {
            textBoxMain.Cut();
        }

        private void toolStripFileMenuPaste_Click(object sender, EventArgs e)
        {
            textBoxMain.Paste();
        }

        private void toolStripHelpMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NETD-2202\r\n Lab #5\r\n Dhruv Patel","About");
        }

        #endregion

        private void OpenFile()
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {
            if(textBoxMain.Text.Length > 0)
            {
                toolStripEditMenuCut.Enabled = true;
                toolStripEditMenuCopy.Enabled = true;
            }
            else
            {
                toolStripEditMenuCut.Enabled = false;
                toolStripEditMenuCopy.Enabled = false;
            }
        }
    }
}
