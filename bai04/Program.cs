namespace bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là 
            // số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
            // khai bao
            Console.WriteLine("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            // thuc hien
            int khai_can = (int)Math.Sqrt(n);
            if (khai_can * khai_can == n)
            {
                Console.WriteLine("{0} la so chinh phuong", n);
            }
            else
            {
                Console.WriteLine("{0} khong la so chinh phuong", n);
            }
        }
    }
}
