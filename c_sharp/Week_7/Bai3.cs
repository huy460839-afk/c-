using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7
{
    internal class Bai3
    {
        // Tao ma tran so nguyen ngau nhien kich thuoc N x M
        static int[,] TaoMaTranNgauNhien(int N, int M, int MinVal = 1, int MaxVal = 100)
        {
            Random Rd = new Random();
            int[,] MaTran = new int[N, M];
            for (int I = 0; I < N; I++)
            {
                for (int J = 0; J < M; J++)
                {
                    MaTran[I, J] = Rd.Next(MinVal, MaxVal + 1);
                }
            }
            return MaTran;
        }

        // In toan bo ma tran ra man hinh
        static void InMaTran(int[,] MaTran)
        {
            int N = MaTran.GetLength(0);
            int M = MaTran.GetLength(1);
            for (int I = 0; I < N; I++)
            {
                for (int J = 0; J < M; J++)
                {
                    Console.Write($"{MaTran[I, J],5}");
                }
                Console.WriteLine();
            }
        }

        // In hang thu I cua ma tran (I bat dau tu 0)
        static void InHang(int[,] MaTran, int ChiSoHang)
        {
            int M = MaTran.GetLength(1);
            for (int J = 0; J < M; J++)
            {
                Console.Write($"{MaTran[ChiSoHang, J],5}");
            }
            Console.WriteLine();
        }

        // In cot thu I cua ma tran 
        static void InCot(int[,] MaTran, int ChiSoCot)
        {
            int N = MaTran.GetLength(0);
            for (int I = 0; I < N; I++)
            {
                Console.Write($"{MaTran[I, ChiSoCot],5}");
            }
            Console.WriteLine();
        }

        // Tim gia tri lon nhat trong toan bo ma tran
        static int TimMaxMaTran(int[,] MaTran)
        {
            int N = MaTran.GetLength(0);
            int M = MaTran.GetLength(1);
            int Max = MaTran[0, 0];
            for (int I = 0; I < N; I++)
            {
                for (int J = 0; J < M; J++)
                {
                    if (MaTran[I, J] > Max) Max = MaTran[I, J];
                }
            }
            return Max;
        }

        // Tim gia tri nho nhat trong hang thu I
        static int TimMinHang(int[,] MaTran, int ChiSoHang)
        {
            int M = MaTran.GetLength(1);
            int Min = MaTran[ChiSoHang, 0];
            for (int J = 0; J < M; J++)
            {
                if (MaTran[ChiSoHang, J] < Min) Min = MaTran[ChiSoHang, J];
            }
            return Min;
        }

        // Tim gia tri nho nhat trong cot thu I
        static int TimMinCot(int[,] MaTran, int ChiSoCot)
        {
            int N = MaTran.GetLength(0);
            int Min = MaTran[0, ChiSoCot];
            for (int I = 0; I < N; I++)
            {
                if (MaTran[I, ChiSoCot] < Min) Min = MaTran[I, ChiSoCot];
            }
            return Min;
        }

        // Chuyen vi ma tran 
        static int[,] ChuyenViMaTran(int[,] MaTran)
        {
            int N = MaTran.GetLength(0);
            int M = MaTran.GetLength(1);
            int[,] MaTranMoi = new int[M, N];
            for (int I = 0; I < N; I++)
            {
                for (int J = 0; J < M; J++)
                {
                    MaTranMoi[J, I] = MaTran[I, J];
                }
            }
            return MaTranMoi;
        }

        // In duong cheo chinh cua ma tran vuong
        static void InDuongCheoChinh(int[,] MaTran)
        {
            int N = MaTran.GetLength(0);
            for (int I = 0; I < N; I++)
            {
                Console.Write($"{MaTran[I, I],5}");
            }
            Console.WriteLine();
        }

        // In duong cheo phu cua ma tran vuong
        static void InDuongCheoPhu(int[,] MaTran)
        {
            int N = MaTran.GetLength(0);
            for (int I = 0; I < N; I++)
            {
                Console.Write($"{MaTran[I, N - 1 - I],5}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so hang N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot M: ");
            int M = int.Parse(Console.ReadLine());

            int[,] MaTran = TaoMaTranNgauNhien(N, M, 1, 50);

            Console.WriteLine();
            Console.WriteLine("Ma tran vua tao:");
            InMaTran(MaTran);

            Console.WriteLine();
            Console.Write($"Nhap chi so hang can in (0 den {N - 1}): ");
            int ChiSoHang = int.Parse(Console.ReadLine());
            Console.Write($"Hang thu {ChiSoHang}: ");
            InHang(MaTran, ChiSoHang);

            Console.Write($"Nhap chi so cot can in (0 den {M - 1}): ");
            int ChiSoCot = int.Parse(Console.ReadLine());
            Console.Write($"Cot thu {ChiSoCot}: ");
            InCot(MaTran, ChiSoCot);

            Console.WriteLine();
            int GiaTriMax = TimMaxMaTran(MaTran);
            Console.WriteLine($"Gia tri lon nhat cua ma tran: {GiaTriMax}");

            int MinCuaHang = TimMinHang(MaTran, ChiSoHang);
            Console.WriteLine($"Gia tri nho nhat cua hang {ChiSoHang}: {MinCuaHang}");

            int MinCuaCot = TimMinCot(MaTran, ChiSoCot);
            Console.WriteLine($"Gia tri nho nhat cua cot {ChiSoCot}: {MinCuaCot}");

            Console.WriteLine();
            int[,] MaTranChuyenVi = ChuyenViMaTran(MaTran);
            Console.WriteLine("Ma tran sau khi chuyen vi:");
            InMaTran(MaTranChuyenVi);

            Console.WriteLine();
            if (N == M)
            {
                Console.Write("Duong cheo chinh: ");
                InDuongCheoChinh(MaTran);

                Console.Write("Duong cheo phu: ");
                InDuongCheoPhu(MaTran);
            }
            else
            {
                Console.WriteLine("Ma tran khong vuong (N != M) nen khong co duong cheo.");
            }
        }
    }
}