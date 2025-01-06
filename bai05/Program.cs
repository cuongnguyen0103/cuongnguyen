namespace bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong tháng ra màn hình
            // khai bao
            Console.WriteLine("Nhap vao thang bat ky: ");
            int thang = int.Parse(Console.ReadLine());
            // thuc hien
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang {0} co 31 ngay", thang);
                    break;
                case 2:
                    Console.WriteLine("Thang {0} co 28 hoac 29 ngay", thang);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} co 28 hoac 29 ngay", thang);
                    break;
                default:
                    Console.WriteLine("Nhap so tu 1 den 12");
                    break;
            }
        }
    }
}
