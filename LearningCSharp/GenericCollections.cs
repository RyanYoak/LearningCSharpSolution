using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class GenericCollections
    {
        [Fact]
        public void FavoriteNumbersAgain()
        {
            // Parametric Polymorphism <int>
            var favoriteNumbers = new List<int>();
            favoriteNumbers.Add(42);
            favoriteNumbers.Add(20);
            var firstTwo = favoriteNumbers[0] + favoriteNumbers[1];
            Assert.Equal(62, firstTwo);
        }

        [Fact]
        public void UsingADictionary()
        {
            var mealPlan = new Dictionary<string, Dinner>();
            mealPlan.Add("Tuesday", new Dinner()
            {
                MainCourse = "Pizza",
                HasSides = true,
            });
            mealPlan.Add("Wednesday", new Dinner()
            {
                MainCourse = "Pasta"
            });

            Assert.Equal("Pizza", mealPlan["Tuesday"].MainCourse);
        }

        [Fact]
        public void CollectionInitializers()
        {
            var favoriteNumbers = new List<int> { 
                1, 42, 67, 4643, 236, 23643, 264, 267, 26, 26, 23654
            };

            Assert.Equal(42, favoriteNumbers[1]);

            var friends = new Dictionary<char, string>
            {
                {'s', "Sean Carlin" },
                {'r', "Ryan Yoak" },
                {'j', "Jarrett Soross" },
                {'c', "Charlie Himmers" }
            };

            Assert.Equal("Ryan Yoak", friends['r']);
            Assert.True(friends.ContainsKey('r'));
            Assert.False(friends.ContainsKey('x'));
        }

        [Fact]
        public void EnumeratingCollection()
        {
            // Enumerating means "Going through one at a time with a goal"
            var favoriteNumbers = new List<int> {
                1, 42, 67
            };

            var friends = new Dictionary<char, string>
            {
                {'s', "Sean Carlin" },
                {'r', "Ryan Yoak" },
                {'j', "Jarrett Soross" },
                {'c', "Charlie Himmers" }
            };

            var total = 0;
            foreach(var number in favoriteNumbers)
            {
                total += number;
            }

            Assert.Equal(110, total);
        }
    }
}
