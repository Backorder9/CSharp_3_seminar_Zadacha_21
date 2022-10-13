/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

public class SamplesArray
{
    public static void Main(string[] args)
    {
    double distance, d;
    double [] A = new double [3];
    double [] B = new double [3];
    distance = 0.0;
    d = 0.0;
    Console.Write("Ведите координату точки А: x: ");
    A [0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ведите координату точки А: y: ");
    A [1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ведите координату точки А: z: ");
    A [2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Ведены кординаты точки A: " + String.Join(", ", A) + ".");
    Console.WriteLine();
    Console.Write("Ведите координату точки B: x: ");
    B [0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ведите координату точки B: y: ");
    B [1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ведите координату точки B: z: ");
    B [2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Ведены кординаты точки B: " + String.Join(", ", B) + ".");
    Console.WriteLine();
    for (int i = 0; i < 3; i++)
    {
    d = B[i] - A[i];
    distance += Math.Pow(d,2);
    }
    Console.WriteLine("Расстояние между точками A и B = " + Math.Round(Math.Sqrt(distance), 2));
    Console.WriteLine();
    }
}