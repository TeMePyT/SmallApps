using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodCalculatorLibrary.Foods
{
   public class Mushrooms:Food
   {
       private const int PointOfHapiness = -10;

       public Mushrooms() : base(PointOfHapiness)
       {

       }
   }
}
