using MoodCalculatorLibrary.Moods;


namespace MoodCalculatorLibrary
{
    public class MoodFactory
    {
        private const int AngryTopBorder = -6;
        private const int SadTopBorder = 0;
        private const int HappyTopBorder = 15;

        public static Mood GetMood(int hapinessPoints)
        {
            if (hapinessPoints <= AngryTopBorder)
            {
                return new Angry(hapinessPoints);
            }
            else if (hapinessPoints <= SadTopBorder)
            {
                return new Sad(hapinessPoints);
            }
            else if (hapinessPoints <= HappyTopBorder)
            {
                return new Happy(hapinessPoints);
            }
            else
            {
                return  new JavaScript(hapinessPoints);
            }
        }
    }
}
