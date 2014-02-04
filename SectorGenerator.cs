namespace TwilightShards.SectorGenerator
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Newtonsoft.Json;
    using TwilightShards.libAstrogenesis;
    
    public partial class SectorGenerator : Form
    {
        public SectorGenerator()
        {
            InitializeComponent();
            
            // populate the galaxy listing
            string rawGalaxiesJson = File.ReadAllText("galaxies.json");
            List<Galaxy> ourGalaxies = JsonConvert.DeserializeObject<List<Galaxy>>(rawGalaxiesJson);

            //populate the combo box
            foreach (Galaxy g in ourGalaxies)
            {
                cmbGalaxies.Items.Add(g);
            }
            
        }

        private void cmbGalaxies_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOutput.Text = cmbGalaxies.SelectedItem.ToString();
        }

        private void btnGenSector_Click(object sender, EventArgs e)
        {
            SectorMap ourMap = new SectorMap();
            ourMap.Show();
        }

    }
}
