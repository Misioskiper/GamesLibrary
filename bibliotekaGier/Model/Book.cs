using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotekaGier.Model
{
    public class Book: LibraryObject
    {
        public string Title { get; set; }
        public string Type { get; set; }

        public Book(string Title, string Type, decimal Price, string Description) : base(Price, Description)
        {
            this.Title = Title;
            this.Type = Type;
            this.Price = Price;
            this.Description = Description;
        }

        public override string ToString()
        {
            return $"Tytuł: {Title} Opis: {Description} Gatunek: {Type} Cena: {Price}";
        }

        public void SaveToFile()
        {
            using (var sw = new StreamWriter(@"D:\GamesLibrary-master\lib.txt", true))
            {
                sw.WriteLine("{0}|{1}|{2}|{3}|", Title, Type, Price, Description);
            }
        }
    }
}
