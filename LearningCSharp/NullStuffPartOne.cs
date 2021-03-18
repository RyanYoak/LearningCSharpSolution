using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class NullStuffPartOne
    {
        [Fact]
        public void ConditionalAssignment()
        {
            var age = 20;
            string message = age >= 21 ? "Old enough" : "Too young";
            //if (age >= 21)
            //{
            //    message = "Old enough";
            //}
            //else
            //{
            //    message = "Too young";
            //}

            Assert.Equal("Too young", message);
        }

        [Fact]
        public void NullCoalescingOperator()
        {
            string firstName = null, lastName = null;

            // Return first non null value
            string preferredName = firstName ?? lastName ?? "Unknown";

            //string preferredName = null;
            //if(firstName == null)
            //{
            //    preferredName = lastName;
            //}
            //else
            //{
            //    preferredName = firstName;
            //}
            Assert.Equal("Unknown", preferredName);
        }

        [Fact]
        public void ElvisOperator()
        {
            Dinner d = null;

            // Without elvis operator there will be a runtime error
            var mainCourse = d?.MainCourse ?? "None Assigned";

            Assert.Equal("None Assigned", mainCourse);
        }

    }
}
