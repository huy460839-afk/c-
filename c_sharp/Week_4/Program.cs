namespace Workspace;
 using System;
            using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chọn bài tập (1-5):");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    bt1();
                    break;
                case 2:
                    bt2();
                    break;
                case 3:
                    bt3();
                    break;
                case 4:
                    bt4();
                    break;
                case 5:
                    bt5();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }

    }
        
        static void bt1()
        {
Console.WriteLine(" Enter coefficient a: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Enter coefficient b: ");
float b = float.Parse(Console.ReadLine());
Console.WriteLine("Enter coefficient c: ");
float c = float.Parse(Console.ReadLine());
if (a == 0 && b == 0 && c == 0)
{
    Console.WriteLine($"Phuong trinh {a}x^2 + {b}x + {c} = 0 co vo so nghiem.");
}
else if (a == 0 && b == 0)
{
    Console.WriteLine($"Phuong trinh {a}x^2 + {b}x + {c} = 0 vo nghiem.");
}
else if (a == 0)
{
    Console.WriteLine($"Phuong trinh {a}x^2 + {b}x + {c} = 0 co nghiem duy nhat: x = {-c / b}");
}
else
{
    float bt = b * b - 4 * a * c;
    if (bt > 0)
    {
        float x1 = (-b + MathF.Sqrt(bt)) / (2 * a);
        float x2 = (-b - MathF.Sqrt(bt)) / (2 * a);
        Console.WriteLine($"Phuong trinh {a}x^2 + {b}x + {c} = 0   co hai nghiem phan biet: {x1} va {x2}");
    }
    else if (bt == 0)
    {
        Console.WriteLine($"Phuong trinh {a}x^2 + {b}x + {c} = 0 co nghiem kep: x1 = x2 = {-b / (2 * a)}");
    }
    else
    {
        Console.WriteLine($"Phuong trinh {a}x^2 + {b}x + {c} = 0 vo nghiem .");
    }
}
        }

        static void bt2()
        {
           //nhập số nguyên n từ bàn phím
           Console.WriteLine("Nhập số nguyên n: ");
           int n = Convert.ToInt32(Console.ReadLine());
           if (n < 0)
           {
               Console.WriteLine("Số nguyên n phải là số nguyên dương.");
               return;
           }
           else if (n % 2 == 0)
           {
               Console.WriteLine("Số nguyên n là số chẵn.");
           }
           else
           {
               Console.WriteLine("Số nguyên n là số lẻ.");
           }
        }
        static void bt3()
        {
            Console.WriteLine("Nhập số x1: ");
            float n = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhập số x2: ");
            float m = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhập số x3: ");
            float p = Convert.ToSingle(Console.ReadLine());
            float max = Math.Max(n, Math.Max(m, p));
            Console.WriteLine($"Số lớn nhất là: {max}");
        }
        static void bt4()
        {
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
            else if(a==b||a==c|b==c)
            {
                Console.WriteLine("là tam giác cân");
            }
            else
            {
                Console.WriteLine("tam giac binh thuong");
            }
        }
        static void bt5()
        {
            Console.WriteLine("Nhap X:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Y:");
            double y = double.Parse(Console.ReadLine());
            if(x>0&&y>0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam o goc phan tu thu 1");
            }
            else if(x<0&&y>0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam o goc phan tu thu 2");
            }
            else if(x<0&&y<0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam o goc phan tu thu 3");
            }
             else if(x>0&&y<0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam o goc phan tu thu 4");
            }
            else
            {
                Console.WriteLine($"Toa do ({x},{y}) nam o goc toa do");
            }
        }
        }
           

        
