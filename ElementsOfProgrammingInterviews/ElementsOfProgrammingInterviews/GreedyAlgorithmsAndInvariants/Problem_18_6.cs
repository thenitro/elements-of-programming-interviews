namespace ElementsOfProgrammingInterviews.GreedyAlgorithmsAndInvariants
{
    public class Problem_18_6
    {
        private const int kMPG = 20;
        
        public int Solution(int[] gallons, int[] distances)
        {
            var remainingGallons = 0;

            var cityRemainingGallonsPair = new CityAndRemainingGas(0, 0);
            var numCities = gallons.Length;

            for (var i = 1; i < numCities; i++)
            {
                remainingGallons += gallons[i - 1] - distances[i - 1] / kMPG;

                if (remainingGallons < cityRemainingGallonsPair.RemainingGallons)
                {
                    cityRemainingGallonsPair = new CityAndRemainingGas(i, remainingGallons);
                }
            }

            return cityRemainingGallonsPair.City;
        }
        
        private struct CityAndRemainingGas
        {
            public int City;
            public int RemainingGallons;
            
            public CityAndRemainingGas(int city, int remainingGallons)
            {
                City = city;
                RemainingGallons = remainingGallons;
            }
        }
    }
}