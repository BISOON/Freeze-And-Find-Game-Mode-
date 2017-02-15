namespace Game_Mode___FreezeAndFind_By_BISOON
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.formSkin1 = new theme.FormSkin();
            this.playerNum = new theme.FlatLabel();
            this.flatLabel2 = new theme.FlatLabel();
            this.endNum = new theme.FlatNumeric();
            this.flatLabel1 = new theme.FlatLabel();
            this.sINum = new theme.FlatNumeric();
            this.startBtn = new theme.FlatButton();
            this.options = new theme.FlatContextMenuStrip();
            this.fastRestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeBox = new System.Windows.Forms.ToolStripTextBox();
            this.gameCombo = new theme.FlatComboBox();
            this.flatMini1 = new theme.FlatMini();
            this.flatClose1 = new theme.FlatClose();
            this.conBtn = new theme.FlatButton();
            this.ytLbl = new System.Windows.Forms.LinkLabel();
            this.arLbl = new System.Windows.Forms.LinkLabel();
            this.formSkin1.SuspendLayout();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.arLbl);
            this.formSkin1.Controls.Add(this.ytLbl);
            this.formSkin1.Controls.Add(this.playerNum);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.endNum);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.sINum);
            this.formSkin1.Controls.Add(this.startBtn);
            this.formSkin1.Controls.Add(this.gameCombo);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.conBtn);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(391, 243);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "GM | Freeze & Find By BISOON";
            // 
            // playerNum
            // 
            this.playerNum.AutoSize = true;
            this.playerNum.BackColor = System.Drawing.Color.Transparent;
            this.playerNum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.playerNum.ForeColor = System.Drawing.Color.White;
            this.playerNum.Location = new System.Drawing.Point(3, 227);
            this.playerNum.Name = "playerNum";
            this.playerNum.Size = new System.Drawing.Size(0, 13);
            this.playerNum.TabIndex = 9;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(196, 154);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(40, 13);
            this.flatLabel2.TabIndex = 8;
            this.flatLabel2.Text = "End In";
            // 
            // endNum
            // 
            this.endNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.endNum.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.endNum.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.endNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.endNum.ForeColor = System.Drawing.Color.White;
            this.endNum.Location = new System.Drawing.Point(252, 145);
            this.endNum.Maximum = ((long)(9999999));
            this.endNum.Minimum = ((long)(0));
            this.endNum.Name = "endNum";
            this.endNum.Size = new System.Drawing.Size(103, 30);
            this.endNum.TabIndex = 7;
            this.endNum.Text = "flatNumeric1";
            this.endNum.Value = ((long)(0));
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(20, 154);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(44, 13);
            this.flatLabel1.TabIndex = 6;
            this.flatLabel1.Text = "Start In";
            // 
            // sINum
            // 
            this.sINum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.sINum.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.sINum.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.sINum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sINum.ForeColor = System.Drawing.Color.White;
            this.sINum.Location = new System.Drawing.Point(76, 145);
            this.sINum.Maximum = ((long)(9999999));
            this.sINum.Minimum = ((long)(0));
            this.sINum.Name = "sINum";
            this.sINum.Size = new System.Drawing.Size(103, 30);
            this.sINum.TabIndex = 5;
            this.sINum.Text = "flatNumeric1";
            this.sINum.Value = ((long)(0));
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.startBtn.ContextMenuStrip = this.options;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.startBtn.Location = new System.Drawing.Point(32, 190);
            this.startBtn.Name = "startBtn";
            this.startBtn.Rounded = false;
            this.startBtn.Size = new System.Drawing.Size(323, 34);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start Game Mode";
            this.startBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // options
            // 
            this.options.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.options.ForeColor = System.Drawing.Color.White;
            this.options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastRestartToolStripMenuItem,
            this.setTimeToolStripMenuItem});
            this.options.Name = "options";
            this.options.ShowImageMargin = false;
            this.options.Size = new System.Drawing.Size(110, 48);
            // 
            // fastRestartToolStripMenuItem
            // 
            this.fastRestartToolStripMenuItem.Name = "fastRestartToolStripMenuItem";
            this.fastRestartToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fastRestartToolStripMenuItem.Text = "Fast Restart";
            this.fastRestartToolStripMenuItem.Click += new System.EventHandler(this.optionClick);
            // 
            // setTimeToolStripMenuItem
            // 
            this.setTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeBox});
            this.setTimeToolStripMenuItem.Name = "setTimeToolStripMenuItem";
            this.setTimeToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.setTimeToolStripMenuItem.Text = "Set Time";
            this.setTimeToolStripMenuItem.Click += new System.EventHandler(this.optionClick);
            // 
            // timeBox
            // 
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(152, 23);
            this.timeBox.Text = "50";
            // 
            // gameCombo
            // 
            this.gameCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.gameCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameCombo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gameCombo.ForeColor = System.Drawing.Color.White;
            this.gameCombo.FormattingEnabled = true;
            this.gameCombo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.gameCombo.ItemHeight = 18;
            this.gameCombo.Items.AddRange(new object[] {
            "Advanced Warfare",
            "Ghost",
            "Black Ops II",
            "MW3",
            "Black Ops I"});
            this.gameCombo.Location = new System.Drawing.Point(57, 107);
            this.gameCombo.Name = "gameCombo";
            this.gameCombo.Size = new System.Drawing.Size(265, 24);
            this.gameCombo.TabIndex = 3;
            this.gameCombo.SelectedIndexChanged += new System.EventHandler(this.gameCombo_SelectedIndexChanged);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(346, 3);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 2;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(370, 3);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 1;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // conBtn
            // 
            this.conBtn.BackColor = System.Drawing.Color.Transparent;
            this.conBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.conBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.conBtn.Location = new System.Drawing.Point(86, 60);
            this.conBtn.Name = "conBtn";
            this.conBtn.Rounded = false;
            this.conBtn.Size = new System.Drawing.Size(208, 41);
            this.conBtn.TabIndex = 0;
            this.conBtn.Text = "Connect / Attach";
            this.conBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.conBtn.Click += new System.EventHandler(this.conBtn_Click);
            // 
            // ytLbl
            // 
            this.ytLbl.AutoSize = true;
            this.ytLbl.BackColor = System.Drawing.Color.Transparent;
            this.ytLbl.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.ytLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.ytLbl.Location = new System.Drawing.Point(344, 228);
            this.ytLbl.Name = "ytLbl";
            this.ytLbl.Size = new System.Drawing.Size(44, 12);
            this.ytLbl.TabIndex = 10;
            this.ytLbl.TabStop = true;
            this.ytLbl.Text = "YouTube";
            this.ytLbl.Click += new System.EventHandler(this.adLbl);
            // 
            // arLbl
            // 
            this.arLbl.AutoSize = true;
            this.arLbl.BackColor = System.Drawing.Color.Transparent;
            this.arLbl.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.arLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.arLbl.Location = new System.Drawing.Point(4, 227);
            this.arLbl.Name = "arLbl";
            this.arLbl.Size = new System.Drawing.Size(70, 12);
            this.arLbl.TabIndex = 11;
            this.arLbl.TabStop = true;
            this.arLbl.Text = "ArabModding";
            this.arLbl.Click += new System.EventHandler(this.adLbl);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 243);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GM | By BISOON";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.onLoad);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private theme.FormSkin formSkin1;
        private theme.FlatButton conBtn;
        private theme.FlatMini flatMini1;
        private theme.FlatClose flatClose1;
        private theme.FlatComboBox gameCombo;
        private theme.FlatButton startBtn;
        private theme.FlatLabel flatLabel1;
        private theme.FlatNumeric sINum;
        private theme.FlatContextMenuStrip options;
        private System.Windows.Forms.ToolStripMenuItem fastRestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox timeBox;
        private theme.FlatLabel flatLabel2;
        private theme.FlatNumeric endNum;
        private theme.FlatLabel playerNum;
        private System.Windows.Forms.LinkLabel arLbl;
        private System.Windows.Forms.LinkLabel ytLbl;
    }
}

