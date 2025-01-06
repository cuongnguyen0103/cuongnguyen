namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình
            // 0 1 1 2 3 5 8 13 21 34
            // khai bao
            Console.WriteLine("Nhap so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            // thuc hien
            Console.WriteLine(" Day Fibonacci: ");
            if (n == 0)
                Console.Write(a + " ");
            else if (n == 1)
                Console.Write(b + " ");
            else if (n > 1)
            {
                Console.Write(a + " " + b + " ");
                for (int i = 2; i <= n; i++)
                {
                    int c = a + b;
                    Console.Write(c + " ");
                    //int temp = a;
                    a = b;
                    b = c;
                }
            }
            else
                Console.WriteLine("Phai nhap so nguyen duong");
        }
    }
}
