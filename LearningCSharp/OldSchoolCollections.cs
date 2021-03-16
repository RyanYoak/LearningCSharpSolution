using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class OldSchoolCollections
    {
        // DO NOT USE THESE IN ACTUAL CODE
        [Fact]
        public void FavoriteNumbersList()
        {
            // This only takes objects in it, and treats it like objects
            // favoriteNumbers[1] + favoriteNumbers[0] won't compile
            // as object + object won't work
            // Also this is SLOW
            var favoriteNumbers = new ArrayList();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(20);
            favoriteNumbers.Add(42);
            favoriteNumbers.Add(108);

            Assert.Equal(9, favoriteNumbers[0]);
            Assert.Equal(108, favoriteNumbers[3]);
        }
    }
}
