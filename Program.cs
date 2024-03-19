using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTANAKA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewClass newClass = new NewClass();
            newClass.ejercicio1();
            newClass.ejercicio2();
            newClass.ejercicio3();
            newClass.ejercicio4();
            newClass.ejercicio5();
            //Tarea2
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Ingresar la figura a operar");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Triángulo");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Introducir primer lado");
                        int lad1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introducir segundo lado");
                        int lad2 = int.Parse(Console.ReadLine());
                        Rectángulo rectangulo = new Rectángulo(lad1, lad2);
                        Console.WriteLine($"El área del rectángulo es: {rectangulo.GetArea()} y el perímetro es : {rectangulo.GetPerimeter()}");
                        break;
                    case 2:
                        Console.WriteLine("Introducir medida del rádio");
                        int radio = int.Parse(Console.ReadLine());
                        Circulo circulo = new Circulo(radio);
                        Console.WriteLine($"El área del círculo es: {circulo.GetArea()} y el perímetro es : {circulo.GetPerimeter()}");
                        break;
                    case 3:
                        Console.WriteLine("Introducir la base");
                        int bas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introducir la altura");
                        int alt = int.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(bas, alt);
                        Console.WriteLine($"El área del triángulo es: {triangulo.CalculateArea()}");
                        break;

                }
                bool validOption = false;
                while (!validOption)
                {
                    Console.WriteLine("Elige una opción");
                    Console.WriteLine("1. Volver a operar");
                    Console.WriteLine("2. Salir");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            validOption = true;
                            break;
                        case "2":
                            continueFlag = false;
                            validOption = true;
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }
                }
            }
        }
    }
}
