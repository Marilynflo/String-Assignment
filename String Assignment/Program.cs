using System;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Marilyn";

            name = name.ToUpper();

            Console.WriteLine(name);

           
            string fName = "Marilyn";
            string lName = "Tanagon";
            string Name = string.Concat(fName, lName, "Flores");
            Console.WriteLine(Name);


            System.Text.StringBuilder builder = new System.Text.StringBuilder("My family and I");
            builder.Append(", ");
            builder.Append("We love");
            builder.Append(" nature ");
            builder.Append(". ");
            builder.Append(" We recently");
            builder.Append(" visited a farm.");
            builder.Append(" We also picked apples.");

            Console.WriteLine(builder);


        }
    }
}
