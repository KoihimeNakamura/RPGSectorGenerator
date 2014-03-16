namespace TwilightShards.SectorGenerator
{
    partial class SectorGenerator
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
            this.cmbGalaxies = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDivison = new System.Windows.Forms.ComboBox();
            this.btnGenSector = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbSectorSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGalaxies
            // 
            this.cmbGalaxies.FormattingEnabled = true;
            this.cmbGalaxies.Location = new System.Drawing.Point(53, 31);
            this.cmbGalaxies.Name = "cmbGalaxies";
            this.cmbGalaxies.Size = new System.Drawing.Size(196, 21);
            this.cmbGalaxies.TabIndex = 0;
            this.cmbGalaxies.SelectedIndexChanged += new System.EventHandler(this.cmbGalaxies_SelectedIndexChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(8, 60);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(790, 494);
            this.txtOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Galaxy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Divisions:";
            // 
            // cmbDivison
            // 
            this.cmbDivison.FormattingEnabled = true;
            this.cmbDivison.Items.AddRange(new object[] {
            "Half",
            "Quadrant",
            "Octant"});
            this.cmbDivison.Location = new System.Drawing.Point(313, 31);
            this.cmbDivison.Name = "cmbDivison";
            this.cmbDivison.Size = new System.Drawing.Size(113, 21);
            this.cmbDivison.TabIndex = 4;
            // 
            // btnGenSector
            // 
            this.btnGenSector.Location = new System.Drawing.Point(815, 28);
            this.btnGenSector.Name = "btnGenSector";
            this.btnGenSector.Size = new System.Drawing.Size(97, 24);
            this.btnGenSector.TabIndex = 7;
            this.btnGenSector.Text = "Generate Sector";
            this.btnGenSector.UseVisualStyleBackColor = true;
            this.btnGenSector.Click += new System.EventHandler(this.btnGenSector_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // cmbSectorSize
            // 
            this.cmbSectorSize.FormattingEnabled = true;
            this.cmbSectorSize.Items.AddRange(new object[] {
            "20",
            "50",
            "100"});
            this.cmbSectorSize.Location = new System.Drawing.Point(497, 30);
            this.cmbSectorSize.Name = "cmbSectorSize";
            this.cmbSectorSize.Size = new System.Drawing.Size(96, 21);
            this.cmbSectorSize.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sector Size";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // SectorGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSectorSize);
            this.Controls.Add(this.btnGenSector);
            this.Controls.Add(this.cmbDivison);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cmbGalaxies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SectorGenerator";
            this.Text = "Sector Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SectorGenerator_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGalaxies;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDivison;
        private System.Windows.Forms.Button btnGenSector;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbSectorSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
    }
}

