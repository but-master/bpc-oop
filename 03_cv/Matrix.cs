/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_cv
{
    internal class Matrix
    {
    }
}
*/


using System.Numerics;

class Matrix
{
    private double[,] matrix;

    public Matrix(double[,] matrix)
    { this.matrix = matrix; }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
        {
            Console.WriteLine("Matrixes can't be multiplied!!");
            return a;
        }
        else
        {
            Matrix c = new Matrix(new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);

            for (int i = 0; i < a.matrix.GetLength(0); i++)
                for (int j = 0; j < b.matrix.GetLength(1); j++)
                    c.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];

            return c;
        }
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
        {
            Console.WriteLine("Matrixes can't be multiplied!!");
            return a;
        } 
        else
        {
            Matrix c = new Matrix(new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);

            for (int i = 0; i < a.matrix.GetLength(0); i++)
                for (int j = 0; j < b.matrix.GetLength(1); j++)
                    c.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];

            return c;
        }

        
    }

    public static Matrix operator *(Matrix A, Matrix B)
    {
        int rA = A.matrix.GetLength(0);
        int cA = A.matrix.GetLength(1);
        int rB = B.matrix.GetLength(0);
        int cB = B.matrix.GetLength(1);

        if (cA != rB)
        {
            Console.WriteLine("Matrixes can't be multiplied!!");
            return A;
        }
        else
        {
            double temp = 0;
            Matrix c = new Matrix(new double[rA, cB]);

            for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    temp = 0;
                    for (int k = 0; k < cA; k++)
                    {
                        temp += A.matrix[i, k] * B.matrix[k, j];
                    }
                    c.matrix[i, j] = temp;
                }
            }

            return c;
        }
    }

    public static bool operator ==(Matrix a, Matrix b)
    {
        if (a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
        {
            Console.WriteLine("Matrixes can't be multiplied!!");
            return false;
        }
        else
        {
            bool c = true;

            for (int i = 0; i < a.matrix.GetLength(0); i++)
                for (int j = 0; j < b.matrix.GetLength(1); j++)
                    //c = a.matrix[i, j] == b.matrix[i, j] ? true : false;
                    c = a.matrix[i, j] == b.matrix[i, j];

            return c;
        }
    }

    public static bool operator !=(Matrix a, Matrix b)
    {
        if (a.matrix.GetLength(0) != b.matrix.GetLength(0) || a.matrix.GetLength(1) != b.matrix.GetLength(1))
        {
            Console.WriteLine("Matrixes can't be multiplied!!");
            return false;
        }
        else
        {
            for (int i = 0; i < a.matrix.GetLength(0); i++)
                for (int j = 0; j < b.matrix.GetLength(1); j++)
                    if (a.matrix[i, j] != b.matrix[i, j]) return true;
        }

        return false;
    }

    public static Matrix operator -(Matrix a)
    {
        for (int i = 0; i < a.matrix.GetLength(0); i++)
            for (int j = 0; j < a.matrix.GetLength(1); j++)
                a.matrix[i, j] = -a.matrix[i, j];

        return a;
    }

    public override string ToString()
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        string result = string.Empty;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                result = result + $"{matrix[i, j]} \t";
            result = result + "\n";
        }

        return result;
    }

    public double det(Matrix A)
    {
        double determinant = 0;
        int dimA = A.matrix.Rank;

        if (dimA == 1)
        {
            return A.matrix[0, 0];
        }
        else if (dimA == 2)
        {
            return (A.matrix[0, 0] * A.matrix[1, 1] - A.matrix[1, 0] * A.matrix[0, 1]);
        }
        else if (dimA == 3)
        {
            for (int i = 0; i < 3; i++)
                determinant = determinant + (A.matrix[0, i] * (A.matrix[1, (i + 1) % 3] * A.matrix[2, (i + 2) % 3] - A.matrix[1, (i + 2) % 3] * A.matrix[2, (i + 1) % 3]));

            return determinant;
        }
        else
        {
            Console.WriteLine("Matrix is way to large tfor this computer to calculate its determinant :-O");
            //throw new Exception("nenene");
            //try
            //catch
            return 0;
        }
        
    }
}