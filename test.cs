// using System;

// namespace CatWorx.BadgeMaker
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
    // Data Types
//             string greeting = "Hello";
//             greeting = greeting + "World";
//             Console.WriteLine("greeting" + greeting);
//             Console.WriteLine("Hello, World!");

//             How do you find the area of a square? Area = side * side
//             float side = 3.14;

//             float side = 3.14F;
//             float area = side * side;
//             Console.WriteLine("area: {0}", area);

//             double side = 3.14;
//             double area = side * side;
//             Console.WriteLine("area: {0}", area);

//             Console.WriteLine("area is a {0}", area.GetType());

//             Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
//             Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
//             Console.WriteLine(1 + 2 * 3);     // order of operations
//             Console.WriteLine(10 / 3.0);      // int's and doubles
//             Console.WriteLine(10 / 3);        // int's 
//             Console.WriteLine("12" + "3");    // What happens here?

//             int num = 10;
//             num += 100;
//             Console.WriteLine(num);
//             num ++;
//             Console.WriteLine(num);

//             bool isCold = true;
//             Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
//             Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice
        

//             Try writing code that converts the stringNum text to an Int32 and
//             stores it into a variable. Print the variable, and print 
//             the variable's type as well.


//             string stringNum = "2";
//             int intNum = Convert.ToInt32(stringNum);
//             Console.WriteLine(intNum);
//             Console.WriteLine(intNum.GetType());

//             Console.WriteLine("----------------");
//             Console.WriteLine("  Scoreboard");
//             Console.WriteLine("----------------");
//             Console.WriteLine("Inning |  Score");
//             Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
//             Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
//             Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
//             Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
//             Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);
        
//             string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
//             string firstFood = favFoods[0];
//             string secondFood = favFoods[1];
//             string thirdFood = favFoods[2];
//             Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);


//             lists
//             List<string> employees = new List<string>() { "adam", "amy" };

//             employees.Add("barbara");
//             employees.Add("billy");

//             Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);

//             Loop
//             for (int i = 0; i < employees.Count; i++) 
//             {
//             Console.WriteLine(employees[i]);
//             }
//         }
//     }
// }
