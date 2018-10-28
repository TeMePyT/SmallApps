using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoodCalculatorLibrary.Foods;
using MoodCalculatorLibrary.Moods;

namespace MoodCalculatorLibrary
{
    public class Gandalf
    {
        private int hapinessPoints { get; set; }
      

        
        public Mood GetMentalCondition()
        {
            return MoodFactory.GetMood(this.hapinessPoints);
        }

        public void Eat(IEnumerable<Food> foods)
        {
            foreach (Food food in foods)
            {
                this.hapinessPoints += food.pointOfHapiness;
            }
        }


        public override string ToString()
        {
            Mood mood = this.GetMentalCondition();
            return $"{this.hapinessPoints}{Environment.NewLine}{mood.GetType().Name}";
        }
    }
}
