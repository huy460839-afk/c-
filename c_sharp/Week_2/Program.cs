//convert cel to fah and kelvin
Console.WriteLine("Enter temperature in Celsius:");
float celsius = Convert.ToSingle(Console.ReadLine());
float fahrenheit = (celsius * 18 / 10) + 32;
float kelvin = celsius + 273f;
Console.WriteLine($"{celsius}°C = {fahrenheit}°F = {kelvin}K");
//Calculate surface and volume of sphere
Console.WriteLine("Enter radius of sphere:");
float radius = Convert.ToSingle(Console.ReadLine());
float surface = 4 * 3.14f * radius * radius;
float volume = (4f / 3f) * 3.14f * radius * radius * radius;
Console.WriteLine($"Surface area is {surface}");
Console.WriteLine($"Volume is {volume}");
// adding two numbers
Console.WriteLine("Enter first number:");
float num1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter second number:");
float num2 = Convert.ToSingle(Console.ReadLine());
float sum = num1 + num2;
float minus = num1 - num2;
float multiply = num1 * num2;
float divide = num1 / num2;
float mod = num1 % num2;
Console.WriteLine($"{num1} + {num2} = {sum}");
Console.WriteLine($"{num1} - {num2} = {minus}");
Console.WriteLine($"{num1} * {num2} = {multiply}");
Console.WriteLine($"{num1} / {num2} = {divide}");
Console.WriteLine($"{num1} % {num2} = {mod}");
