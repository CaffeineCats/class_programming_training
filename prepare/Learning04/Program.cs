using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment anAssignemnt = new WritingAssignment("Luis Riquelme","Inheritance", "A really Good Book");

        Console.WriteLine(anAssignemnt.GetWritingInformation());
    }
}