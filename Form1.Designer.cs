
namespace Lab5DhruvP
{
    partial class FormEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileMenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelpMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toolStripEdit,
            this.toolStripHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(876, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFileMenuNew,
            this.toolStripFileMenuOpen,
            this.toolStripFileMenuSave,
            this.toolStripFileMenuSaveAs,
            this.toolStripFileMenuClose,
            this.toolStripFileMenuExit});
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(46, 24);
            this.toolStripFile.Text = "&File";
            // 
            // toolStripFileMenuNew
            // 
            this.toolStripFileMenuNew.Name = "toolStripFileMenuNew";
            this.toolStripFileMenuNew.Size = new System.Drawing.Size(184, 26);
            this.toolStripFileMenuNew.Text = "New   Ctrl+N";
            this.toolStripFileMenuNew.Click += new System.EventHandler(this.toolStripFileMenuNew_Click);
            // 
            // toolStripFileMenuOpen
            // 
            this.toolStripFileMenuOpen.Name = "toolStripFileMenuOpen";
            this.toolStripFileMenuOpen.Size = new System.Drawing.Size(184, 26);
            this.toolStripFileMenuOpen.Text = "Open   Ctrl+O";
            this.toolStripFileMenuOpen.Click += new System.EventHandler(this.toolStripFileMenuOpen_Click);
            // 
            // toolStripFileMenuSave
            // 
            this.toolStripFileMenuSave.Name = "toolStripFileMenuSave";
            this.toolStripFileMenuSave.Size = new System.Drawing.Size(184, 26);
            this.toolStripFileMenuSave.Text = "Save   Ctrl+S";
            this.toolStripFileMenuSave.Click += new System.EventHandler(this.toolStripFileMenuSave_Click);
            // 
            // toolStripFileMenuSaveAs
            // 
            this.toolStripFileMenuSaveAs.Name = "toolStripFileMenuSaveAs";
            this.toolStripFileMenuSaveAs.Size = new System.Drawing.Size(184, 26);
            this.toolStripFileMenuSaveAs.Text = "Save As";
            this.toolStripFileMenuSaveAs.Click += new System.EventHandler(this.toolStripFileMenuSaveAs_Click);
            // 
            // toolStripFileMenuClose
            // 
            this.toolStripFileMenuClose.Name = "toolStripFileMenuClose";
            this.toolStripFileMenuClose.Size = new System.Drawing.Size(184, 26);
            this.toolStripFileMenuClose.Text = "Close";
            this.toolStripFileMenuClose.Click += new System.EventHandler(this.toolStripFileMenuClose_Click);
            // 
            // toolStripFileMenuExit
            // 
            this.toolStripFileMenuExit.Name = "toolStripFileMenuExit";
            this.toolStripFileMenuExit.Size = new System.Drawing.Size(184, 26);
            this.toolStripFileMenuExit.Text = "Exit";
            this.toolStripFileMenuExit.Click += new System.EventHandler(this.toolStripFileMenuExit_Click);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditMenuCopy,
            this.toolStripEditMenuCut,
            this.toolStripEditMenuPaste});
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(49, 24);
            this.toolStripEdit.Text = "&Edit";
            // 
            // toolStripEditMenuCopy
            // 
            this.toolStripEditMenuCopy.Name = "toolStripEditMenuCopy";
            this.toolStripEditMenuCopy.Size = new System.Drawing.Size(180, 26);
            this.toolStripEditMenuCopy.Text = "Copy   Ctrl+C";
            this.toolStripEditMenuCopy.Click += new System.EventHandler(this.toolStripEditMenuCopy_Click);
            // 
            // toolStripEditMenuCut
            // 
            this.toolStripEditMenuCut.Name = "toolStripEditMenuCut";
            this.toolStripEditMenuCut.Size = new System.Drawing.Size(180, 26);
            this.toolStripEditMenuCut.Text = "Cut   Ctrl+X";
            this.toolStripEditMenuCut.Click += new System.EventHandler(this.toolStripFileMenuCut_Click);
            // 
            // toolStripEditMenuPaste
            // 
            this.toolStripEditMenuPaste.Name = "toolStripEditMenuPaste";
            this.toolStripEditMenuPaste.Size = new System.Drawing.Size(180, 26);
            this.toolStripEditMenuPaste.Text = "Paste   Ctrl+V";
            this.toolStripEditMenuPaste.Click += new System.EventHandler(this.toolStripFileMenuPaste_Click);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripHelpMenuAbout});
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(55, 24);
            this.toolStripHelp.Text = "&Help";
            // 
            // toolStripHelpMenuAbout
            // 
            this.toolStripHelpMenuAbout.Name = "toolStripHelpMenuAbout";
            this.toolStripHelpMenuAbout.Size = new System.Drawing.Size(133, 26);
            this.toolStripHelpMenuAbout.Text = "About";
            this.toolStripHelpMenuAbout.Click += new System.EventHandler(this.toolStripHelpMenuAbout_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Location = new System.Drawing.Point(0, 31);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMain.Size = new System.Drawing.Size(876, 466);
            this.textBoxMain.TabIndex = 1;
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 498);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor Select a File to Open";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripFileMenuNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripFileMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripFileMenuSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripFileMenuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStripFileMenuClose;
        private System.Windows.Forms.ToolStripMenuItem toolStripFileMenuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditMenuCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditMenuPaste;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelpMenuAbout;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

