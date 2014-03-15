namespace DiceRoller
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
            this.labelLowercaseD = new System.Windows.Forms.Label();
            this.labelPlusSign = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxValues = new System.Windows.Forms.TextBox();
            this.numericUpDownNumOfRolls = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOptionalConstant = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelNumOfRolls = new System.Windows.Forms.Label();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.labelOptionalConstant = new System.Windows.Forms.Label();
            this.labelPlus = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelValues = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfRolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOptionalConstant)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLowercaseD
            // 
            this.labelLowercaseD.AutoSize = true;
            this.labelLowercaseD.Location = new System.Drawing.Point(138, 95);
            this.labelLowercaseD.Name = "labelLowercaseD";
            this.labelLowercaseD.Size = new System.Drawing.Size(13, 13);
            this.labelLowercaseD.TabIndex = 7;
            this.labelLowercaseD.Text = "d";
            // 
            // labelPlusSign
            // 
            this.labelPlusSign.AutoSize = true;
            this.labelPlusSign.Location = new System.Drawing.Point(243, 103);
            this.labelPlusSign.Name = "labelPlusSign";
            this.labelPlusSign.Size = new System.Drawing.Size(13, 13);
            this.labelPlusSign.TabIndex = 8;
            this.labelPlusSign.Text = "+";
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(12, 142);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 4;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(137, 185);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 6;
            // 
            // textBoxValues
            // 
            this.textBoxValues.Enabled = false;
            this.textBoxValues.Location = new System.Drawing.Point(12, 184);
            this.textBoxValues.Multiline = true;
            this.textBoxValues.Name = "textBoxValues";
            this.textBoxValues.Size = new System.Drawing.Size(100, 145);
            this.textBoxValues.TabIndex = 5;
            // 
            // numericUpDownNumOfRolls
            // 
            this.numericUpDownNumOfRolls.Location = new System.Drawing.Point(12, 51);
            this.numericUpDownNumOfRolls.Name = "numericUpDownNumOfRolls";
            this.numericUpDownNumOfRolls.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumOfRolls.TabIndex = 9;
            this.numericUpDownNumOfRolls.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMinValue
            // 
            this.numericUpDownMinValue.Location = new System.Drawing.Point(12, 93);
            this.numericUpDownMinValue.Name = "numericUpDownMinValue";
            this.numericUpDownMinValue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinValue.TabIndex = 10;
            this.numericUpDownMinValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMaxValue
            // 
            this.numericUpDownMaxValue.Location = new System.Drawing.Point(157, 93);
            this.numericUpDownMaxValue.Name = "numericUpDownMaxValue";
            this.numericUpDownMaxValue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxValue.TabIndex = 11;
            this.numericUpDownMaxValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDownOptionalConstant
            // 
            this.numericUpDownOptionalConstant.Location = new System.Drawing.Point(302, 93);
            this.numericUpDownOptionalConstant.Name = "numericUpDownOptionalConstant";
            this.numericUpDownOptionalConstant.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownOptionalConstant.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(440, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // labelNumOfRolls
            // 
            this.labelNumOfRolls.AutoSize = true;
            this.labelNumOfRolls.Location = new System.Drawing.Point(13, 32);
            this.labelNumOfRolls.Name = "labelNumOfRolls";
            this.labelNumOfRolls.Size = new System.Drawing.Size(65, 13);
            this.labelNumOfRolls.TabIndex = 14;
            this.labelNumOfRolls.Text = "Num. of rolls";
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Location = new System.Drawing.Point(12, 77);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(56, 13);
            this.labelMinValue.TabIndex = 15;
            this.labelMinValue.Text = "Min. value";
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Location = new System.Drawing.Point(154, 77);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(59, 13);
            this.labelMaxValue.TabIndex = 16;
            this.labelMaxValue.Text = "Max. value";
            // 
            // labelOptionalConstant
            // 
            this.labelOptionalConstant.AutoSize = true;
            this.labelOptionalConstant.Location = new System.Drawing.Point(305, 77);
            this.labelOptionalConstant.Name = "labelOptionalConstant";
            this.labelOptionalConstant.Size = new System.Drawing.Size(90, 13);
            this.labelOptionalConstant.TabIndex = 17;
            this.labelOptionalConstant.Text = "Optional constant";
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Location = new System.Drawing.Point(283, 95);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(13, 13);
            this.labelPlus.TabIndex = 18;
            this.labelPlus.Text = "+";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(138, 169);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 19;
            this.labelTotal.Text = "Total";
            // 
            // labelValues
            // 
            this.labelValues.AutoSize = true;
            this.labelValues.Location = new System.Drawing.Point(13, 169);
            this.labelValues.Name = "labelValues";
            this.labelValues.Size = new System.Drawing.Size(39, 13);
            this.labelValues.TabIndex = 20;
            this.labelValues.Text = "Values";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.saveDefaultToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDefaultToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "saveDefaultToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "Save Default";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.saveDefaultToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.saveDefaultToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.saveDefaultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveDefaultToolStripMenuItem.Text = "Exit Program";
            this.saveDefaultToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 362);
            this.Controls.Add(this.labelValues);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.labelOptionalConstant);
            this.Controls.Add(this.labelMaxValue);
            this.Controls.Add(this.labelMinValue);
            this.Controls.Add(this.labelNumOfRolls);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.numericUpDownOptionalConstant);
            this.Controls.Add(this.numericUpDownMaxValue);
            this.Controls.Add(this.numericUpDownMinValue);
            this.Controls.Add(this.numericUpDownNumOfRolls);
            this.Controls.Add(this.textBoxValues);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.labelPlusSign);
            this.Controls.Add(this.labelLowercaseD);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DiceRoller";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfRolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOptionalConstant)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLowercaseD;
        private System.Windows.Forms.Label labelPlusSign;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxValues;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfRolls;
        private System.Windows.Forms.NumericUpDown numericUpDownMinValue;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxValue;
        private System.Windows.Forms.NumericUpDown numericUpDownOptionalConstant;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelNumOfRolls;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.Label labelOptionalConstant;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelValues;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

