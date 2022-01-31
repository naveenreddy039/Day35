using System;
using System.Collections.Generic;
using System.Data;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management problem Statement");

            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=7,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=5,UserID=3,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=6,UserID=3,Rating=1,Review="Good",isLike=true},
                new ProductReview(){ProductID=7,UserID=4,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=8,UserID=4,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=9,UserID=5,Rating=8,Review="Good",isLike=true},

            };

            foreach (var list in listProductReview)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " " + "UserId: " + list.UserID + " " + "Rating: " + list.Rating + " "
                    + "Review: " + list.Review + " " + list.isLike + " ");
            }

            Console.WriteLine("-------------------------------------------------------------------");

            Management management = new Management();
            //UC2
            //management.TopRecordsList(listProductReview);
            //UC3
            //management.SelectedRecords(listProductReview);
            //UC4
            //management.RetrieveCountOfRecords(listProductReview);
            //UC5
            //management.RetriveTheProductIdAndReview(listProductReview);
            //UC6
            management.SkipTheRecords(listProductReview);
            //UC7
            //management.RetriveTheProductId(listProductReview);

            Console.WriteLine("-------------------------");

            //UC8
            List<DataTable> listDataTable = new List<DataTable>()
            {
            new DataTable() { ProductId = 6,UserId = 5,Rating = 10,Review = "Good",isLike = true},
            new DataTable() { ProductId = 7, UserId = 4, Rating = 12, Review = "Good", isLike = true },
            new DataTable() { ProductId = 8, UserId = 6, Rating = 15, Review = "Good", isLike = true },
            new DataTable() { ProductId = 9, UserId = 8, Rating = 18, Review = "Good", isLike = true },
            new DataTable() { ProductId = 10, UserId = 7, Rating = 13, Review = "Good", isLike = true },

            };
            foreach (var list in listDataTable)
            {
                Console.WriteLine("ProductId" + list.ProductId + " " + "userId:" + list.UserId + " " + "Rating" + list.Rating);

            }
            //UC9
            //management.RetriveAllRecords(listDataTable);
            //UC10
            //management.AllPersonsAverageAge(listDataTable);
        }
    }
}
