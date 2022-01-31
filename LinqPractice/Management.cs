using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Management
    {
        //UC2
        public void TopRecordsList(List<ProductReview> review)
        {
            var recordData = (from productReviews in review
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " " + "UserId: " + list.UserID + " " + "Rating: " + list.Rating + " "
                    + "Review: " + list.Review + " " + list.isLike + " ");
            }
        }
        //UC3
        public void SelectedRecords(List<ProductReview> review)
        {
            var recordData = from productReviews in review
                             where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                             && productReviews.Rating > 3
                             select productReviews;

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " " + "UserId: " + list.UserID + " " + "Rating: " + list.Rating + " "
                    + "Review: " + list.Review + " " + list.isLike + " ");
            }
        }
        //UC4
        public void RetrieveCountOfRecords(List<ProductReview> review)
        {
            var recordData = review.GroupBy(x => x.ProductID).
                                    Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + "-------------" + list.Count);
            }

        }
        //UC5
        public void RetriveTheProductIdAndReview(List<ProductReview> review)
        {
            var recordData = review.GroupBy(x => x.ProductID).Select(x => new { ProductId = x.Key });
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:" + list.ProductId);
            }
        }
        //#UC6
        public void SkipTheRecords(List<ProductReview> review)
        {
            var recordData = (from productReviews in review
                              orderby productReviews.Rating descending
                              select productReviews).Skip(5);
            foreach (var list in recordData)
            {
                Console.WriteLine("productId:" + list.ProductID + " " + "UserId:" + list.UserID + " " + "Rating:" + list.Rating + " " + "Review:" + list.Review + " " + list.isLike);
            }
        }
        //#UC7
        public void RetriveTheProductId(List<ProductReview> review)
        {
            var recordData = review.GroupBy(x => x.ProductID).Select(x => new { ProductId = x.Key });
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:" + list.ProductId);
            }
        }
        //#UC9
        public void RetriveAllRecords(List<DataTable> table)
        {
            var recordData = from DataTable in table
                             where DataTable.isLike == true
                             select DataTable;
            foreach (var list in recordData)
            {
                Console.WriteLine("isLike:" + list.isLike);
            }
        }
        //UC10
        public void AllPersonsAverageAge(List<DataTable> table)
        {
            var recordData = table.Average(x => x.ProductId);

            Console.WriteLine("the average of all the ProductIds is:" + recordData);


        }
    }
}
