using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Randomizer
    {
        private Random r;
        private const int MIN_VAL = -25;
        private const int MAX_VAL = 25;

        public Randomizer()
        {
            r = new Random();
        }

        public Color RandomColor()
        {
            int GenR = r.Next(0, 255);
            int GenG = r.Next(0, 255);
            int GenB = r.Next(0, 255);

            Color col = Color.FromArgb(GenR, GenG, GenB);
            return col;

        }

        public Vector3 Generate3DPoint()
        {
            int a = r.Next(MIN_VAL, MAX_VAL);
            int b = r.Next(MIN_VAL, MAX_VAL);
            int c = r.Next(MIN_VAL, MAX_VAL);

            Vector3 vec = new Vector3(a, b, c);

            return vec;

        }
        public Vector3 Generate3DPoint(int spec)
        {
            int a = r.Next(-1 * spec, spec);
            int b = r.Next(-1 * spec, spec);
            int c = r.Next(-1 * spec, spec);

            Vector3 vec = new Vector3(a, b, c);

            return vec;
        }



        public int GeneratePositiveInt(int limit)
        {
            int a = r.Next(0, limit);

            return a;
        }

    }
}
