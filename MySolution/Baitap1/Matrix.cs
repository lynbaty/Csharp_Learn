using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    class Matrix
    {
        public int[] Matran;
        public int size;

        public Matrix(int size)
        {
            this.size = size;
            this.Matran = new int[size];

        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= this.size)
                {
                    return this.Matran[index];
                } else
                    return 0;
            }
            set
            {   
                if (!(index < 0 || index >= this.size))
                {
                    this.Matran[index] = value;
                }
            }
        }
        public static Matrix operator+ (Matrix a,Matrix b)
        {
            Matrix c;
            if (a.size >= b.size)
            {
                c = new Matrix(a.size);
                for (int i = 0; i < b.size; i++)
                {
                    c.Matran[i] = a.Matran[i] + b.Matran[i];
                }
                for (int i = b.size; i < a.size; i++)
                {
                    c.Matran[i] = a.Matran[i];
                }
            }else
            {
                c = new Matrix(b.size);
                for (int i = 0; i < a.size; i++)
                {
                    c.Matran[i] = a.Matran[i] + b.Matran[i];
                }
                for (int i = a.size; i < b.size; i++)
                {
                    c.Matran[i] = b.Matran[i];
                }
            }
            return c;
        }
        public void Nhap()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Nhap phan thu tu {i}");
                this.Matran[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Show()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{Matran[i]} ");
            }
            Console.WriteLine();
        }

    }
}
