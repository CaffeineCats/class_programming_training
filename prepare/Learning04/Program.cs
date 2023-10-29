using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment anAssignemnt = new MathAssignment("Luis Riquelme","Inheritance", "7.1", "1");

        Console.WriteLine(anAssignemnt.GetHomeWorkList());
    }
}