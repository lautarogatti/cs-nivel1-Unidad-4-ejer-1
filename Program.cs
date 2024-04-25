using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hacer un programa que solicite el ingreso de dos números y luego calcular:

            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente.*/

            int a, b, resultado;

            Console.WriteLine("Ingrese el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());
            if(a > b){
                resultado = a- b; 
                
            }else if(a == b){
                resultado = a + b; 
            }else{
                resultado = a * b; 
            }
            Console.WriteLine("El resultado es " + resultado);
        }

        
    }
}
