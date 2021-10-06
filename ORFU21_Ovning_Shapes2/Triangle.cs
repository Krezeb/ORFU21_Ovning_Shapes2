using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Ovning_Shapes2
{
    class Triangle :IShape
    {
        public int height { get; set; }
        public int width { get; set; }
        public double GetArea()
        {
            return (height * width) / 2.0;
        }
        public string Name()
        {
            return "Triangle";
        }
    }
}
