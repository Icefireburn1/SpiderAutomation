using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;

namespace SpiderAutomation
{
    public struct Vector2
    {
        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;
    }

    class SaveConfig
    {
        public List<Form1.Vector2> locations;

        public Color questInProgressColor;

        public Color questCompleteColor;

        public SaveConfig(List<Form1.Vector2> locations, Color questInProgressColor, Color questCompleteColor)
        {
            this.locations = locations;
            this.questInProgressColor = questInProgressColor;
            this.questCompleteColor = questCompleteColor;
        }
    }
}
