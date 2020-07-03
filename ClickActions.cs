using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiBot
{
    public class ClickActions
    {
        public List<int> interuptionStep = new List<int>();
        public List<Point> interuptionPoints = new List<Point>();
        public List<int> colorValueCheck = new List<int>();

        public ClickActions()
        {
            colorValueCheck.Add(20);
            colorValueCheck.Add(96);
            interuptionStep.Add(2);
            interuptionStep.Add(3);
            interuptionPoints.Add(new Point(3500 - 1920, 930));
            interuptionPoints.Add(new Point(3500 - 1920, 930));
        }
    }
}
