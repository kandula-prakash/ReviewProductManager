using ProductReview;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management problem statement");
            List<ProductReview> ProductReviewList = new List<ProductReview>()
            {
                new ProductReview(){productID=1,userID=1,Rating=5,Review="good",Islike=true},
                new ProductReview(){productID=2,userID=10,Rating=5.1,Review="good",Islike=true},
                new ProductReview(){productID=21,userID=16,Rating=5.5,Review="good",Islike=true},
                new ProductReview(){productID=3,userID=12,Rating=5.6,Review="good",Islike=true},
                new ProductReview(){productID=4,userID=10,Rating=5.2,Review="nice",Islike=true},
                new ProductReview(){productID=6,userID=16,Rating=5.1,Review="good",Islike=false},
                new ProductReview(){productID=5,userID=15,Rating=5.7,Review="bad",Islike=true},
                new ProductReview(){productID=8,userID=12,Rating=5.9,Review="good",Islike=true},
                new ProductReview(){productID=9,userID=12,Rating=5.2,Review="bad",Islike=true},
                new ProductReview(){productID=10,userID=10,Rating=5.3,Review="bad",Islike=true},
                new ProductReview(){productID=12,userID=10,Rating=5.6,Review="nice",Islike=true},
                new ProductReview(){productID=13,userID=10,Rating=6,Review="nice",Islike=true},
                new ProductReview(){productID=14,userID=10,Rating=7,Review="good",Islike=true}

            };
            // uc-2
            Management management = new Management();
            management.TopRecords(ProductReviewList);

            // uc-3
            management.SelectedRecords(ProductReviewList);

            // uc-4
            management.RetrieveCountOfRecords(ProductReviewList);

            // uc-5
            management.RetrieveIDAndReview(ProductReviewList);

            // uc-6
            management.SkipTop5Records(ProductReviewList);

            // uc-7
            ProductDataTable data = new ProductDataTable();
            data.AddToDataTable();

            // uc-8
            DataTable table = data.AddToDataTable();
            management.DisplayDataTable_WithIsLikeValueTrue(table);

            // uc-9
            management.FindAverageRating(table);
        }
    }

}
    

