using System;

namespace Programa_04
{
    class Program
    {
        public static void Main(string[] args)
        {
             
            string dato = "";
            int Tamañocanino = 0;
            int ActividadPerro = 0;
            double peso = 0.0;
            int opcion = 0;
            
            
            
            do{
                
                Console.WriteLine("Bienvenido al programa de alimentacion adecuada para tu canino.\n\n");

                Console.WriteLine("Indicame si tu canino es un cachorro o es un adulto, por favor");
                Console.WriteLine("1-cachorro           2-adulto");

                 dato = Console.ReadLine();
                 opcion = Convert.ToInt32(dato);

            if(opcion == 1)
            {
                Console.WriteLine("Indicame de que tamaño es tu cachorro");
                Console.WriteLine("1- miniatura  2-pequeño  3-mediano  4-grande");

                 dato = Console.ReadLine();
                 opcion = Convert.ToInt32(dato);
                
                 if(opcion ==1)
                    {
                        Console.WriteLine("El peso ideal de tu cachorro deberia ser de 2kg");
                        Console.WriteLine("Si tiene 2 meses la porcion de alimento debe ser de 50gr");
                        Console.WriteLine("Si tiene entre 3 y 5 meses la porcion de alimento debe ser de 60gr");
                        Console.WriteLine("Si tiene entre 6 y 12 meses la porcion de alimento debe ser de 55gr");
                    }
                if(opcion ==2)
                    {
                        Console.WriteLine("El peso ideal de tu cachorro deberia ser entre 5 y 10kg");
                        Console.WriteLine("Si tiene 2 meses la porcion de alimento debe ser entre 95 y 155gr");
                        Console.WriteLine("Si tiene 3 meses la porcion de alimento debe ser entre 110 y 195gr");
                        Console.WriteLine("Si tiene 4 meses la porcion de alimento debe ser entre 115 y 195gr");
                        Console.WriteLine("Si tiene 5 meses la porcion de alimento debe ser entre 115 y 190gr");
                        Console.WriteLine("Si tiene entre 6 y 12 meses la porcion de alimento debe ser entre 110 y 185gr");
                    }
                if(opcion ==3)
                    {
                        Console.WriteLine("El peso ideal de tu cachorro deberia ser entre 17 y 25kg");
                        Console.WriteLine("Si tiene 2 meses la porcion de alimento debe ser entre 215 y 270gr");
                        Console.WriteLine("Si tiene 3 meses la porcion de alimento debe ser entre 265 y 350gr");
                        Console.WriteLine("Si tiene 4 meses la porcion de alimento debe ser entre 285 y 375gr");
                        Console.WriteLine("Si tiene 5 meses la porcion de alimento debe ser entre 285 y 375gr");
                        Console.WriteLine("Si tiene entre 6 y 12 meses la porcion de alimento debe ser entre 280 y 370gr");
                    }
                 if(opcion ==4)
                    {
                        Console.WriteLine("El peso ideal de tu cachorro deberia ser entre 50 y 60kg");
                        Console.WriteLine("Si tiene 2 meses la porcion de alimento debe ser entre 405 y 450gr");
                        Console.WriteLine("Si tiene 3 meses la porcion de alimento debe ser entre 545 y 605gr");
                        Console.WriteLine("Si tiene 4 meses la porcion de alimento debe ser entre 610 y 685gr");
                        Console.WriteLine("Si tiene 5 meses la porcion de alimento debe ser de 625gr");
                    }
            }
            if(opcion == 2)
            {
              
                Console.WriteLine("¿Cual es el peso de su perro?:");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
                
                if(peso <= 5 && peso >= 2)
                {
                     Console.WriteLine("Su perro es miniatura.");

                }

                 if(peso <= 10 && peso >= 5)
                {
                     Console.WriteLine("Su perro es pequeño.");

                }

                 if(peso <= 15 && peso >= 10)
                {
                     Console.WriteLine("Su perro es mediano.");

                }

                 if(peso <= 40 && peso >= 15)
                {
                     Console.WriteLine("Su perro es grande.");

                }

                 if(peso <= 90 && peso >= 40)
                {
                     Console.WriteLine("Su perro es muy grande.");

                }

                Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                dato = Console.ReadLine();
                ActividadPerro = Convert.ToInt32(dato);
                
                
                //Perrito miniatura
                if(peso <= 5 && peso >= 2) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 60 y 115 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 45 y 85 gramos.");
                            break;
                    }
                    
                }
                
                //Perrito pequeño
                 if(peso <= 10 && peso >= 5) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 115 y 190 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 100 y 170 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 85 y 145 gramos.");
                            break;
                    }
                    
                }

                 //Perrito mediano
                 if(peso <= 15 && peso >= 10) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 190 y 255 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 170 y 225 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 145 y 195 gramos.");
                            break;
                    }
                    
                }

                 //Perrito grande
                 if(peso <= 25 && peso >= 15) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 255 y 380 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 225 y 330 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 195 y 285 gramos.");
                            break;
                    }
                    
                }

                 //Perrito grande 2
                 if(peso <= 40 && peso >= 25) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 380 y 535 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 330 y 475 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 285 y 410 gramos.");
                            break;
                    }
                    
                }

                 //Perrito grande 3
                 if(peso <= 55 && peso >= 40) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 535 y 680 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 475 y 600 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 410 y 520 gramos.");
                            break;
                    }
                    
                }
                
                  //Perrito grande 4
                 if(peso <= 70 && peso >= 55) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 680 y 820 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 600 y 720 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 520 y 620 gramos.");
                            break;
                    }
                    
                }

                  //Perrito grande 5
                 if(peso <= 90 && peso >= 70) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 820 y 985 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 720 y 870 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 620 y 750 gramos.");
                            break;
                    }
                    
                }
            }
            


                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 2");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
                
            }while(opcion != 2);
                        
            
        
            
            
        }
    }
}