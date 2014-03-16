namespace TwilightShards.SectorGenerator
{
    partial class SectorMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectorMap));
            this.iLStarChart = new ILNumerics.Drawing.ILPanel();
            this.SuspendLayout();
            // 
            // iLStarChart
            // 
            this.iLStarChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iLStarChart.Driver = ILNumerics.Drawing.RendererTypes.GDI;
            this.iLStarChart.Editor = null;
            this.iLStarChart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iLStarChart.Location = new System.Drawing.Point(0, 0);
            this.iLStarChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iLStarChart.Name = "iLStarChart";
            this.iLStarChart.Rectangle = ((System.Drawing.RectangleF)(resources.GetObject("iLStarChart.Rectangle")));
            this.iLStarChart.ShowUIControls = false;
            this.iLStarChart.Size = new System.Drawing.Size(1454, 564);
            this.iLStarChart.TabIndex = 0;
            // 
            // SectorMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1454, 564);
            this.Controls.Add(this.iLStarChart);
            this.Name = "SectorMap";
            this.Text = "SectorMap";
            this.ResumeLayout(false);

        }

        #endregion

        private ILNumerics.Drawing.ILPanel iLStarChart;


    }
}