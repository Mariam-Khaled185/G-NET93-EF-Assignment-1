using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Models
{
    internal class Categories
    {
        public int CategoriesId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public bool IsActive { get; set; }

    }
}
