namespace WindowsFormsApplication44
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.ComboBox();
            this.autosaveTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exsitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(66, 86);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "UserName:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(66, 118);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(111, 174);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(129, 79);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 20);
            this.textUser.TabIndex = 3;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(129, 118);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(100, 20);
            this.textPass.TabIndex = 4;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // save
            // 
            this.save.FormattingEnabled = true;
            this.save.Items.AddRange(new object[] {
            "Save"});
            this.save.Location = new System.Drawing.Point(1, 62);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(121, 21);
            this.save.TabIndex = 5;
            this.save.SelectedIndexChanged += new System.EventHandler(this.combSave_SelectedIndexChanged);
            // 
            // autosaveTimer
            // 
            this.autosaveTimer.Enabled = true;
            this.autosaveTimer.Interval = 30000;
            this.autosaveTimer.Tick += new System.EventHandler(this.autosaveTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fieToolStripMenuItem
            // 
            this.fieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.SaveToFile,
            this.exsitToolStripMenuItem});
            this.fieToolStripMenuItem.Name = "fieToolStripMenuItem";
            this.fieToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fieToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveToFile
            // 
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToFile.Size = new System.Drawing.Size(146, 22);
            this.SaveToFile.Text = "Save";
            this.SaveToFile.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exsitToolStripMenuItem
            // 
            this.exsitToolStripMenuItem.Name = "exsitToolStripMenuItem";
            this.exsitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exsitToolStripMenuItem.Text = "Exsit";
            this.exsitToolStripMenuItem.Click += new System.EventHandler(this.exsitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.ComboBox save;
        private System.Windows.Forms.Timer autosaveTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToFile;
        private System.Windows.Forms.ToolStripMenuItem exsitToolStripMenuItem;
    }
}

