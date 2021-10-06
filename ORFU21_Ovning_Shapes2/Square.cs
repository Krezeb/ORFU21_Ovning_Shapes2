using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Ovning_Shapes2
{
    class Square : IShape
    {
        public int side { get; set; }
        public double GetArea()
        {
            return side * side;
        }
        public string Name()
        {
            return "Square";
        }
    }
}
