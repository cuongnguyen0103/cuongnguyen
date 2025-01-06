namespace bai08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n.
            // khai bao
            Console.WriteLine("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            // thuc hien
            Console.WriteLine("Cac so nguyen ro trong khoang tu 1 den {0} gom: ",n);
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    int dem = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i%j == 0)
                        {
                            dem += 1;
                        }                        
                    }
                    if (dem == 2)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
                Console.WriteLine("Nhap so nguyen lon hon 0");
        }
    }
}
