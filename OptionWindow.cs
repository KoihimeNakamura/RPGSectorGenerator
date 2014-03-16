namespace TwilightShards.SectorGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    
    internal partial class OptionWindow : Form
    {
        internal SectorGenerator parent;

        internal OptionWindow(SectorGenerator p)
        {
            InitializeComponent();
            this.parent = p;

            //translate selected settings to set settings 
            traStarSpacing.Value = this.parent.ourSettings.spaceBetweenStars;
            traNumTries.Value = this.parent.ourSettings.maxTriesTimeout;


            //checkboxes a bit more tricky
            switch (this.parent.ourSettings.chosenSize)
            {
                case SectorDiceOpt.Size1D10:
                    rad1D10.Checked = true;
                    break;
                case SectorDiceOpt.Size1D6:
                    rad1D6.Checked = true;
                    break;
                case SectorDiceOpt.Size1D8:
                    rad1D8.Checked = true;
                    break;
                case SectorDiceOpt.Size2D6:
                    rad2D6.Checked = true;
                    break;
                case SectorDiceOpt.Size2D8:
                    rad2D8.Checked = true;
                    break;
                case SectorDiceOpt.Size3D6:
                    rad3D6.Checked = true;
                    break;
                case SectorDiceOpt.Size4D6:
                    rad4D6.Checked = true;
                    break;
                case SectorDiceOpt.Size5D4:
                    rad5D4.Checked = true;
                    break;
                default:
                    rad3D6.Checked = true;
                    break;
            }

            //set labels to value
            lblNumTryValue.Text = traNumTries.Value.ToString();
            lblStelSpacValue.Text = traStarSpacing.Value.ToString();
        }

        private void traStarSpacing_ValueChanged(object sender, EventArgs e)
        {
            lblStelSpacValue.Text = traStarSpacing.Value.ToString();
        }

        private void traNumTries_ValueChanged(object sender, EventArgs e)
        {
            lblNumTryValue.Text = traNumTries.Value.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //commit now
            this.parent.ourSettings.setMaxTriesBeforeTimeout(traNumTries.Value);
            this.parent.ourSettings.setSpaceBetweenStars(traStarSpacing.Value);
            
            //time for unfun times. Check box -> enum.
            if (rad1D6.Checked) this.parent.ourSettings.setNumStarsPerSector(SectorDiceOpt.Size1D6);
            if (rad1D8.Checked) this.parent.ourSettings.setNumStarsPerSector(SectorDiceOpt.Size1D6);
            if (rad1D10.Checked) this.parent.ourSettings.setNumStarsPerSector(SectorDiceOpt.Size1D6);
            if (rad2D6.Checked) this.parent.ourSettings.setNumStarsPerSector(SectorDiceOpt.Size2D6);
            if (rad2D8.Checked) this.parent.ourSettings.setNumStarsPerSector(SectorDiceOpt.Size2D8);
            if (rad3D6.Checked) this.parent.ourSettings.setNumStarsPerSector(SectorDiceOpt.Size3D6);
            if (rad5D4.Checked) this.parent.ourSettings.setNumStarsPerSector(SectorDiceOpt.Size5D4);
            if (rad4D6.Checked) this.parent.ourSettings.setNumStarsPerSector(SectorDiceOpt.Size4D6);
            
            //close this window
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //do no saving, close this window
            this.Close();
        }

    }
}
