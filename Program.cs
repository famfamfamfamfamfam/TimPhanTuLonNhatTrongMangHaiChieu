using System;

namespace MANGHAICHIEU
{
    class TimGiaTriLonNhatCuaMang
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lan luot nhap so hang, so cot cua ma tran:");
            int sohang = int.Parse(Console.ReadLine());
            int socot = int.Parse(Console.ReadLine());
            double[,] matran = new double[sohang,socot];
            for(int i=0; i<sohang; i++)
            {
                for(int j = 0; j<socot;j++)
                {
                    Console.WriteLine("Nhap phan tu co toa do [{0},{1}]", i, j);
                    matran[i,j]=double.Parse(Console.ReadLine());
                }
            }
            double max = matran[0,0];
            int hang=0;
            int cot=0;
            for(int i =0; i<sohang;i++)
            {
                for(int j = 0; j<socot; j++)
                {
                    if(matran[i,j]>max)
                    {
                        max = matran[i,j];
                        hang = i;
                        cot = j;
                    }
                }
            }
            Console.WriteLine("Phan tu co toa do [{0},{1}] voi gia tri {2} la phan tu lon nhat", hang, cot, max);
        }
    }
}