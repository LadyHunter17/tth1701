using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Viết CT in số lớn thứ 2 và số nhỏ thứ 2 trong list, in ra vị trí index của số đó
namespace Csharp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào số phần tử của danh sách: ");
            int n = int.Parse(Console.ReadLine());
            List<double> ds1 = new List<double>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Mời nhập vào phần tử thứ {0} của danh sách", i + 1);
                ds1.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Danh sách bạn vừa nhập là: ");
            foreach (double d in ds1)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();
            List<double> ds2 = new List<double>();
            ds2.AddRange(ds1);
            ds2.Remove(ds2.Max());
            ds2.Remove(ds2.Min());
            Console.WriteLine("Phần tử lớn thứ 2 trong danh sách là: " + ds2.Max());
            Console.WriteLine("Phần tử nhỏ thứ 2 trong danh sách là: " + ds2.Min());
            Console.Write("Vị trí index của phần tử lớn thứ 2 trong danh sách là: ");
            for (int i = 0;i < ds1.Count; i++)
            {
                if (ds1[i] == ds2.Max())
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Vị trí index của phần tử nhỏ thứ 2 trong danh sách là: ");
            for (int i = 0; i < ds1.Count; i++)
            {
                if (ds1[i] == ds2.Min())
                    Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
