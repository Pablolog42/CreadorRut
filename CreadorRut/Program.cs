using System;
using System.Threading;

namespace CreadorRut
{


    class Program
    {

        static void Main()

        {
            int k;     //Variable auxiliar

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Ingrese la canitdad de RUTs a generar: ");
            int j = int.Parse(Console.ReadLine());         // cantidad de RUTs a generar
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();



            for (k=j; k>0; k--) {          //Que se generen tantos RUT como el usuario quiera

                int delay = 10;

                int[] arrayRutSinDigito = new int[8]; //array rut sin digito verif.
                int[] arrayPonderado = new int[8];    // array ponderado
                int digitoV;
                int sumaPonderada;
                int i;
                float sumaParcialModulo;
                int sumaParcialModulo2;

                string verificador;

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("RUT número " + (j-k+1) + " de " + j) ;






                Random rnd = new Random();


                arrayRutSinDigito[0] = rnd.Next(0, 9); //Se asigna array a rut
                Thread.Sleep(delay);                   //Delay para asegurar aleatorieidad
                arrayRutSinDigito[1] = rnd.Next(1, 9);
                Thread.Sleep(delay);
                arrayRutSinDigito[2] = rnd.Next(0, 9);
                Thread.Sleep(delay);
                arrayRutSinDigito[3] = rnd.Next(0, 9);
                Thread.Sleep(delay);
                arrayRutSinDigito[4] = rnd.Next(0, 9);
                Thread.Sleep(delay);
                arrayRutSinDigito[5] = rnd.Next(0, 9);
                Thread.Sleep(delay);
                arrayRutSinDigito[6] = rnd.Next(0, 9);
                Thread.Sleep(delay);
                arrayRutSinDigito[7] = rnd.Next(0, 9);

                

                for(i=2; i<=7; i++)   //pondera los valores de el arrayRut (sólo del 2 al 7)  y los asigna a valor ArrayPonderado
                { arrayPonderado[i] = arrayRutSinDigito[i] * (9 - i); }


                sumaPonderada =
                arrayPonderado[7] +   //se ponderan los digitos para hacer el caluclo de digito verif.
                arrayPonderado[6] +
                arrayPonderado[5] +
                arrayPonderado[4] +
                arrayPonderado[3] +
                arrayPonderado[2] +
                (arrayRutSinDigito[1] * 2);
              //  (arrayRutSinDigito[0] * 3);     (Con esto descomentado no funca)


                sumaParcialModulo = sumaPonderada / 11;
                int sumaParcialModuloTuncado = (int)Decimal.Truncate((decimal)sumaParcialModulo); //Se le quita parte decimal a SumaParcialModulo
                sumaParcialModuloTuncado *= 11; //Se multiplica sin decimal

                sumaParcialModulo2 = sumaPonderada - sumaParcialModuloTuncado;
                digitoV = 11 - sumaParcialModulo2;


                if (digitoV == 11) { digitoV = 0; verificador = "0"; }          //Caso especial 0 y K
                else if (digitoV == 10){ verificador = "K"; }
                else {verificador = Convert.ToString(digitoV); }            //Caso normal
                



                Console.WriteLine(
                     // arrayRutSinDigito[0] +          //Impresión final de RUT  (con esta linea descomentada no anda)
                      arrayRutSinDigito[1] + "." +
                      arrayRutSinDigito[2] +
                      arrayRutSinDigito[3] +
                      arrayRutSinDigito[4] + "." +
                      arrayRutSinDigito[5] +
                      arrayRutSinDigito[6] +
                      arrayRutSinDigito[7] + "-" + verificador);


            }

            Console.ReadKey();
        }

    }
}
