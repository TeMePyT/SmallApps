using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodCalculatorLibrary.Foods
{
    public abstract class Food
    {
        public int pointOfHapiness { get; private set; }
        public Food(int pointOfHapiness)
        {
            this.pointOfHapiness = pointOfHapiness;
        }
    }
}
