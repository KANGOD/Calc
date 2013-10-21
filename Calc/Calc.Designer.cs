namespace Calc
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StandardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonChangeSign = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.buttonPercentage = new System.Windows.Forms.Button();
            this.buttonReciprocal = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(224, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StandardToolStripMenuItem,
            this.ScientificToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ViewToolStripMenuItem.Text = "查看";
            // 
            // StandardToolStripMenuItem
            // 
            this.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem";
            this.StandardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.StandardToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.StandardToolStripMenuItem.Text = "标准";
            // 
            // ScientificToolStripMenuItem
            // 
            this.ScientificToolStripMenuItem.Enabled = false;
            this.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem";
            this.ScientificToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.ScientificToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ScientificToolStripMenuItem.Text = "科学";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.EditToolStripMenuItem.Text = "编辑";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.CopyToolStripMenuItem.Text = "复制";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.PasteToolStripMenuItem.Text = "粘贴";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewHelpToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // ViewHelpToolStripMenuItem
            // 
            this.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem";
            this.ViewHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ViewHelpToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ViewHelpToolStripMenuItem.Text = "查看帮助";
            this.ViewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.AboutToolStripMenuItem.Text = "关于计算器";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(54, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(95, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(54, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(95, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(13, 113);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 30);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(54, 113);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 30);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(95, 113);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 30);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(13, 221);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(76, 30);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(95, 221);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(35, 30);
            this.buttonDot.TabIndex = 12;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(136, 221);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(35, 30);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(136, 185);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(35, 30);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(136, 149);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(35, 30);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(136, 113);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(35, 30);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(177, 185);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(35, 66);
            this.buttonResult.TabIndex = 17;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackspace.Location = new System.Drawing.Point(13, 77);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(35, 30);
            this.buttonBackspace.TabIndex = 18;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEntry.Location = new System.Drawing.Point(54, 77);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(35, 30);
            this.buttonClearEntry.TabIndex = 19;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = true;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(95, 77);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(35, 30);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChangeSign
            // 
            this.buttonChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeSign.Location = new System.Drawing.Point(136, 77);
            this.buttonChangeSign.Name = "buttonChangeSign";
            this.buttonChangeSign.Size = new System.Drawing.Size(35, 30);
            this.buttonChangeSign.TabIndex = 21;
            this.buttonChangeSign.Text = "+/-";
            this.buttonChangeSign.UseVisualStyleBackColor = true;
            this.buttonChangeSign.Click += new System.EventHandler(this.buttonChangeSign_Click);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquareRoot.Location = new System.Drawing.Point(177, 77);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(35, 30);
            this.buttonSquareRoot.TabIndex = 22;
            this.buttonSquareRoot.Text = "√";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            this.buttonSquareRoot.Click += new System.EventHandler(this.buttonSquareRoot_Click);
            // 
            // buttonPercentage
            // 
            this.buttonPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercentage.Location = new System.Drawing.Point(177, 113);
            this.buttonPercentage.Name = "buttonPercentage";
            this.buttonPercentage.Size = new System.Drawing.Size(35, 30);
            this.buttonPercentage.TabIndex = 23;
            this.buttonPercentage.Text = "%";
            this.buttonPercentage.UseVisualStyleBackColor = true;
            this.buttonPercentage.Click += new System.EventHandler(this.buttonPercentage_Click);
            // 
            // buttonReciprocal
            // 
            this.buttonReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReciprocal.Location = new System.Drawing.Point(177, 149);
            this.buttonReciprocal.Name = "buttonReciprocal";
            this.buttonReciprocal.Size = new System.Drawing.Size(35, 30);
            this.buttonReciprocal.TabIndex = 24;
            this.buttonReciprocal.Text = "1/x";
            this.buttonReciprocal.UseVisualStyleBackColor = true;
            this.buttonReciprocal.Click += new System.EventHandler(this.buttonReciprocal_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.SystemColors.Window;
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.displayLabel.Location = new System.Drawing.Point(13, 36);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(199, 26);
            this.displayLabel.TabIndex = 25;
            this.displayLabel.Text = "0";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 262);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.buttonReciprocal);
            this.Controls.Add(this.buttonPercentage);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.buttonChangeSign);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainForm_KeyPress);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StandardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonChangeSign;
        private System.Windows.Forms.Button buttonSquareRoot;
        private System.Windows.Forms.Button buttonPercentage;
        private System.Windows.Forms.Button buttonReciprocal;
        private System.Windows.Forms.Label displayLabel;

    }
}

