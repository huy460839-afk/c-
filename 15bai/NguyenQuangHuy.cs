namespace Workspace;
    class IMissHer
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Bai1();
            //Bai2();
            Bai3();
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
        }

    }