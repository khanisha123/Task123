using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Building project1 = new Building();
            project1.Model = "Model = Home";
            project1.Height = 12;
            project1.Width = 10;
            project1.Length = 11;
            project1.NumberOfWindows = 15;
            project1.HowManySquareMeteers = 220;
            project1.NumberOfDoor = 10;
            project1.HowManyFloors = 2;
            project1.Price = 105000;
            //Console.WriteLine(project1.Detail());
            Console.WriteLine(project1.Model);
            Console.WriteLine($"Height = {project1.Height} meters");
            Console.WriteLine($"Width = {project1.Width} meters");
            Console.WriteLine($"Length = {project1.Length} meters");
            Console.WriteLine($"NumberOfWindows = {project1.NumberOfWindows}");
            Console.WriteLine($"HowManySquareMeteers = {project1.HowManySquareMeteers}");
            Console.WriteLine($"NumberOfDoor = {project1.NumberOfDoor}");
            Console.WriteLine($"HowManyFloors = {project1.HowManyFloors}");
            Console.WriteLine($"Price = {project1.Price} USD");

            Building project2 = new Building();
            project2.Model = "Skyscraper-Empire State Building";
            project2.Height = 443;
            project2.NumberOfWindows = 6550;
            project2.HowManySquareMeteers = 8094;
            project2.HowManyFloors = 102;
            project2.Price = 24718;
            Console.WriteLine("           ");
            Console.WriteLine(project2.Model);
            Console.WriteLine($"Height = {project2.Height} meters");
            Console.WriteLine($"NumberOfWindows = {project2.NumberOfWindows}");
            Console.WriteLine($"HowManySquareMeteers = {project2.HowManySquareMeteers}");
            Console.WriteLine($"HowManyFloors = {project2.HowManyFloors}");
            Console.WriteLine($"Price = {project2.Price} milyon USD");
        }
    }
}
