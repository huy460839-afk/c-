Console.WriteLine("Nhập cạnh a: ");
           double a = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Nhập cạnh b: ");
            double b = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Nhập cạnh c: ");
           double c = Convert.ToDouble(Console.ReadLine());
           if(a < 0&& b < 0&& c < 0 || a+b<c&& a+c<b&& b+c<a)
            {
                
                Console.WriteLine("Không phải là tam giác");
                return;
            }
            else if(a==b&&b==c)
            {
                Console.WriteLine("Là tam giác đều");
            }
            else if(a==b||a==c||b==c)
            {
                Console.WriteLine("là tam giác cân");
            }
            else
            {
                Console.WriteLine("tam giac binh thuong");
            }
// Write a program to read 10 numbers and find their average and sum
Console.WriteLine("Nhap 10 so bat ki: ");
// nhap 10 so tu ban phim
double sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Nhap so thu {i + 1}: ");
    double number = Convert.ToDouble(Console.ReadLine());
    sum += number;
}
double average = sum / 10;
Console.WriteLine($"Tổng của 10 số là: {sum}");
Console.WriteLine($"Trung bình của 10 số là: {average}");
//display the multiplication table of a given integer
Console.WriteLine("Nhap mot so de hien thi bang cuu chuong: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Bang cuu chuong cua {n} la:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}
// display a pattern like triangles with a number. 
Console.WriteLine("Nhap mot so de hien thi tam giac: ");
double rows = Convert.ToDouble(Console.ReadLine());
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}
// find the ‘perfect’ numbers within a given number range. A perfect number is a positive integer that is equal to the sum of its proper positive divisors, that is, the sum of its positive divisors excluding the number itself.
Console.WriteLine("Nhap so bat ki de tim so hoan hao: ");
double n = Convert.ToDouble(Console.ReadLine());
for (double i = 1; i <= n; i++)
{
    double sum = 0;
    for (double j = 1; j < i; j++)
    {
        if (i % j == 0)
        {
            sum += j;
        }
    }
    if (sum == i)
    {
        Console.WriteLine($"{i} là số hoàn hảo");
    }
}
//determine whether a given number is prime or not.
Console.WriteLine("Nhap mot so de kiem tra xem co phai so nguyen to khong: ");
double num = Convert.ToDouble(Console.ReadLine());
bool isPrime = true;
if (num <= 1)
{
    isPrime = false;
}
else
{
    for (double i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}
if (isPrime)
{
    Console.WriteLine($"{num} là số nguyên tố");
}
else
{
    Console.WriteLine($"{num} không phải là số nguyên tố");
}
//display the n terms of harmonic series and their sum
Console.WriteLine("Nhap so n de hien thi chuoi harmonic: ");
double n = Convert.ToDouble(Console.ReadLine());
double sum = 0;
for (double i = 1; i <= n; i++)
{
    sum += 1 / i;
}
Console.WriteLine($"Tong cua {n} so hang cua chuoi harmonic la: {sum}");

