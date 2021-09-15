using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReview
{
    class Management
    {
       

        public void DisplayRecords(EnumerableRowCollection<DataRow> recordedData)
        {
            Console.WriteLine($"{new string('-', 70)}");
            Console.WriteLine($"|{"ProductID",15} | {"UserID",10} | {"Rating",10} | {"Review",10} | {"isLike",10} |");
            Console.WriteLine($"{new string('-', 70)}");
            foreach (var list in recordedData)
            {
                Console.WriteLine($"|{list.Field<int>("ProductID"),15} | {list.Field<int>("UserID"),10} | {list.Field<int>("Rating"),10} | {list.Field<string>("Review"),10} | {list.Field<bool>("isLike"),10} |");
            }
            Console.WriteLine($"{new string('-', 70)}\n");
        }
        // uc-2
        public void TopRecords(List<ProductReview> listProductReview)
        {
            Console.WriteLine("\nTop 3 records: ");
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            DisplayRecords(recordedData);
        }
    }
}