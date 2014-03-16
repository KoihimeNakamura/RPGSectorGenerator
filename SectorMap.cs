namespace TwilightShards.SectorGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    using TwilightShards.libAstrogenesis;

    using ILNumerics.Drawing;
    using ILNumerics;
    using ILNumerics.Drawing.Plotting;

    public partial class SectorMap : Form
    {
        public SectorMap()
        {
            InitializeComponent();
        }

        public void reDraw(float[,] givenLocs)
        {
            ILArray<float> ourPositions = givenLocs;

            var scene = new ILScene();
            var plotCube = scene.Add(new ILPlotCube(null,false));
                     
            var ourPosBuffer = new ILPoints();
            ourPosBuffer.Positions = ourPositions;
            ourPosBuffer.Size = 5;
            ourPosBuffer.Color = Color.White;
            
            plotCube.Add(ourPosBuffer);
            plotCube.FieldOfView = 60;
            plotCube.LookAt = new Vector3(0, 0, 0);

            plotCube.ScaleModes.XAxisScale = AxisScale.Linear;
            plotCube.ScaleModes.YAxisScale = AxisScale.Linear;
            plotCube.ScaleModes.ZAxisScale = AxisScale.Linear;

            //set label colors. This is all over the place.
            var xLabel = plotCube.Axes.XAxis.Ticks.DefaultLabel;
            xLabel.Color = Color.White;

            var yLabel = plotCube.Axes.YAxis.Ticks.DefaultLabel;
            yLabel.Color = Color.White;

            var zLabel = plotCube.Axes.ZAxis.Ticks.DefaultLabel;
            zLabel.Color = Color.White;

            plotCube.Axes.XAxis.Label.Color = Color.White;
            plotCube.Axes.YAxis.Label.Color = Color.White;
            plotCube.Axes.ZAxis.Label.Color = Color.White;

            //designed to create a starfield look.
            iLStarChart.Scene = scene;
            iLStarChart.BackColor = Color.Black;
            iLStarChart.ForeColor = Color.White;
            iLStarChart.Scene.Configure();
        }

    }
}
