using System;
using System.Collections.Generic;

namespace Dalidikes.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        [JsonIgnore]


        public virtual ICollection<Product> Products { get; set; }
    }
}
