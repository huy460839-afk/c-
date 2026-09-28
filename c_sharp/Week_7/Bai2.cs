using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7
{
    internal class Bai2
    {
        // Sap xep mang so nguyen bang thuat toan Bubble Sort
        static void BubbleSort(int[] Mang)
        {
            int N = Mang.Length;
            for (int I = 0; I < N - 1; I++)
            {
                for (int J = 0; J < N - 1 - I; J++)
                {
                    if (Mang[J] > Mang[J + 1])
                    {
                        int Tam = Mang[J];
                        Mang[J] = Mang[J + 1];
                        Mang[J + 1] = Tam;
                    }
                }
            }
        }

        // Tim kiem tuyen tinh mot tu trong mang cac tu cua cau
        static int TimKiemTuyenTinh(string[] MangTu, string TuCanTim)
        {
            for (int I = 0; I < MangTu.Length; I++)
            {
                if (MangTu[I].Equals(TuCanTim, StringComparison.OrdinalIgnoreCase))
                {
                    return I;
                }
            }
            return -1;
        }
        static void InMangSo(int[] Mang)
        {
            Console.WriteLine(string.Join(" ", Mang));
        }

        static void Main(string[] args)
        {
            // 1. Nhap 10 so nguyen va sap xep bang thuat toan bubble sort
            int SoLuongPhanTu = 10;
            int[] MangSo = new int[SoLuongPhanTu];

            Console.WriteLine("Nhap 10 so nguyen:");
            for (int I = 0; I < SoLuongPhanTu; I++)
            {
                Console.Write($"So thu {I + 1}: ");
                MangSo[I] = int.Parse(Console.ReadLine());
            }

            Console.Write("Mang truoc khi sap xep: ");
            InMangSo(MangSo);

            BubbleSort(MangSo);

            Console.Write("Mang sau khi sap xep (Bubble Sort): ");
            InMangSo(MangSo);

            Console.WriteLine();

            // 2. Tim kiem tuyen tinh mot tu trong mang cac tu cua cau
            Console.Write("Nhap mot cau: ");
            string Cau = Console.ReadLine();

            Console.Write("Nhap tu can tim: ");
            string TuCanTim = Console.ReadLine();

            string[] MangTu = Cau.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int ViTriTim = TimKiemTuyenTinh(MangTu, TuCanTim);

            if (ViTriTim != -1)
            {
                Console.WriteLine($"Tim thay tu \"{TuCanTim}\" tai vi tri {ViTriTim} trong cau.");
            }
            else
            {
                Console.WriteLine($"Khong tim thay tu \"{TuCanTim}\" trong cau.");
            }
        }
    }
}