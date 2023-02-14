namespace BoF2Editor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonsterList = new System.Windows.Forms.ComboBox();
            this.numMonsterAtk = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMonsterHp = new System.Windows.Forms.NumericUpDown();
            this.numMonsterExp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileOpenRom = new System.Windows.Forms.OpenFileDialog();
            this.numMonsterDef = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numMonsterMp = new System.Windows.Forms.NumericUpDown();
            this.numMonsterAgi = new System.Windows.Forms.NumericUpDown();
            this.numMonsterLuk = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numMonsterZenny = new System.Windows.Forms.NumericUpDown();
            this.numMonsterDropRate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMonsterBytes = new System.Windows.Forms.TextBox();
            this.btnMonsterTwiceExp = new System.Windows.Forms.Button();
            this.btnMonsterTwiceZenny = new System.Windows.Forms.Button();
            this.numMonsterItemSet = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterAtk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterMp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterAgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterLuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterZenny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterDropRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterItemSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monster:";
            // 
            // cbMonsterList
            // 
            this.cbMonsterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonsterList.Location = new System.Drawing.Point(66, 39);
            this.cbMonsterList.Name = "cbMonsterList";
            this.cbMonsterList.Size = new System.Drawing.Size(274, 21);
            this.cbMonsterList.TabIndex = 2;
            this.cbMonsterList.SelectedIndexChanged += new System.EventHandler(this.cbMonsterList_SelectedIndexChanged);
            // 
            // numMonsterAtk
            // 
            this.numMonsterAtk.Location = new System.Drawing.Point(66, 161);
            this.numMonsterAtk.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numMonsterAtk.Name = "numMonsterAtk";
            this.numMonsterAtk.Size = new System.Drawing.Size(67, 20);
            this.numMonsterAtk.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attack:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "HP:";
            // 
            // numMonsterHp
            // 
            this.numMonsterHp.Location = new System.Drawing.Point(66, 135);
            this.numMonsterHp.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numMonsterHp.Name = "numMonsterHp";
            this.numMonsterHp.Size = new System.Drawing.Size(67, 20);
            this.numMonsterHp.TabIndex = 6;
            // 
            // numMonsterExp
            // 
            this.numMonsterExp.Location = new System.Drawing.Point(66, 213);
            this.numMonsterExp.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numMonsterExp.Name = "numMonsterExp";
            this.numMonsterExp.Size = new System.Drawing.Size(67, 20);
            this.numMonsterExp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exp:";
            // 
            // openFileOpenRom
            // 
            this.openFileOpenRom.FileName = "openFileDialog1";
            // 
            // numMonsterDef
            // 
            this.numMonsterDef.Location = new System.Drawing.Point(280, 161);
            this.numMonsterDef.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numMonsterDef.Name = "numMonsterDef";
            this.numMonsterDef.Size = new System.Drawing.Size(67, 20);
            this.numMonsterDef.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MP:";
            // 
            // numMonsterMp
            // 
            this.numMonsterMp.Location = new System.Drawing.Point(280, 135);
            this.numMonsterMp.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numMonsterMp.Name = "numMonsterMp";
            this.numMonsterMp.Size = new System.Drawing.Size(67, 20);
            this.numMonsterMp.TabIndex = 11;
            // 
            // numMonsterAgi
            // 
            this.numMonsterAgi.Location = new System.Drawing.Point(66, 187);
            this.numMonsterAgi.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numMonsterAgi.Name = "numMonsterAgi";
            this.numMonsterAgi.Size = new System.Drawing.Size(67, 20);
            this.numMonsterAgi.TabIndex = 12;
            // 
            // numMonsterLuk
            // 
            this.numMonsterLuk.Location = new System.Drawing.Point(280, 187);
            this.numMonsterLuk.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numMonsterLuk.Name = "numMonsterLuk";
            this.numMonsterLuk.Size = new System.Drawing.Size(67, 20);
            this.numMonsterLuk.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Defense:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Luck:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Agility:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Zenny:";
            // 
            // numMonsterZenny
            // 
            this.numMonsterZenny.Location = new System.Drawing.Point(280, 213);
            this.numMonsterZenny.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numMonsterZenny.Name = "numMonsterZenny";
            this.numMonsterZenny.Size = new System.Drawing.Size(67, 20);
            this.numMonsterZenny.TabIndex = 18;
            // 
            // numMonsterDropRate
            // 
            this.numMonsterDropRate.Location = new System.Drawing.Point(66, 259);
            this.numMonsterDropRate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numMonsterDropRate.Name = "numMonsterDropRate";
            this.numMonsterDropRate.Size = new System.Drawing.Size(67, 20);
            this.numMonsterDropRate.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Drop rate:";
            // 
            // txtMonsterBytes
            // 
            this.txtMonsterBytes.Location = new System.Drawing.Point(15, 79);
            this.txtMonsterBytes.Name = "txtMonsterBytes";
            this.txtMonsterBytes.ReadOnly = true;
            this.txtMonsterBytes.Size = new System.Drawing.Size(325, 20);
            this.txtMonsterBytes.TabIndex = 22;
            // 
            // btnMonsterTwiceExp
            // 
            this.btnMonsterTwiceExp.Location = new System.Drawing.Point(15, 318);
            this.btnMonsterTwiceExp.Name = "btnMonsterTwiceExp";
            this.btnMonsterTwiceExp.Size = new System.Drawing.Size(163, 23);
            this.btnMonsterTwiceExp.TabIndex = 23;
            this.btnMonsterTwiceExp.Text = "Double Enemies\' EXP";
            this.btnMonsterTwiceExp.UseVisualStyleBackColor = true;
            this.btnMonsterTwiceExp.Click += new System.EventHandler(this.btnMonsterTwiceExp_Click);
            // 
            // btnMonsterTwiceZenny
            // 
            this.btnMonsterTwiceZenny.Location = new System.Drawing.Point(184, 318);
            this.btnMonsterTwiceZenny.Name = "btnMonsterTwiceZenny";
            this.btnMonsterTwiceZenny.Size = new System.Drawing.Size(163, 23);
            this.btnMonsterTwiceZenny.TabIndex = 24;
            this.btnMonsterTwiceZenny.Text = "Double Enemies\' Zenny";
            this.btnMonsterTwiceZenny.UseVisualStyleBackColor = true;
            this.btnMonsterTwiceZenny.Click += new System.EventHandler(this.btnMonsterTwiceZenny_Click);
            // 
            // numMonsterItemSet
            // 
            this.numMonsterItemSet.Location = new System.Drawing.Point(280, 259);
            this.numMonsterItemSet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numMonsterItemSet.Name = "numMonsterItemSet";
            this.numMonsterItemSet.Size = new System.Drawing.Size(67, 20);
            this.numMonsterItemSet.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Item set:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(336, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "For more information on how item drops and item sets work, check out";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 384);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 13);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ben Siron\'s BoF2 Handbook";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 417);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numMonsterItemSet);
            this.Controls.Add(this.btnMonsterTwiceZenny);
            this.Controls.Add(this.btnMonsterTwiceExp);
            this.Controls.Add(this.txtMonsterBytes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numMonsterDropRate);
            this.Controls.Add(this.numMonsterZenny);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numMonsterLuk);
            this.Controls.Add(this.numMonsterAgi);
            this.Controls.Add(this.numMonsterMp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numMonsterDef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMonsterExp);
            this.Controls.Add(this.numMonsterHp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMonsterAtk);
            this.Controls.Add(this.cbMonsterList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BoF 2 Monster Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterAtk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterMp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterAgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterLuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterZenny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterDropRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonsterItemSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonsterList;
        private System.Windows.Forms.NumericUpDown numMonsterAtk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMonsterHp;
        private System.Windows.Forms.NumericUpDown numMonsterExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileOpenRom;
        private System.Windows.Forms.NumericUpDown numMonsterDef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMonsterMp;
        private System.Windows.Forms.NumericUpDown numMonsterAgi;
        private System.Windows.Forms.NumericUpDown numMonsterLuk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMonsterZenny;
        private System.Windows.Forms.NumericUpDown numMonsterDropRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMonsterBytes;
        private System.Windows.Forms.Button btnMonsterTwiceExp;
        private System.Windows.Forms.Button btnMonsterTwiceZenny;
        private System.Windows.Forms.NumericUpDown numMonsterItemSet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}