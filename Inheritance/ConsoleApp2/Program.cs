using System;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();

            text.FontName = "Hello";
            text.FontSize = 20;
            Console.WriteLine(text.FontName);
            Console.WriteLine(text.FontSize);

            Console.WriteLine("Enter the Text");
              string text1 =Console.ReadLine();
            Console.WriteLine(text1);








            var table = new Table("PresentationHello,4,5");
            //table.TableName = "PresenatationTable";
            //table.Rows = 2;
            //table.Columns = 3;
            //Console.WriteLine(table.Rows);
            //Console.WriteLine(table.Columns);
            //Console.WriteLine(table.TableName);




        }
    }
}
