//9. calculate area square
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;

Console.Write("Enter side of square:");
float sid = Convert.ToSingle(Console.ReadLine());
Console.WriteLine($"The area of the square is: {ar}");

//10. convert days to years, weeks and month
Console.Write("Enter number of days:");
float day = Convert.ToSingle(Console.ReadLine());
float years = day/365;
float months = day/30;
Console.WriteLine($"numbers of years: {years}; number of months = {months}");
//1.to Add / Sum two numbers
Console.Write("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int number2 =  Convert.ToInt32(Console.ReadLine());
int sum = number1 + number2;
Console.WriteLine($"{number1} + {number2} = {sum}");
//2. to swap Valuws of Two Variables
int temp = number1;
number1 = number2;
number2 = number1 ;
Console.WriteLine($"After swap number 1 = {number1}, number 2 = {number2}");
//3.  to Multiply two floating point number
float f1 = 3.5f, f2=2.7f;
float f3 = f1 + f2;
Console.WriteLine($"{f1}+{f2}={f3}");
// to convert feet to meter
Console.WriteLine("Enter you feet number:");
float feet = Convert.ToSingle(Console.ReadLine(), CultureInfo.InvariantCulture);
const float rate = 0.3048f;
float meter = rate * feet;
Console.WriteLine($"{feet}feet = {meter}meter.");
//5. To convert celsius to fahrenheit and vice versa 
float cels = 27f ;
float fah = cels * 1.8f +32 ;
Console.WriteLine($"{cels} C = {fah} F");
//6. to find size of data 
Console.WriteLine($"Size of double data type is {sizeof(double)}");
Console.WriteLine($"Size of int data type is {sizeof(int)}");
//7.To print ASCII value
Console.WriteLine("Enter a character :");
int c = Console.Read();
Console.ReadLine();
Console.WriteLine($"ASCII code of {(char)c} is {c}");
//8. to calculate area of circle 
Console.WriteLine("Enter radius of cricle:");
float rad = Convert.ToSingle(Console.ReadLine());
float area = rad * rad * 3.14f ;
Console.WriteLine($"The area of cricle is : {area}");
Console.WriteLine("Press any key to continue.....");
Console.ReadKey();