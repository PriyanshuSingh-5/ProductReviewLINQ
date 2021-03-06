using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Management Review Program");
            //UC1 Creating a List of ProductReview and Adding values into List.
            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4, Review = "Good",     isLike = false },
                new ProductReview() { ProductId = 4, UserId = 3, Rating = 4, Review = "Good",     isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 3, Review = "Average",  isLike = false },
                new ProductReview() { ProductId = 3, UserId = 4, Rating = 5, Review = "Excelent", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 5, Rating = 3, Review = "Average",  isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 2, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 5, UserId = 6, Rating = 2, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 6, UserId = 7, Rating = 1, Review = "Very Bad", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 7, Rating = 3, Review = "Average",  isLike = true }
            };
            //foreach (var list in productReviewlist)
            //{
            //    Console.WriteLine("Product Id :" + list.ProductId + "\t" + "User Id :" + list.UserId + "\t" + "Rating ;" + list.Rating + "\t" + "Review :" + list.Review + "\t" + "Is Like :" + list.isLike);
            //}
            //ReviewManagement.RetrieveTopThreeRatedRecords(productReviewlist);
            //ReviewManagement.RetrieveRecordsWithGreaterThanThreeRating(productReviewlist);
            // ReviewManagement.RetrieveCountOfReviewForEachProductId(productReviewlist);
            //ReviewManagement.RetrieveProductIDAndReviewOfAllRecords(productReviewlist);
            //ReviewManagement.SkipTopFiveRecords(productReviewlist);
            // ReviewManagement.RetrieveProductIDAndReviewUsingLambdaSyntax(productReviewlist);
            //ReviewTable.AddDataIntoDataTable();
            //ReviewTable.RetrieveRecordWithTrueIsLike();
            // ReviewTable.FindAverageRatingOfTheEachProductId();
            //ReviewTable.RetrieveRecordsWithReviewContainsNice();
            //UC12
           ReviewTable.RetrieveRecordsForGivenUserIdOrderByRating();
            Console.ReadLine();
        }
    }
    
}
