// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты первой точки:");
        double[] point1 = ReadCoordinates();
        
        Console.WriteLine("Введите координаты второй точки:");
        double[] point2 = ReadCoordinates();
        
        double distance = CalculateDistance(point1, point2);
        
        Console.WriteLine($"Расстояние между двумя точками: {Math.Round(distance, 2)}");
    }
    
    static double[] ReadCoordinates()
    {
        double[] coordinates = new double[3];
        
        Console.Write("X: ");
        coordinates[0] = double.Parse(Console.ReadLine());
        
        Console.Write("Y: ");
        coordinates[1] = double.Parse(Console.ReadLine());
        
        Console.Write("Z: ");
        coordinates[2] = double.Parse(Console.ReadLine());
        
        return coordinates;
    }
    
    static double CalculateDistance(double[] point1, double[] point2)
    {
        double dx = point2[0] - point1[0];
        double dy = point2[1] - point1[1];
        double dz = point2[2] - point1[2];
        
        double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
        
        return distance;
    }
}