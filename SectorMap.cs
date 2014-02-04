using System;
namespace TwilightShards.SectorGenerator
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class SectorMap : Form
    {
        public SectorMap()
        {
            InitializeComponent();
        }

        private void SectorMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicObj;
            graphicObj = this.CreateGraphics();

            Pen mPen = new Pen(System.Drawing.Color.White, 3);
            mPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            graphicObj.DrawLine(mPen, 1, 1, 1, 599);
            graphicObj.DrawLine(mPen, 1, 1, 799, 1);


        }
    }
}
