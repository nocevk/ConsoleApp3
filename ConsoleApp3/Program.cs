// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//task1

string name = "Kirilo";
int age = 17;
Console.WriteLine("task 1:");
Console.WriteLine("Hello, {0}, I'm {1} years old", name, age);

// task 2
int a = 3;
int b = 7;
double result;
result = (Math.Pow((a - b), 3) - Math.Pow(a, 3)) / (Math.Pow(b, 3) - 3 * a * Math.Pow(b, 2) - 3 * Math.Pow(a, 2) * b);
Console.Write("_");
Console.WriteLine("task 2:");
Console.WriteLine($"result = {result}");

// task 3        
Console.WriteLine("Input number");
int s = int.Parse(Console.ReadLine());
int k = s % 10;
int c = (s % 100) / 10;
int d = s / 100;
Console.WriteLine("Reversed number: " + k + c + d);