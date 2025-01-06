namespace bai06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 6: Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức sau và hiển thị kết quả ra màn hình.
            // S = 1 + 2^2 + 3^3 + 4^4 + ... + n^n

            // Khai bao
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            // thuc hien
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    S += i * i;
                }
                Console.WriteLine("Tong S voi n = {0} la: {1}",n, S);
            }
            else
            {
                Console.WriteLine("Nhap so lon hon 0");
            }
        }
    }
}
