namespace bai5_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào mảng gồm n phần tử, với giá trị n được nhập từ người dùng.            
            Console.WriteLine("Nhap gia tri n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            // 1. Đọc và in các phần tử trong mảng vừa nhập.
            Console.WriteLine("1. Đọc và in các phần tử trong mảng vừa nhập.");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu arr[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine();
            }
            Console.Write("Mang arr voi {0} phan tu gom: ", n);
            for (int i = 0;i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            //// 2. In mảng dữ liệu trên theo chiều đảo ngược.
            //Console.WriteLine("2. In mảng dữ liệu trên theo chiều đảo ngược.");
            //Console.WriteLine("Cach 1: Dung for");
            //for (int i = n-1;i>=0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Cach 2: Dung ham Reverse");
            //Array.Reverse(arr);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            // 3. Tìm số phần tử giống nhau trong mảng và hiển thị số lượng giống nhau ra màn hình.
            Console.WriteLine("3. Tìm số phần tử giống nhau trong mảng và hiển thị số lượng giống nhau ra màn hình.");
            int[] arr_ = new int[n];
            for (int i = 0;i<n; i++)
            {
                arr_[i] = -1;
            }
            int dem;
            for(int i = 0;i<n; i++)
            {
                dem = 1;
                for(int j = i+1;j<n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        dem++;
                        arr_[j] = 0;
                    }
                }
                if (arr_[i] != 0)
                {
                    arr_[i] = dem;
                }
            }
            for (int i = 0;i<n;i++)
            {
                if (arr_[i] != 0)
                {
                    Console.WriteLine("Phan tu giong nhau trong mang arr la {0} voi so luong la {1}", arr[i], arr_[i]);
                   
                }
            }
        }
    }
}
