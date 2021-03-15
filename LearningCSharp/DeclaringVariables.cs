using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class DeclaringVariables
    {
        [Fact]
        public void SamplesOfExplicitLocalVariables()
        {
            int age;
            age = 21;

            string name;
            name = "Ryan";

            Assert.Equal("Ryan", name);
            Assert.Equal(21, age);
        }

        [Fact]
        public void ImplicityTypesLocalVariables()
        {
            var age = 51;
            var name = "Ryan";

            Assert.Equal("Ryan", name);
            Assert.Equal(51, age);
        }

        [Fact]
        public void ObjectInitializers()
        {
            var myDinner = new Dinner()
            {
                MainCourse = "Tacos",
                Drinks = "Water",
                HasSides = false,
                Desert = "Cake"
            };

            Assert.Equal("For Dinner you will have Tacos with Cake.", myDinner.GetPlan());
        }
    }

    public class Dinner
    {
        public string MainCourse;
        public string Desert;
        public bool HasSides;
        public string Drinks;

        public string GetPlan()
        {
            return $"For Dinner you will have {MainCourse} with {Desert}.";
        }
    }
}
