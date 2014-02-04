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
            this.SuspendLayout();
            // 
            // cmbGalaxies
            // 
            this.cmbGalaxies.FormattingEnabled = true;
            this.cmbGalaxies.Location = new System.Drawing.Point(53, 12);
            this.cmbGalaxies.Name = "cmbGalaxies";
            this.cmbGalaxies.Size = new System.Drawing.Size(196, 21);
            this.cmbGalaxies.TabIndex = 0;
            this.cmbGalaxies.SelectedIndexChanged += new System.EventHandler(this.cmbGalaxies_SelectedIndexChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(8, 39);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(790, 515);
            this.txtOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Galaxy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 15);
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
            this.cmbDivison.Location = new System.Drawing.Point(313, 12);
            this.cmbDivison.Name = "cmbDivison";
            this.cmbDivison.Size = new System.Drawing.Size(113, 21);
            this.cmbDivison.TabIndex = 4;
            // 
            // btnGenSector
            // 
            this.btnGenSector.Location = new System.Drawing.Point(815, 9);
            this.btnGenSector.Name = "btnGenSector";
            this.btnGenSector.Size = new System.Drawing.Size(97, 24);
            this.btnGenSector.TabIndex = 7;
            this.btnGenSector.Text = "Generate Sector";
            this.btnGenSector.UseVisualStyleBackColor = true;
            this.btnGenSector.Click += new System.EventHandler(this.btnGenSector_Click);
            // 
            // SectorGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 566);
            this.Controls.Add(this.btnGenSector);
            this.Controls.Add(this.cmbDivison);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cmbGalaxies);
            this.Name = "SectorGenerator";
            this.Text = "Sector Generator";
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
    }
}

