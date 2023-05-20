using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BosWFA
{
    public class Nokta
    {

        public Nokta(int x, int y, int boyut, Color renk)
        {
            X = x;
            Y = y;
            Boyut = boyut;
            Renk = renk;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Boyut { get; set; }
        public Color Renk { get; set; }


        


        public override string ToString()
        {
            return $"Noktanın Koordinatları: [{X},{Y}] Noktanın Boyutu:{Boyut} Color:{Renk}";

        }


    }
}
