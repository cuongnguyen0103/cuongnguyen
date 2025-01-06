namespace bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình.

            // Khai bao
            Console.WriteLine("Nhap so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            // Thuc hien
            if (n > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("{0} x {1} = {2}\t", j, i, j * i);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("n phai la so nguyen duong");
            }
        }
    }
}
