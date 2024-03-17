using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al zoológico!");


            // Crear una instancia de la clase Animal
            Animal leon = new Animal();

            // Establecer las características del animal
            leon.nombre = "León";
            leon.altura = 1.2;
            leon.peso = 150;
            leon.sexo = "Masculino";
            leon.edad = 5;
            //comportamiento de tal
            
            Animal elefante = new Animal();
            elefante.nombre = "Pepe el elefante";
            elefante.altura = 2.5;
            elefante.peso = 400;
            elefante.sexo = "Binario";
            elefante.edad = 10;

            Animal osos = new Animal();
            osos.nombre = "Osos";
            osos.altura = 1.8; 
            osos.peso = 300; 
            osos.sexo = "Masculino";
            osos.edad = 10; 

            Animal cabras = new Animal();
            cabras.nombre = "Cabras";
            cabras.altura = 0.8; 
            cabras.peso = 50; 
            cabras.sexo = "Femenino";
            cabras.edad = 5; 

            Animal salaDeConserje = new Animal();
            salaDeConserje.nombre = "Pedro";
            salaDeConserje.altura = 1.60; 
            salaDeConserje.peso = 60; 
            salaDeConserje.sexo = "Masculino";
            salaDeConserje.edad = 70; 

            Animal monos = new Animal();
            monos.nombre = "Monos";
            monos.altura = 0.6; 
            monos.peso = 15; 
            monos.sexo = "Femenino";
            monos.edad = 4; 

            Animal pinguinos = new Animal();
            pinguinos.nombre = "Pinguinos";
            pinguinos.altura = 0.8; 
            pinguinos.peso = 20; 
            pinguinos.sexo = "Masculino";
            pinguinos.edad = 5; 

            Animal tortugas = new Animal();
            tortugas.nombre = "Tortugas";
            tortugas.altura = 0.3; 
            tortugas.peso = 10; 
            tortugas.sexo = "Femenino";
            tortugas.edad = 20; 

            Animal pandas = new Animal();
            pandas.nombre = "Pandas";
            pandas.altura = 1.2; 
            pandas.peso = 100; 
            pandas.sexo = "Masculino";
            pandas.edad = 8; 

            Animal cocodrilos = new Animal();
            cocodrilos.nombre = "Cocodrilos";
            cocodrilos.altura = 2.0; 
            cocodrilos.peso = 400; 
            cocodrilos.sexo = "Femenino";
            cocodrilos.edad = 15; 

            Animal tucanes = new Animal();
            tucanes.nombre = "Tucanes";
            tucanes.altura = 0.4; 
            tucanes.peso = 2; 
            tucanes.sexo = "Masculino";
            tucanes.edad = 3; 

            Animal peces = new Animal();
            peces.nombre = "Peces";
            peces.altura = 0.1; 
            peces.peso = 0.2; 
            peces.sexo = "Femenino";
            peces.edad = 2; 

            Animal serpientes = new Animal();
            serpientes.nombre = "Serpientes";
            serpientes.altura = 1.5; 
            serpientes.peso = 5; 
            serpientes.sexo = "Masculino";
            serpientes.edad = 6; 

            Animal lemur = new Animal();
            lemur.nombre = "Lemur";
            lemur.altura = 0.5; 
            lemur.peso = 5; 
            lemur.sexo = "Femenino";
            lemur.edad = 4; 

            Animal perezoso = new Animal();
            perezoso.nombre = "Perezoso";
            perezoso.altura = 0.6; 
            perezoso.peso = 8; 
            perezoso.sexo = "Masculino";
            perezoso.edad = 6;

       


            Console.WriteLine("Que lugar quieres visitar?");
            Console.WriteLine("\n 1) Leon \n 2) Elefante \n 3) Osos \n 4) Cabras \n 5)Sala de conserje \n 6) Monos \n 7) Pinguinos \n 8) Tortugas \n 9) Pandas \n 10) Cocodrilos \n 11) Tucanes \n 12) Peces \n 13) Serpientes \n 14) Lemur \n 15) Perezoso");
            string tipo = Console.ReadLine();

           
            if (tipo == "1")
            {
                Console.WriteLine("Bienvenido al cuarto de " + leon.nombre );
                Console.WriteLine("\nCaracterísticas del animal:");
                leon.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Hacerlo Rugir");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*le diste carne al leon*");
                    leon.Comer();  
                }
               else if (comportamiento == "2" )
                {
                    Console.WriteLine("*Le pegaste al leon*");
                    leon.HacerSonido();
                    Console.WriteLine("Corre el leon salio");
                }

            }
            else if (tipo == "2")
            {
                Console.WriteLine("Bienvenido al cuarto de " + elefante.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                elefante.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*le diste Mani");
                    elefante.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine( elefante.nombre + " *se asusta*" );
                    elefante.HacerSonido();
                    Console.WriteLine("se escapo corre");
                }

            }
            else if (tipo == "3")
            {
                Console.WriteLine("Bienvenido al cuarto de " + osos.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                osos.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste miel al oso*");
                    osos.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(osos.nombre + " *gruñe*");
                    osos.HacerSonido();
                }
            }
            else if (tipo == "4")
            {
                Console.WriteLine("Bienvenido al cuarto de " + cabras.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                cabras.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste pasto a la cabra*");
                    cabras.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(cabras.nombre + " *hace un sonido*");
                    cabras.HacerSonido();
                }
            }
            else if (tipo == "5")
            {
                Console.WriteLine("Bienvenido al cuarto de " + salaDeConserje.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                salaDeConserje.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Preguntarle que hace \n 2) Robarle las llaves ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Te le quedas viendo y te saca a patadas*");
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(" *se asusta y te saca a patadas*");
                  
                }
            }
            else if (tipo == "6")
            {
                Console.WriteLine("Bienvenido al cuarto de " + monos.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                monos.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste bananas al mono*");
                    monos.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(monos.nombre + " *grita y se balancea en las ramas*");
                    monos.HacerSonido();
                }
            }
            else if (tipo == "7")
            {
                Console.WriteLine("Bienvenido al cuarto de " + pinguinos.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                pinguinos.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste pescado al pingüino*");
                    pinguinos.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(pinguinos.nombre + " *hace sonidos de graznido*");
                    pinguinos.HacerSonido();
                }
            }
            else if (tipo == "8")
            {
                Console.WriteLine("Bienvenido al cuarto de " + tortugas.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                tortugas.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste lechuga a la tortuga*");
                    tortugas.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(tortugas.nombre + " *hace sonidos de respiración lenta*");
                    tortugas.HacerSonido();
                }
            }
            else if (tipo == "9")
            {
                Console.WriteLine("Bienvenido al cuarto de " + pandas.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                pandas.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste bambú al panda*");
                    pandas.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(pandas.nombre + " *hace sonidos de masticación*");
                    pandas.HacerSonido();
                }
            }
            else if (tipo == "10")
            {
                Console.WriteLine("Bienvenido al cuarto de " + cocodrilos.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                cocodrilos.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste carne al cocodrilo*");
                    cocodrilos.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(cocodrilos.nombre + " *hace sonidos de gruñido*");
                    cocodrilos.HacerSonido();
                }
            }
            else if (tipo == "11")
            {
                Console.WriteLine("Bienvenido al cuarto de " + tucanes.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                tucanes.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste frutas al tucán*");
                    tucanes.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(tucanes.nombre + " *hace sonidos de llamada*");
                    tucanes.HacerSonido();
                }
            }
            else if (tipo == "12")
            {
                Console.WriteLine("Bienvenido al cuarto de " + peces.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                peces.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste copos de pescado al pez*");
                    peces.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(peces.nombre + " *nada silenciosamente*");
                    peces.HacerSonido();
                }
            }
            else if (tipo == "13")
            {
                Console.WriteLine("Bienvenido al cuarto de " + serpientes.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                serpientes.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste ratones a la serpiente*");
                    serpientes.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(serpientes.nombre + " *hace sonidos de silbido*");
                    serpientes.HacerSonido();
                }
            }
            else if (tipo == "14")
            {
                Console.WriteLine("Bienvenido al cuarto de " + lemur.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                lemur.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste frutas al lémur*");
                    lemur.Comer();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(lemur.nombre + " *hace sonidos de chasquido*");
                    lemur.HacerSonido();
                }
            }
            else if (tipo == "15")
            {
                Console.WriteLine("Bienvenido al cuarto de " + perezoso.nombre);
                Console.WriteLine("\nCaracterísticas del animal:");
                perezoso.MostrarCaracteristicas();
                Console.WriteLine("Comportamiento del animal \n 1) Darle de comer \n 2) Que haga ruido ");
                string comportamiento = Console.ReadLine();
                if (comportamiento == "1")
                {
                    Console.WriteLine("*Le diste hojas al perezoso*");
                    perezoso.Seduerme();
                }
                else if (comportamiento == "2")
                {
                    Console.WriteLine(perezoso.nombre + " *Se queda dormido*");
                    perezoso.Seduerme();
                }
            }
        }
    }
}
