using System;

namespace Week_6 //
{
    class Program //
    {
      public static void Main(string[] args)
    
           { Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== BÀI 1: TÍNH TỔNG ===");
            int a = 5;
            int b = 10;
            int ketQua = TinhTong(a, b);
            Console.WriteLine($"Tổng của {a} và {b} là: {ketQua}");
            // InFibonacci(10);
            // TinhLuyThua(2, 3);
            // Console.WriteLine($"2^3 = {TinhLuyThua(2, 3)}");

    // Gọi hàm và lưu kết quả true/false vào biến 'ketQua'
    bool ketQua1 = KiemTraDoiXung("radar"); // kq1 = true
    bool ketQua2 = KiemTraDoiXung("hello"); // kq2 = false
    Console.WriteLine("radar: " + ketQua1);
    Console.WriteLine("hello: " + ketQua2);}
            
           
           
// Bai 3 find max
static int FindMax(int a, int b, int c)
{
    return Math.Max(a, Math.Max(b, c));
}

// Bai 2 
static bool KiemTraChanLe   (int n)
{
    return n % 2 == 0;
}
//bai 1
static int TinhTong(int a, int b) 
{
    return a + b;
}
//bai 5
static string DaoNguocChuoi(string huy)
        {
            char[] charArray = huy.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }    
//bai 4
static long TinhGiaiThua(long n)
        {
            long result = 1;
            for (long i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
//bai 6
static bool KiemTraSoNguyenTo (int n)
        {
            if (n <= 1)
                return false;
            else if (n <= 3)
                return true;
            else if (n % 2 == 0 || n % 3 == 0)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
//bai 7
static void InFibonacci(int n)
        {
            int a = 0; int b = 1;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{a} ");
                int next = a + b;
                a = b;
                b = next;
            }
        }
//bai 8
static int DemNguyenAm(string s)
            {
                
               char[] result = s.ToLower().ToCharArray();
               int count = 0;
               foreach (char c in result)
                {
                    if (c=='a'||c=='e'||c=='i'||c=='o'||c=='u')
                    {
                        count++;
                    }
                }
                return count;
            }
        //Bai9
        static double TinhLuyThua(double x, int y)
            {
                double result = 1;
                if (y == 0)
                {
                    return result;
                }
                 else if (y < 0)
                {
                    for (int i = 0; i < y; i++)
                    {
                        result *= x;
                    }
                    return 1 / result;
                }
                else
                {
                    for (int i = 0; i < y; i++)
                    {
                        result *= x;
                    }
                }
                return result;

            }
            //bai 10 
            static double TinhTrungBinh(int[] avg)
            {
                int sum = 0 ;
                foreach (int num in avg)
                {
                    sum += num;
                }
                return (double)sum / avg.Length;
            }
        //bai 11
        static bool KiemTraDoiXung(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray);
                if ( reversed == s)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           //bai 12
           static double CelsiusToFahrenheit(double c)
            {
                return (c * 9 / 5) + 32;
            }
            //bai 13
            static int TimMin(int[] arr)
            {
             return arr.Min();  
            }
            //bai14
            static int TongCacChuSo(int n)
        {
            n = Math.Abs(n);
            int chucuoi = n%10;
            n = n/10;
            int tong = chucuoi;
            while (n>0)
            {
                chucuoi = n%10;
                n = n/10;
                tong += chucuoi;
            }
            return tong;
        }
        //bai15
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine($"Mảng sau khi sắp xếp: {string.Join(" ", arr)}");
        }
        //bai16
       static string XoaTrungLap(string s)
    {
        string ketQua = "";
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            bool daCo = false;
            for (int j = 0; j < ketQua.Length; j++)
            {
                if (ketQua[j] == c)
                {
                    daCo = true;
                    break;
                }
            }
            if (!daCo)
            {
                ketQua = ketQua + c;
            }
        }
        return ketQua;
    }
//bai17
    static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
//bai18
    static string DecimalToBinary(int n)
    {
        if (n == 0)
        {
            return "0";
        }
        string ketQua = "";
        while (n > 0)
        {
            int du = n % 2;
            ketQua = du + ketQua;
            n = n / 2;
        }
        return ketQua;
    }
//bai19
    static bool KiemTraNamNhuan(int year)
    {
        if (year % 4 == 0 && year % 100 != 0)
        {
            return true;
        }
        else if (year % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
//bai 20
     static int DemSoTu(string sentence)
    {
        sentence = sentence.Trim();
        if (sentence == "")
        {
            return 0;
        }

        int dem = 1;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                dem = dem + 1;
            }
        }
        return dem;
    }
}
    }
}


        
            
