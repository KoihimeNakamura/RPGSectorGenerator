namespace TwilightShards.SectorGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    using Newtonsoft.Json;
    
    internal class OptionsCont
    {
        //setting limits
        private static int spaceBetweenStarsLow = 1;
        private static int spaceBetweenStarsHigh = 6;

        private static int maxTriesTimeoutLow = 100000;
        private static int maxTriesTimeoutHigh = 1000000000;

        //default values
        private static int defaultSpaceBetweenStars = 1;
        private static int defaultTriesTimeout = 1000000;
        private static SectorDiceOpt defaultChosenSize = SectorDiceOpt.Size3D6;

        //setting values
        internal SectorDiceOpt chosenSize { get; private set; }
        internal int spaceBetweenStars { get; private set; }
        internal int maxTriesTimeout { get; private set; }

        internal OptionsCont()
        {
            this.chosenSize = defaultChosenSize;
            this.maxTriesTimeout = defaultTriesTimeout;
            this.spaceBetweenStars = defaultSpaceBetweenStars;
        }

        internal OptionsCont(SectorDiceOpt dice, int between, int max)
        {
            this.chosenSize = dice;
            this.spaceBetweenStars = between;
            this.maxTriesTimeout = max;
        }

        internal OptionsCont(OptionsCont c)
        {
            this.chosenSize = c.chosenSize;
            this.spaceBetweenStars = c.spaceBetweenStars;
            this.maxTriesTimeout = c.maxTriesTimeout;
        }

        static internal OptionsCont loadSettings(string filePath)
        {
            string fileContents = File.ReadAllText(@filePath);
            OptionsCont temp = JsonConvert.DeserializeObject<OptionsCont>(fileContents);

            return temp;
        }

        static internal void saveSettings(OptionsCont set, string filePath)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartObject();
                writer.WritePropertyName("chosenSize");
                writer.WriteValue(set.chosenSize);
                writer.WritePropertyName("spaceBetweenStars");
                writer.WriteValue(set.spaceBetweenStars);
                writer.WritePropertyName("maxTriesTimeout");
                writer.WriteValue(set.maxTriesTimeout);
            }
            File.WriteAllText(@filePath, sb.ToString());
        }

        internal void setNumStarsPerSector(SectorDiceOpt s)
        {
            this.chosenSize = s;
        }

        internal void setSpaceBetweenStars(int sBetweenStars)
        {
            if (sBetweenStars >= spaceBetweenStarsLow && sBetweenStars <= spaceBetweenStarsHigh)
                spaceBetweenStars = sBetweenStars;
            else
                spaceBetweenStars = defaultSpaceBetweenStars;
        }

        internal void setMaxTriesBeforeTimeout(int maxTries)
        {
            if (maxTries >= maxTriesTimeoutLow && maxTries <= maxTriesTimeoutHigh)
                maxTriesTimeout = maxTries;
            else
                maxTriesTimeout = defaultTriesTimeout;
        }

        public override string ToString()
        {
            string s = "";
            s = s + "Dice Chosen: " + this.chosenSize.ToString() + Environment.NewLine;
            s = s + "Light year spacing between stars is " + this.spaceBetweenStars + " ly." + Environment.NewLine;
            s = s + "Maximum of Tries before Timeout is " + this.maxTriesTimeout + Environment.NewLine;

            return s;
        }

    }
}
