using MovieRating.Core.AppService.Services;
using MovieRating.Core.DataService;
using MovieRating.Infrastructure.Data;
using System;
using Xunit;

namespace XUnitTest
{
    public class xUnitTest
    {
        private IReviewRepo repo;


        public xUnitTest() 
        {
            repo = new ReviewRepo();

            repo.GetAllReviews();
        }

        [Fact]
        public void Test1()
        {
            ReviewService rs = new ReviewService(repo);
            DateTime start = DateTime.Now;
            rs.GetNumberOfReviewsFromReviewer(1);
            rs.GetAverageRateFromReviewer(1);
            rs.GetNumberOfRatesByReviewer(1,2);
            rs.GetNumberOfReviews(1);
            rs.GetAverageRateOfMovie(1);
            rs.GetNumberOfRates(1, 2);
            rs.GetMoviesWithHighestNumberOfTopRates();
            DateTime end = DateTime.Now;
            double time = (end - start).TotalMilliseconds;
            Assert.True(time <= 4000);
        }
    }
}
