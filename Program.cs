using System;
using System.Collections.Generic;

namespace RPPOON_LV4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Dataset data = new Dataset("Primjerdata.txt");
            data.LoadDataFromCSV("Primjerdata.txt");
            Analyzer3rdParty analyzerX = new Analyzer3rdParty();
            Adapter adapt = new Adapter(analyzerX);
            double[] Column = adapt.CalculateAveragePerColumn(data);
            double[] Raw = adapt.CalculateAveragePerRow(data);
            for (int i = 0; i<Column.Length;i++)
            {
                Console.WriteLine(Column[i]);
            }
            for (int i = 0; i < Raw.Length; i++)
            {
                Console.WriteLine(Raw[i]);
            }*/

            /*List<IRentable> Rented = new List<IRentable>();
            Rented.Add(new Book("Lord of the Rings"));
            Rented.Add(new Video("Hobbit"));
            RentingConsolePrinter Printer = new RentingConsolePrinter();
            Printer.DisplayItems(Rented);
            Printer.PrintTotalPrice(Rented);
          
            Rented.Add(new HotItem(new Video("Top 10 funny moments")));
            Rented.Add(new HotItem(new Book("Kuharica")));
            Printer.DisplayItems(Rented);
            Printer.PrintTotalPrice(Rented);
            // poveća se cijena zbog hot itema 

            Console.WriteLine("Nova lista flashSale:");
            List<IRentable> flashSale = new List<IRentable>();
            flashSale.Add(new DiscountedItem(new Book("Lord of the Rings"),30));
            flashSale.Add(new DiscountedItem(new Video("Hobbit"),25));
            flashSale.Add(new DiscountedItem(new Book("Top 10 funny moments"),40));
            flashSale.Add(new DiscountedItem(new Video("Kuharica"),60));
            Printer.DisplayItems(flashSale);
            Printer.PrintTotalPrice(flashSale);*/

            string email = "stjepan.prakljacic@gmail.com";
            string password = "Mojalozinka007";

            PasswordValidator passwordValidator = new PasswordValidator(8);
            EmailValidator emailValidator = new EmailValidator();

            if ((passwordValidator.IsValidPassword(password)) && (emailValidator.IsValidAddress(email)))
            {
                Console.WriteLine("Logged in!");
            }
            else
                
                Console.WriteLine("Invalid Password or email!");
                




    }
        
    }
}
