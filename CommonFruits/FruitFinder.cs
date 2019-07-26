using System.Collections.Generic;
using System.Linq;

namespace CommonFruits
{
    public class FruitFinder
    {
        public string GetFruit(List<string> fruits)
        {
            var mostOccurrences = 0;
            var mostCommonFruit = string.Empty;

            foreach (var fruit in fruits)
            {
                var howManyOccurrences = fruits.Count(w => w == fruit);
                if (howManyOccurrences > mostOccurrences)
                {
                    mostOccurrences = howManyOccurrences;
                    mostCommonFruit = fruit;
                }
            }

            return mostCommonFruit;
        }
    }
}
