using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7
{
    internal class Program
    {
        // Tao mang so nguyen ngau nhien
        static int[] TaoMangNgauNhien(int SoLuong, int MinVal = 1, int MaxVal = 100)
        {
            Random Rd = new Random();
            int[] Mang = new int[SoLuong];
            for (int I = 0; I < SoLuong; I++)
            {
                Mang[I] = Rd.Next(MinVal, MaxVal + 1);
            }
            return Mang;
        }

        // 1. Tinh gia tri trung binh cua mang
        static double TinhTrungBinh(int[] Mang)
        {
            double Tong = 0;
            foreach (int N in Mang) Tong += N;
            return Tong / Mang.Length;
        }

        // 2. Kiem tra mang co chua mot gia tri cu the khong
        static bool KiemTraTonTai(int[] Mang, int GiaTri)
        {
            foreach (int N in Mang)
            {
                if (N == GiaTri) return true;
            }
            return false;
        }

        // 3. Tim vi tri dau tien cua mot phan tu trong mang
        static int TimViTri(int[] Mang, int GiaTri)
        {
            for (int I = 0; I < Mang.Length; I++)
            {
                if (Mang[I] == GiaTri) return I;
            }
            return -1;
        }

        // 4. Xoa mot phan tu cu the xuat hien dau tien khoi mang
        static int[] XoaPhanTu(int[] Mang, int GiaTri)
        {
            int ViTri = TimViTri(Mang, GiaTri);
            if (ViTri == -1) return Mang;

            int[] MangMoi = new int[Mang.Length - 1];
            int J = 0;
            for (int I = 0; I < Mang.Length; I++)
            {
                if (I == ViTri) continue;
                MangMoi[J++] = Mang[I];
            }
            return MangMoi;
        }

        // 5. Tim gia tri lon nhat va nho nhat trong mang
        static void TimMaxMin(int[] Mang, out int Max, out int Min)
        {
            Max = Mang[0];
            Min = Mang[0];
            foreach (int N in Mang)
            {
                if (N > Max) Max = N;
                if (N < Min) Min = N;
            }
        }

        // 6. Dao nguoc mang
        static void DaoNguocMang(int[] Mang)
        {
            int Trai = 0, Phai = Mang.Length - 1;
            while (Trai < Phai)
            {
                int Temp = Mang[Trai];
                Mang[Trai] = Mang[Phai];
                Mang[Phai] = Temp;
                Trai++;
                Phai--;
            }
        }

        // 7. Tim cac gia tri bi trung lap trong mang
        static void TimGiaTriTrungLap(int[] Mang)
        {
            Console.Write("Cac gia tri trung lap: ");
            bool CoTrung = false;
            for (int I = 0; I < Mang.Length; I++)
            {
                for (int J = I + 1; J < Mang.Length; J++)
                {
                    if (Mang[I] == Mang[J])
                    {
                        Console.Write($"{Mang[I]} ");
                        CoTrung = true;
                        break;
                    }
                }
            }
            if (!CoTrung) Console.Write("Khong co");
            Console.WriteLine();
        }

        // 8. Xoa tat ca cac phan tu trung lap 
        static int[] XoaTrungLap(int[] Mang)
        {
            int SoLuongDuyNhat = 0;
            int[] Tam = new int[Mang.Length];

            foreach (int N in Mang)
            {
                if (!KiemTraTonTai(SubArray(Tam, SoLuongDuyNhat), N))
                {
                    Tam[SoLuongDuyNhat++] = N;
                }
            }

            int[] KetQua = new int[SoLuongDuyNhat];
            Array.Copy(Tam, KetQua, SoLuongDuyNhat);
            return KetQua;
        }
        static int[] SubArray(int[] Mang, int SoLuong)
        {
            int[] Ket = new int[SoLuong];
            Array.Copy(Mang, Ket, SoLuong);
            return Ket;
        }

        static void InMang(int[] Mang)
        {
            Console.WriteLine(string.Join(", ", Mang));
        }

        static void Main(string[] args)
        {
            int[] MangGoc = TaoMangNgauNhien(10, 1, 20);
            Console.Write("Mang goc: ");
            InMang(MangGoc);

            double TrungBinh = TinhTrungBinh(MangGoc);
            Console.WriteLine($"Gia tri trung binh: {TrungBinh:F2}");

            int GiaTriCanTim = MangGoc[0];
            bool CoTonTai = KiemTraTonTai(MangGoc, GiaTriCanTim);
            Console.WriteLine($"Mang co chua gia tri {GiaTriCanTim}? {CoTonTai}");

            int ViTriTim = TimViTri(MangGoc, GiaTriCanTim);
            Console.WriteLine($"Vi tri dau tien cua {GiaTriCanTim}: {ViTriTim}");

            int[] MangSauXoa = XoaPhanTu(MangGoc, GiaTriCanTim);
            Console.Write("Mang sau khi xoa mot phan tu: ");
            InMang(MangSauXoa);

            TimMaxMin(MangGoc, out int GiaTriMax, out int GiaTriMin);
            Console.WriteLine($"Gia tri lon nhat: {GiaTriMax} | Gia tri nho nhat: {GiaTriMin}");

            int[] MangDaoNguoc = (int[])MangGoc.Clone();
            DaoNguocMang(MangDaoNguoc);
            Console.Write("Mang sau khi dao nguoc: ");
            InMang(MangDaoNguoc);

            TimGiaTriTrungLap(MangGoc);

            int[] MangKhongTrung = XoaTrungLap(MangGoc);
            Console.Write("Mang sau khi xoa trung lap: ");
            InMang(MangKhongTrung);
        }
    }
}
     