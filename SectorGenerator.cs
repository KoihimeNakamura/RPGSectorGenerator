namespace TwilightShards.SectorGenerator
{
    using System;
    using System.Data;
    using System.IO;
    using System.Drawing;
    using System.Linq;
    using System.Windows;
    using System.Windows.Forms;
    using System.Collections.Generic;   

    //non .NET includes
    using Newtonsoft.Json;
    using TwilightShards.libAstrogenesis;
    using TwilightShards.genLibrary;
    
    public partial class SectorGenerator : Form
    {
        //setting file.
        private static string settingFilePath = "settings.json";

        private string secName { get; set; }
        private double arcNumber { get; set; }
        private double eclHeight { get; set; }
        private double arcAngle { get; set; }
        private Dice ourDice { get; set; }

        internal OptionsCont ourSettings { get; set; }

        public SectorGenerator()
        {
            ourDice = new Dice();
            InitializeComponent();
            
            // populate the galaxy listing
            string rawGalaxiesJson = File.ReadAllText("galaxies.json");
            List<Galaxy> ourGalaxies = JsonConvert.DeserializeObject<List<Galaxy>>(rawGalaxiesJson);

            //populate the combo box
            foreach (Galaxy g in ourGalaxies)
            {
                cmbGalaxies.Items.Add(g);
            }

            //select the first galaxy and division
            cmbGalaxies.SelectedIndex = 0;
            cmbDivison.SelectedIndex = 0;
            cmbSectorSize.SelectedIndex = 0;

            //pull in options
            ourSettings = OptionsCont.loadSettings(settingFilePath);
            //MessageBox.Show(ourSettings.ToString());

        }

        private void cmbGalaxies_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGenSector_Click(object sender, EventArgs e)
        {


            //draw the sector map
            //SectorMap ourMap = new SectorMap();

            //ourMap.reDraw(PlotPoint.getILLocs(starLocations));
            //ourMap.ShowDialog();

            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionWindow optWin = new OptionWindow(this);
            optWin.Show();
        }

        private void SectorGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(ourSettings.ToString());
            //DialogBoxWithResult saveDialog = new DialogBoxWithResult();
            DialogResult ourBox = MessageBox.Show("Do you want to save before exiting?", "Save before Exiting", MessageBoxButtons.YesNo);
            if (ourBox == DialogResult.Yes)
                OptionsCont.saveSettings(ourSettings, settingFilePath);
            // else, don't save.
        }

        private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsCont.saveSettings(ourSettings, settingFilePath);
        }


    }
}
