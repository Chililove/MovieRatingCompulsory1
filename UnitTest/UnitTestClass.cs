using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieRating.Core.DataService;
using MovieReview.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace UnitTest
{
    [TestClass]
    public class UnitTestClass
    {
        [TestMethod]
        public void Test1()
        {
            Mock<IReviewRepo> mr = new Mock<IReviewRepo>();

            // change with json file
            Review[] value =
                { new Review  {Reviewer = 1, Movie = 2, Grade = 3 },
                new Review {Reviewer = 2, Movie = 2, Grade = 4 } };
            
            
            
            }


        }
    }
}
