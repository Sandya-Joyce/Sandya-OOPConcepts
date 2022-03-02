using System;

namespace Inheritance
{
    class Table
    {
        public string TableName { get; set; }
        public int Rows { get; set; }

        public int Columns { get; set; }
       


        public Table()
        {

        }
        
        

        public Table(string tablename, int rows, int coloumns)
        {
            this.TableName = tablename;
            this.Rows = rows;
            this.Columns = coloumns;

            Console.WriteLine("Table name: " + this.TableName);
            Console.WriteLine("Rows : " + this.Rows);
            Console.WriteLine("Coloumns", this.Columns);
        }

        public Table(string v)
        {
        }
    }
}
