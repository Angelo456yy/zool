using System;
using System.Security.Cryptography.X509Certificates;

namespace zoologico
{
        public class Animal
        {
            public string nombre;
            public double altura;
            public double peso;
            public string sexo;
            public int edad;

            public void MostrarCaracteristicas()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Altura: " + altura + " metros");
                Console.WriteLine("Peso: " + peso + " kg");
                Console.WriteLine("Sexo: " + sexo);
                Console.WriteLine("Edad: " + edad + " años");
            }

        public void HacerSonido()
        {
            Console.WriteLine(nombre + " *hace un ruido*");
        }
        public void Seduerme()
        {
            Console.WriteLine("se quedo dormido todo el dia ");
        }
        public void Comer()
        {
            Console.WriteLine(nombre + " *está comiendo*");
        }
    }  
}