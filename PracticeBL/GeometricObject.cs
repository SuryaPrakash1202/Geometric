using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBL
{
    public abstract class GeometricObject
    {
        private string color;
        private bool filled;
        public string Color { get; set; }
        public bool Filled { get; set; }  
       public GeometricObject(string colorvalue, bool filledvalue)
        {
            Color = colorvalue; 
            Filled = filledvalue;  
        }
        public abstract double Area();
        public abstract double Perimeter();
        public abstract string ToString();
    }
}
