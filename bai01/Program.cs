namespace bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay 
            // không.Hiển thị kết quả ra màn hình.

            // Khai bao
            Console.WriteLine("Nhap so nguyen: ");
            int num = int.Parse(Console.ReadLine());
            // 
            if (num % 3 == 0)
            {
                Console.WriteLine("So nguyen: {0} chia het cho 3",num);
            }
            else
                Console.WriteLine("So nguyen: {0} khong chia het cho 3", num);
        }
    }
}
