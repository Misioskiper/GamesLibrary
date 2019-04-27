using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekaGier.Model
{
    class Game
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Age { get; set; }

        public Game(string Title, decimal Price, string Description, string Age)
        {
            this.Title = Title;
            this.Price = Price;
            this.Description = Description;
            this.Age = Age;
        }

    }
}
