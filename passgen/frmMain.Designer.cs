namespace passgen
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.chkUppers = new System.Windows.Forms.CheckBox();
            this.chkLowers = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.tbxPasses = new System.Windows.Forms.TextBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.ttTexts = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(108, 9);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(65, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numCount
            // 
            this.numCount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCount.Location = new System.Drawing.Point(12, 12);
            this.numCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(42, 20);
            this.numCount.TabIndex = 1;
            this.ttTexts.SetToolTip(this.numCount, "How many passes should be generated?");
            this.numCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chkUppers
            // 
            this.chkUppers.AutoSize = true;
            this.chkUppers.Checked = true;
            this.chkUppers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppers.Location = new System.Drawing.Point(179, 13);
            this.chkUppers.Name = "chkUppers";
            this.chkUppers.Size = new System.Drawing.Size(33, 17);
            this.chkUppers.TabIndex = 2;
            this.chkUppers.Text = "A";
            this.ttTexts.SetToolTip(this.chkUppers, "Upper letters included?");
            this.chkUppers.UseVisualStyleBackColor = true;
            // 
            // chkLowers
            // 
            this.chkLowers.AutoSize = true;
            this.chkLowers.Checked = true;
            this.chkLowers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowers.Location = new System.Drawing.Point(218, 13);
            this.chkLowers.Name = "chkLowers";
            this.chkLowers.Size = new System.Drawing.Size(32, 17);
            this.chkLowers.TabIndex = 3;
            this.chkLowers.Text = "a";
            this.ttTexts.SetToolTip(this.chkLowers, "Lower letters included?");
            this.chkLowers.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.Checked = true;
            this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumbers.Location = new System.Drawing.Point(256, 13);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(32, 17);
            this.chkNumbers.TabIndex = 4;
            this.chkNumbers.Text = "1";
            this.ttTexts.SetToolTip(this.chkNumbers, "Numbers included?");
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Checked = true;
            this.chkSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSymbols.Location = new System.Drawing.Point(294, 13);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(37, 17);
            this.chkSymbols.TabIndex = 5;
            this.chkSymbols.Text = "@";
            this.ttTexts.SetToolTip(this.chkSymbols, "Symbols included?");
            this.chkSymbols.UseVisualStyleBackColor = true;
            // 
            // tbxPasses
            // 
            this.tbxPasses.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPasses.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPasses.Location = new System.Drawing.Point(12, 38);
            this.tbxPasses.Multiline = true;
            this.tbxPasses.Name = "tbxPasses";
            this.tbxPasses.ReadOnly = true;
            this.tbxPasses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxPasses.Size = new System.Drawing.Size(319, 176);
            this.tbxPasses.TabIndex = 7;
            this.tbxPasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttTexts.SetToolTip(this.tbxPasses, "Generated passes");
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(60, 12);
            this.numLength.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(42, 20);
            this.numLength.TabIndex = 8;
            this.ttTexts.SetToolTip(this.numLength, "How long shall your passes be?");
            this.numLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 226);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.tbxPasses);
            this.Controls.Add(this.chkSymbols);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkLowers);
            this.Controls.Add(this.chkUppers);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "passgen - by n3rdkeller";
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.CheckBox chkUppers;
        private System.Windows.Forms.CheckBox chkLowers;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.TextBox tbxPasses;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.ToolTip ttTexts;
    }
}

