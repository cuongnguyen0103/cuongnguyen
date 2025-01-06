namespace bai07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình.
            // khai bao
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int tong = 0;
            // thuc hien
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        tong += i;
                    }                    
                }
                Console.WriteLine("Tong cac so le tu 1 den {0} la {1}", n,tong);
            }
            else
                Console.WriteLine("Nhap so lon hon 0");
        }
    }
}
