using MovieRating.Core.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieRating.Core.AppService.Services
{
    public class ReviewService
    {
        IReviewRepo reviewRepo;
        public ReviewService(IReviewRepo rRepo)
        {
            reviewRepo = rRepo;
        }
        // Question 1
        public int GetNumberOfReviewsFromReviewer(int reviewer) 
        {
            int result = reviewRepo.GetAllReviews().Count(r=>r.Reviewer==reviewer);
            return result;
        }
        // Question 2
        public double GetAverageRateFromReviewer(int reviewer) 
        {
            var aRate = (from r in reviewRepo.GetAllReviews().Where
                         (r => r.Reviewer== reviewer)select r.Grade);
            return aRate.Average(r => r);

        }
    }
}
