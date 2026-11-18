using Assignment__2._5;

namespace Assignment__2
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Assignment #2");
            Console.WriteLine("---------------------------------");

            #region Q7
            int pages = 300;
            double y = pages;
            Console.WriteLine(y.GetType());
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q8
            double price = 49.99;
            int x = (int)price;
            Console.WriteLine(x.GetType());
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q9
            string pagesText = "464";
            int n = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesText);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q10
            string yearText = "2023";
            int t = int.Parse(yearText);
            Console.WriteLine(t);

            string badText = "abc";
            bool m = int.TryParse(badText, out int res);
            Console.WriteLine(m);
            if (m == false)
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q11
            int Pages = 464;
            string TexPages = Convert.ToString(Pages);
            Console.WriteLine(TexPages);
            Console.WriteLine(TexPages.GetType());
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q12
            int copies = 100;
            object obj = copies;
            int newcopies = (int)obj;
            Console.WriteLine(obj);
            Console.WriteLine(newcopies);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q13
            int? year = null;
            Console.WriteLine(year.HasValue);
            year = 2023;
            Console.WriteLine(year);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q14
            string? reviewer = null;
            Console.WriteLine(reviewer == null);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q15
            Book? book = null;
            Console.WriteLine(book?.Title);
            string? Title = book?.Title;
            #endregion
            
            Console.WriteLine("--------------------------------");

            #region Q16
            Console.WriteLine(Title ?? "Untitled");
            Title ??= "Untitled";
            Console.WriteLine(Title);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q17
            string? name = "Ahmed";
            string ConfirmName = name!;
            Console.WriteLine(ConfirmName);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q18



            int pages5 = 464;

            if (pages5 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            #endregion

            Console.WriteLine("--------------------------------");

            #region Q19

            int pages2 = 464;
            bool isAvailable = true;

            if (pages2 > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }

            #endregion

            Console.WriteLine("--------------------------------");

            #region Q20



            string title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;


                default:
                    Console.WriteLine("Never heard of it");
                    break;


            }
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q21



            int pages3 = 464;
            string sizeLabel = pages3 > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            Console.WriteLine("--------------------------------");

            #region Q22 , 23 , 24 , 25 , 26 , 27



            //Q22
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(i + 1 + "." + books[i]);
            }

            Console.WriteLine("--------------------------------");

            //Q23
            int s = 0;
            while (s < books.Length)
            {
                Console.WriteLine(books[s]);
                s++;
            }

            Console.WriteLine("--------------------------------");

            //Q24
            int o = 0;
            do
            {
                Console.WriteLine("Checking book...");
                o++;
            }
            while (o < books.Length);

            Console.WriteLine("--------------------------------");

            //Q25
            foreach (string book_ in books)
            {
                Console.WriteLine(book_);
            }

            Console.WriteLine("--------------------------------");

            //Q26
            foreach (string book_ in books)
            {
                Console.WriteLine(book_);
                if (book_ == "Refactoring") break;
            }

            Console.WriteLine("--------------------------------");

            //Q27
            foreach (string book_ in books)
            {
                if (book_ == "The Pragmatic Programmer") continue;
                Console.WriteLine(book_);
            }

            #endregion







        }
    }
}
