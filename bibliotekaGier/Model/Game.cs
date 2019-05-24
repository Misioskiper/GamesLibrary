using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekaGier.Model
{
    public class Game : LibraryObject
    {
        public string Title { get; set; }
        public int MinimumAge { get; set; }

        public Game(string Title, decimal Price, string Description, int Age) : base(Price, Description)
        {
            this.Title = Title;
            this.Price = Price;
            this.Description = Description;
            this.MinimumAge = Age;
        }


        public override string ToString()
        {
            string positionDescription = $"Tytuł: {Title} Opis: {Description} PEGI: {MinimumAge} Cena: {Price}";
            return positionDescription;
        }

        public void SaveToFile()
        {
            using (var x = new StreamWriter(@"D:\GamesLibrary-master\lib.txt", true))
            {
                x.WriteLine("{0}|{1}|{2}|{3}", Title, MinimumAge, Price, Description);
            }
        }
    }
}
