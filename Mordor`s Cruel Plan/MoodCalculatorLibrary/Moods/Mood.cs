using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodCalculatorLibrary.Moods
{
    public abstract class Mood
    {
        private int hapinessPoints;

        public Mood(int happinessPoints)
        {
            this.hapinessPoints = happinessPoints;
        }
    }
}
