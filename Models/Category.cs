using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoGalery.Models
{

    // One 
    public class Category
    {
        public string Name { get; set; }
        public int Years { get; set; }
    }

    // Many 
    public class Categories
    {
        public List<Category> GetListCategories()
        {
            return new List<Category>
            {
            new Category {  Years = 30, Name = "Nicolas" },
            new Category {  Years = 30, Name = "Delphine" },
            new Category {  Years = 30, Name = "Jérémie" },
            new Category {  Years = 30, Name = "Timéo" }
            };
        }
    }
}
