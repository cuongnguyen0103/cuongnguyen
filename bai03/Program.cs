namespace bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 3: Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình.
            // khai bao
            Console.WriteLine("Nhap so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            int tong = 1;
            // thuc hien
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    tong = tong * i;
                }
                Console.WriteLine("Tong giai thua cua so nguyen {0} la: {1}", n,tong);
            }
            else
                Console.WriteLine("n phai lon hon 0");

        }
    }
}
