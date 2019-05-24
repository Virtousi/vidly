using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateReleased { get; set; }
        public DateTime DateAdded { get; set; }
        public int Stocks { get; set; }
        public GenreType GenreType { get; set; }
        public int GenreTypeID { get; set; }
    }
}