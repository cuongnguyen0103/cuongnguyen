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
            // 4. In cac phan tu duy nhat
            Console.WriteLine("4. In cac phan tu duy nhat");
            Console.WriteLine("Cac phan tu duy nhat la: ");
            for (int i = 0; i<n;i++)
            {
                dem=0;
                // cac pt giong nhau sau vi tri hien tai
                for (int j = i+1;j<n;j++)
                {
                    if ((arr[i] == arr[j]))
                        {
                        dem++;
                        }
                }
                // cac pt giong nhau sau vi tri hien tai
                for (int k=0;k<i-1;k++)
                {
                    if (arr[i] == arr[k])
                    {
                        dem++;
                    }
                }
                if (dem==0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
            // 5. Chia mang ban dau thanh mang chan va mang le
            Console.WriteLine("5. Chia mang ban dau thanh mang chan va mang le");
            int[] arr_chan = new int[n];
            int[] arr_le = new int[n];
            int vt_chan = 0, vt_le = 0;
            for (int i = 0;i < n;i++)
            {
                if (arr[i]%2==0)
                {
                    arr_chan[vt_chan] = arr[i];
                    vt_chan++;
                }
                else
                {
                    arr_le[vt_le] = arr[i];
                    vt_le++;
                }
            }
            Console.WriteLine("Cac pt mang chan: ");
            for(int i = 0;i<vt_chan;i++)
            {
                Console.Write(arr_chan[i] +" ");
            }
            Console.WriteLine();
            Console.WriteLine("Cac pt mang le: ");
            for (int i = 0; i < vt_le; i++)
            {
                Console.Write(arr_le[i] + " ");
            }
            Console.WriteLine();
            // 6. Sap xep mang theo thu tu giam dan
            Console.WriteLine("6. Sap xep mang theo thu tu giam dan");
            int tmp = 0;
            int[] arr_giam = arr;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr_giam[i] < arr_giam[j])
                    {
                        tmp = arr_giam[i];
                        arr_giam[i] = arr_giam[j];
                        arr_giam[j] = tmp;
                    }
                }
            }
            Console.WriteLine("Mang arr theo th tu giam dan: ");
            for ( int i = 0; i < n;i++)
            {
                Console.Write(arr_giam[i] + " ");
            }
            Console.WriteLine();
            // 7. Tim kiem phan tu lon thu 2 cua mang ban dau
            Console.WriteLine("7. Tim kiem phan tu lon thu 2 cua mang ban dau");
            int biggestNum = arr[0];
            int secondNum = arr[0];
            for (int i = 0;i<n;i++)
            {
                if (biggestNum < arr[i])
                    biggestNum = arr[i];
                if (secondNum > arr[i])
                    secondNum = arr[i];
            }
            for (int i = 0;i<n;i++)
            {
                if (arr[i] == biggestNum)
                    continue;
                else
                {
                    if (secondNum < arr[i])
                        secondNum = arr[i];
                }
            }
            Console.WriteLine("Phan tu lon thu hai cua mang arr la: {0}",secondNum);
        }
    }
}
