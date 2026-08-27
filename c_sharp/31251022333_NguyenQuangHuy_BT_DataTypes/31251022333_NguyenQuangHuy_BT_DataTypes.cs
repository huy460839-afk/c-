namespace Workspace;
 using System;
            using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chọn bài tập (1-9):");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Bai1();
                    break;
                case 2:
                    Bai2();
                    break;
                case 3:
                    Bai3();
                    break;
                case 4:
                    Bai4();
                    break;
                case 5:
                    Bai5();
                    break;
                case 7:
                    Bai7();
                    break;
                case 9:
                    Bai9();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }

    }
        
        static void Bai1()
        {
                    //nhập số điện{}
        Console.WriteLine("Nhập số điện cũ (kWh):");
        float oldkWh = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Nhập số điện mới (kWh):");
        float newkWh = Convert.ToSingle(Console.ReadLine());
        float consumption = newkWh - oldkWh;
        Console.WriteLine($"Số điện tiêu thụ: {consumption} kWh");
        //tính tiền điện chưa thuế
        double bill = 0;
        if (consumption > 300)
        {
            bill += (consumption - 300) * 3050;
            consumption = 300;
        }
        if (consumption > 200)
        {
            bill += (consumption - 200) * 2729;
            consumption = 200;
        }
        if (consumption > 100)
        {
            bill += (consumption - 100) * 2167;
            consumption = 100;
        }
        if (consumption > 50)
        {
            bill += (consumption - 50) * 1866;
            consumption = 50;
        }
        if (consumption > 0)
        {
            bill += consumption * 1806;
        }
        Console.WriteLine($"Tiền điện chưa thuế: {bill : #,##0} VND");
        Console.WriteLine($"Tiền thuế VAT (8%): {bill * 0.08 : #,##0} VND");
        Console.WriteLine($"Tổng thanh toán: {bill * 1.08 : #,##0} VND");
        }
        static void Bai2()
        {
            //input height and weight
            Console.WriteLine("Enter height in meters:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter weight in kilograms:");
            double weight = Convert.ToDouble(Console.ReadLine());
            // calculate BMI
            double BMI = weight / (height * height);
            Console.WriteLine($": Chỉ số BMI của bạn là: {BMI:F2}");
            if (BMI < 18.5)
            {
                Console.WriteLine("Phân loại sức khỏe : Gầy ( Thiếu cân)");
            }
            else if (BMI >= 18.5 && BMI < 23)
            {
                Console.WriteLine("Phân loại sức khỏe : Bình thường");
            }
            else if (BMI >= 23 && BMI < 25)
            {
                Console.WriteLine("Phân loại sức khỏe : Thừa cân.");
            }
            else
            {
                Console.WriteLine("Phân loại sức khỏe : Béo phì.");
            }
            double min = 18.5 * height * height;
            double max = 22.9 * height * height;
            Console.WriteLine($": Khuyên dùng : Cân nặng lý tưởng của bạn nên từ {min:F2} kg đến {max:F2} kg");
        }
        static void Bai3()
        {
            Console.WriteLine("Nhập số tiền VNĐ:");
            double vnd = Convert.ToDouble(Console.ReadLine());
            double usd = vnd / 25400f;
            double eur = vnd / 27200f;
            double jpy = vnd / 165f;
            double GBP = vnd / 32100f;
            Console.WriteLine("Chọn loại tiền tệ để đổi((1-USD, 2-EUR, 3-JPY, 4-GBP):");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Phí dịch vụ: {(vnd * 0.005) :F2} VND");
            Console.WriteLine($"Số tiền sau khi trừ phí dịch vụ: {(vnd * 0.995) :F2} VND");
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Số tiền USD: {usd:F2}");
                    break;
                case 2:
                    Console.WriteLine($"Số tiền EUR: {eur:F2}");
                    break;
                case 3:
                    Console.WriteLine($"Số tiền JPY: {jpy:F2}");
                    break;
                case 4:
                    Console.WriteLine($"Số tiền GBP: {GBP:F2}");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
        static void Bai4()
        {
           
            //input date birthday 
            Console.WriteLine("Nhập ngày sinh (dd/MM/yyyy):");
            string input = Console.ReadLine();
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime BD))
            {
                Console.WriteLine("Định dạng ngày sinh không hợp lệ.");
                return;
            }
            // tinh tuoi 
           int age = DateTime.Today.Year - BD.Year;
            if (BD > DateTime.Today.AddYears(-age))
        {
            age -= 1;
        }
        Console.WriteLine($"Tuổi hiện tại: {age} tuổi.");
        // ban da song tong cong 
        TimeSpan Lifespan = DateTime.Today - BD;
        Console.WriteLine($"Bạn đã sống tổng cộng {Lifespan.Days} ngày.");
        // tinh ngay sinh nhat ke tiep
        DateTime nextBD = new DateTime(DateTime.Today.Year, BD.Month, BD.Day);
        if (nextBD < DateTime.Today)
        {
           nextBD = nextBD.AddYears(1);
            Console.WriteLine($"sinh nhật tiếp theo con: {(nextBD - DateTime.Today).Days} ngày nữa.");
        }
        else
        {
            Console.WriteLine($"sinh nhật tiếp theo con: {(nextBD - DateTime.Today).Days} ngày nữa.");
         }   
        }
        static void Bai5()
        {
            //Nhap diem so va tin chi cho 3 mon hoc
            // dung dau , thay cho dau cham khi nhap diem so
            Console.WriteLine("Nhập số tín chỉ cho môn học 1:");
            int tc1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập điểm số (0-10):");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ cho môn học 2:");
            int tc2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập điểm số (0-10):");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ cho môn học 3:");
            int tc3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập điểm số (0-10):");
            double m3 = Convert.ToDouble(Console.ReadLine());
            // tinh diem trung binh trong so
            double a = (m1 * tc1) + (m2 * tc2) + (m3 * tc3);
            double b = (tc1 + tc2 + tc3);
            double avg = (a) / (b);
            Console.WriteLine($"Điểm TB thang 10: {avg:F2}");
           if (avg >= 8.5)
            {
                Console.WriteLine("Điểm chu quy doi: A");
                Console.WriteLine("Điểm GPA thang 4: 4.0");
                Console.WriteLine("Xếp loại: Xuat sac");
            }
            else if (avg >= 7 && avg < 8.5)
            {
                Console.WriteLine("Điểm chu quy doi: B");
                Console.WriteLine("Điểm GPA thang 4: 3.0");
                Console.WriteLine("Xếp loại: Khá");
            }
            else if (avg >= 5.5 && avg < 7)
            {
                Console.WriteLine("Điểm chu quy doi: C");
                Console.WriteLine("Điểm GPA thang 4: 2.0");
                Console.WriteLine("Xếp loại: Trung bình");
            }
            else if (avg >= 4 && avg < 5.5)
            {
                Console.WriteLine("Điểm chu quy doi: D");
                Console.WriteLine("Điểm GPA thang 4: 1.0");
                Console.WriteLine("Xếp loại: Yếu");
            }
            else
            {
                Console.WriteLine("Điểm chu quy doi: F");
                Console.WriteLine("Điểm GPA thang 4: 0.0");
                Console.WriteLine("Xếp loại hoc luc: Kém");
            }
        }
        static void Bai7()
        {
            // input
        Console.Write("Quãng đường (km): ");
        double quangduong = double.Parse(Console.ReadLine());
        Console.Write("Mức tiêu hao (L/100km): ");
        double tieuHao = double.Parse(Console.ReadLine());
        //Gia xang nhap kh dau . hay ,
        Console.Write("Giá xăng (VNĐ/Lít): ");
        decimal giaXang = decimal.Parse(Console.ReadLine());
        Console.Write("Số người đi: ");
        int nguoi = int.Parse(Console.ReadLine());
        // sum
        double tongSoLit = (quangduong / 100) * tieuHao;
        decimal tongChiPhi = (decimal)tongSoLit * giaXang;
        // sum cost
        decimal chiPhiChuaLamTron = tongChiPhi / nguoi ;
        decimal chiPhiMoiNguoi = (decimal)Math.Ceiling((double)chiPhiChuaLamTron / 1000) * 1000;
        Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tongSoLit:0.00} Lít");
        Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi:N0} VNĐ");
        Console.WriteLine($"Chi phí mỗi người: {chiPhiMoiNguoi:N0} VNĐ");
        }
        static void Bai9()
    {
        Console.Write("Nhập lương Gross: ");
        decimal gross = decimal.Parse(Console.ReadLine());
        Console.Write("Nhập số người phụ thuộc: ");
        int PT = int.Parse(Console.ReadLine());
        // BH và tnct
        decimal BH = gross * 0.105m;
        decimal tnct = gross - BH - 11000000m - (PT * 4400000m);
        if (tnct < 0) tnct = 0; 
        //tinh tncn
        decimal thue = 0m;
        if (tnct > 80000000m)      thue = tnct * 0.35m - 9850000m;
        else if (tnct > 52000000m) thue = tnct * 0.30m - 5850000m;
        else if (tnct > 32000000m) thue = tnct * 0.25m - 3250000m;
        else if (tnct > 18000000m) thue = tnct * 0.20m - 1650000m;
        else if (tnct > 10000000m) thue = tnct * 0.15m - 750000m;
        else if (tnct > 5000000m)  thue = tnct * 0.10m - 250000m;
        else if (tnct > 0)        thue = tnct * 0.05m;
        //Lương Net
        decimal net = gross - BH - thue;
        //print
        Console.WriteLine($"Bảo hiểm trừ: {BH:N0} VNĐ");
        Console.WriteLine($"Thuế TNCN nộp: {thue:N0} VNĐ");
        Console.WriteLine($"LƯƠNG NET:{net:N0} VNĐ");
    }
}
    

    

