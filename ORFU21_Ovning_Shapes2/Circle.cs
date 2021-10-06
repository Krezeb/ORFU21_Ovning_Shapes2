using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Ovning_Shapes2
{
    class Circle :IShape
    {
        public double radius { get; set; }
        public double GetArea()
        {
            return (radius * radius) * Math.PI;
        }

        public string Name()
        {
            return "Circle";
        }
    }
}
