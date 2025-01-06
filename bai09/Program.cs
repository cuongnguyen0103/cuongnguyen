namespace bai09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 9: Viết chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng. Ví dụ, 
            // nhập vào 10 hàng, thì ta sẽ được 1 tam giác như hình bên dưới. Có thể thử vẽ thêm với
            // hình tam giác đều, tam giác xoay ngược.
            // khai bao
            Console.WriteLine("Nhap vao so hang: ");
            int n = int.Parse(Console.ReadLine());
            // thuc hien
            if (n > 0)
            {
                Console.WriteLine("Tam giac sao:");
                for (int i = 1; i <= n; i++)
                {                  
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }                
            }
            else
                Console.WriteLine("Nhap so nguyen lon hon 0");
        }
    }
}
