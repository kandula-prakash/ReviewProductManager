using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    class ProductReview
    {
        public int productID { get; set; }
        public int userID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool Islike { get; set; }
    }
}
