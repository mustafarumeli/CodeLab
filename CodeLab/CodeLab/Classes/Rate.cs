namespace CodeLab.Classes
{
    public class Rate
    {
        public Rate(int optimization, int readability, int compatibality, int depthOfInheritance)
        {
            Optimization = optimization;
            Readability = readability;
            Compatibality = compatibality;
            DepthOfInheritance = depthOfInheritance;
        }

        public int Optimization { get; set; }
        public int Readability { get; set; }
        public int Compatibality { get; set; }
        public int DepthOfInheritance { get; set; }
        private double RatingDecimal => Optimization * 0.6 + Readability * 0.15 + Compatibality * 0.15 + DepthOfInheritance * 0.10;
        public string Rating => System.Math.Round(RatingDecimal, 2).ToString();
        public int StarCount
        {
            get
            {
                var ratingTotal = RatingDecimal * 0.04;
                var rate = (int)(ratingTotal);
                var afterComma = ratingTotal - rate;
                rate = afterComma > 0.4 ? -1 * rate : rate;
                return rate;
            }
        }
    }
}
