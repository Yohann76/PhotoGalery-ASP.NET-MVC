using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoGalery.Models
{

    // One 
    public class Photography
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }

    // Many 
    public class Photographies
    {
        public List<Photography> GetAllPhotographies()
        {
            return new List<Photography>
            {
                new Photography { id = 1, Name = "1Photo", Path = "Content/Photography"},
                new Photography { id = 2, Name = "2Photo", Path = "Content/Photography"},
                new Photography { id = 3, Name = "3Photo", Path  ="Content/Photography"},
                new Photography { id = 4, Name = "4Photo", Path = "Content/Photography"}
            };
        }
    }
}
