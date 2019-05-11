using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekaGier.Model
{
    public class LibraryObject
    {
        public decimal Price { get; set; }
        public string Description { get; set; }

        public LibraryObject(decimal Price, string Description)
        {
            this.Price = Price;
            this.Description = Description;
        }

    }
}
