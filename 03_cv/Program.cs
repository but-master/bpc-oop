// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Net.NetworkInformation;

Matrix a = new Matrix(new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } });
Matrix b = new Matrix(new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } });

Matrix c = a + b;
Console.WriteLine(c.ToString());

c = a - b;
Console.WriteLine(c.ToString());

c = a * b;
Console.WriteLine(c.ToString());

bool h = a == b;
Console.WriteLine(h);

h = a != b;
Console.WriteLine(h);

c = -a;
Console.WriteLine(c.ToString());

//double t = a.det();
//Console.WriteLine(t);