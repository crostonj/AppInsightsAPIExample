namespace AppInsightsAPIExample.models
{
    public class Mathy
    {
        private int answer;
        private int denominator;

        public Mathy(int denominator)
        {
            this.denominator = denominator;
            this.answer = 0;
        }

        public int Answer { get => answer; set => answer = value; }
        public int Denominator { get => denominator; set => denominator = value; }
    }
}
