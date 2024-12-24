namespace Solution
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.premisesLabel = new System.Windows.Forms.Label();
            this.premisesBox = new System.Windows.Forms.TextBox();
            this.premisesListBox = new System.Windows.Forms.ListBox();
            this.rulesListBox = new System.Windows.Forms.ListBox();
            this.rulesBox = new System.Windows.Forms.TextBox();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.premisesButton = new System.Windows.Forms.Button();
            this.ruleButton = new System.Windows.Forms.Button();
            this.conclusionsList = new System.Windows.Forms.ListBox();
            this.inferButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProblemSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // premisesLabel
            // 
            this.premisesLabel.AutoSize = true;
            this.premisesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premisesLabel.Location = new System.Drawing.Point(12, 30);
            this.premisesLabel.Name = "premisesLabel";
            this.premisesLabel.Size = new System.Drawing.Size(75, 18);
            this.premisesLabel.TabIndex = 1;
            this.premisesLabel.Text = "Premises:";
            // 
            // premisesBox
            // 
            this.premisesBox.Location = new System.Drawing.Point(12, 51);
            this.premisesBox.Name = "premisesBox";
            this.premisesBox.Size = new System.Drawing.Size(461, 20);
            this.premisesBox.TabIndex = 2;
            // 
            // premisesListBox
            // 
            this.premisesListBox.FormattingEnabled = true;
            this.premisesListBox.Location = new System.Drawing.Point(12, 91);
            this.premisesListBox.Name = "premisesListBox";
            this.premisesListBox.Size = new System.Drawing.Size(561, 121);
            this.premisesListBox.TabIndex = 3;
            // 
            // rulesListBox
            // 
            this.rulesListBox.FormattingEnabled = true;
            this.rulesListBox.Location = new System.Drawing.Point(12, 284);
            this.rulesListBox.Name = "rulesListBox";
            this.rulesListBox.Size = new System.Drawing.Size(561, 121);
            this.rulesListBox.TabIndex = 6;
            // 
            // rulesBox
            // 
            this.rulesBox.Location = new System.Drawing.Point(12, 244);
            this.rulesBox.Name = "rulesBox";
            this.rulesBox.Size = new System.Drawing.Size(461, 20);
            this.rulesBox.TabIndex = 5;
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLabel.Location = new System.Drawing.Point(12, 223);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(50, 18);
            this.rulesLabel.TabIndex = 4;
            this.rulesLabel.Text = "Rules:";
            // 
            // premisesButton
            // 
            this.premisesButton.Location = new System.Drawing.Point(498, 51);
            this.premisesButton.Name = "premisesButton";
            this.premisesButton.Size = new System.Drawing.Size(75, 23);
            this.premisesButton.TabIndex = 7;
            this.premisesButton.Text = "Add Premise";
            this.premisesButton.UseVisualStyleBackColor = true;
            this.premisesButton.Click += new System.EventHandler(this.premisesButton_Click);
            // 
            // ruleButton
            // 
            this.ruleButton.Location = new System.Drawing.Point(498, 244);
            this.ruleButton.Name = "ruleButton";
            this.ruleButton.Size = new System.Drawing.Size(75, 23);
            this.ruleButton.TabIndex = 8;
            this.ruleButton.Text = "Add Rule";
            this.ruleButton.UseVisualStyleBackColor = true;
            this.ruleButton.Click += new System.EventHandler(this.ruleButton_Click);
            // 
            // conclusionsList
            // 
            this.conclusionsList.FormattingEnabled = true;
            this.conclusionsList.Location = new System.Drawing.Point(579, 87);
            this.conclusionsList.Name = "conclusionsList";
            this.conclusionsList.Size = new System.Drawing.Size(299, 316);
            this.conclusionsList.TabIndex = 9;
            // 
            // inferButton
            // 
            this.inferButton.Location = new System.Drawing.Point(614, 51);
            this.inferButton.Name = "inferButton";
            this.inferButton.Size = new System.Drawing.Size(232, 23);
            this.inferButton.TabIndex = 10;
            this.inferButton.Text = "Infer";
            this.inferButton.UseVisualStyleBackColor = true;
            this.inferButton.Click += new System.EventHandler(this.inferButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProblemSetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadProblemSetToolStripMenuItem
            // 
            this.loadProblemSetToolStripMenuItem.Name = "loadProblemSetToolStripMenuItem";
            this.loadProblemSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadProblemSetToolStripMenuItem.Text = "Load problem set";
            this.loadProblemSetToolStripMenuItem.Click += new System.EventHandler(this.loadProblemSetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.inferButton);
            this.Controls.Add(this.conclusionsList);
            this.Controls.Add(this.ruleButton);
            this.Controls.Add(this.premisesButton);
            this.Controls.Add(this.rulesListBox);
            this.Controls.Add(this.rulesBox);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.premisesListBox);
            this.Controls.Add(this.premisesBox);
            this.Controls.Add(this.premisesLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Forward Chaining System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label premisesLabel;
        private System.Windows.Forms.TextBox premisesBox;
        private System.Windows.Forms.ListBox premisesListBox;
        private System.Windows.Forms.ListBox rulesListBox;
        private System.Windows.Forms.TextBox rulesBox;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Button premisesButton;
        private System.Windows.Forms.Button ruleButton;
        private System.Windows.Forms.ListBox conclusionsList;
        private System.Windows.Forms.Button inferButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProblemSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

