using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTANAKA01
{
    internal class NewClass
    {
        public void ejercicio1()
        {
            int a;
            int b;
            Console.WriteLine("Ingresar base del rectángulo");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar altura del rectángulo");
            b = int.Parse(Console.ReadLine());
            int c = (a * b);
            int d = (a + a + b + b); 
            Console.WriteLine("El área de rectángulo es : " + c + "El perímetro del rectángulo es : " + d);
            Console.ReadLine();
        }
        public void ejercicio2()
        {
            int a;
            int b;
            Console.WriteLine("Ingresar base del triángulo");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar altura del triángulo");
            b = int.Parse(Console.ReadLine());
            int c = (a * b) / 2;
            Console.WriteLine("El área de rectángulo es : " + c);
            Console.ReadLine();
        }
        public void ejercicio3()
        {
            int año;
            Console.WriteLine("Ingresar año");
            año = int.Parse(Console.ReadLine());
            bool esBisiesto = ((año % 4 == 0) && (año % 100 != 0)) || (año % 400 == 0);
            if (esBisiesto)
            {
                Console.WriteLine("Es año bisiesto");
            }
            else
            {
                Console.WriteLine("No es año bisiesto");
            }
            Console.ReadLine();
        }
        public void ejercicio4()
        {
            int a;
            int b;
            string c;
            float d;
            bool continueFlag = true;
            while (continueFlag)
            {

                Console.WriteLine("Ingresar primer número a calcular");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar segundo número a calcular");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar simbolo de operación");
                c = Console.ReadLine();
                switch (c)
                {
                    case "+":
                        d = a + b;
                        Console.WriteLine("La suma es: " + d);
                        break;
                    case "-": 
                        d = a - b;
                        Console.WriteLine("La resta es: "+ d);
                        break;
                    case "*":
                        d = a * b;
                        Console.WriteLine("La multiplicaciones es: " + d);
                        break;
                    case "/":
                        d = a / b;
                        Console.WriteLine("La division es: " + d);
                        break;
                    case "%":
                        d = a % b;
                        Console.WriteLine("El módulo es: " + d);
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                bool continuar = false;
                while (!continuar)
                {
                    Console.WriteLine("Desea continuar??");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            continuar = true;
                            break;
                        case "2":
                            continueFlag = false;
                            continuar = true;
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }

                }
            }
            Console.ReadLine();

        }
        public void ejercicio5()
        {
            float a;
            float b;
            float temp;
            float resp;
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Ingresar figura gemetrica a calcular");
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Triángulo");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingresar operación a realizar");
                        Console.WriteLine("1. Perímetro");
                        Console.WriteLine("2. Área");
                        int option2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar medida del radio");
                        a = float.Parse(Console.ReadLine());
                        switch (option2)
                        {
                            case 1:
                                temp = (a + a);
                                resp = (temp * 3.14f);
                                Console.WriteLine("El perímetro del círculo es: " + resp);
                                break;
                            case 2:
                                temp = (a * a);
                                resp = (temp * 3.14f);
                                Console.WriteLine("El área del circulo es: " + resp);
                                break;
                            default:
                                Console.WriteLine("Opción invalida");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingresar operación a realizar");
                        Console.WriteLine("1. Perímetro");
                        Console.WriteLine("2. Área");
                        int option3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar medida del primer lado");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar medida del segundo lado");
                        b = float.Parse(Console.ReadLine());
                        switch (option3)
                        {
                            case 1:
                                resp = (a + a + b + b);
                                Console.WriteLine("El perímetro del réctangulo es: " + resp);
                                break;
                            case 2:
                                resp = (a * b);
                                Console.WriteLine("El área del réctangulo es: " + resp);
                                break;
                            default:
                                Console.WriteLine("Opción invalida");
                                break;
                        }
                        break;
                    case 3: 
                        Console.WriteLine("Ingresar medida de la altura");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar medida de la base");
                        b = float.Parse(Console.ReadLine());
                        resp = (a * b) / 2;
                        Console.WriteLine("El área del triángulo es: "+ resp);
                        break;
                }
                bool validOption = false;
                while (!validOption)
                {
                    Console.WriteLine("Desea continuar??");
                    Console.WriteLine("Si");
                    Console.WriteLine("No");
                    string optionfinal = Console.ReadLine();
                    switch (optionfinal)
                    {
                        case "Si":
                            validOption = true;
                            break;
                        case "No":
                            continueFlag = false;
                            validOption = true;
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
