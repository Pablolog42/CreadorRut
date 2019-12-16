using System;
using System.Threading;

namespace CreadorRut
{


    class Program
    {

        static void Main()

        {
            for (int i = 0; i < 20; i++) {          //Que se generen 20 RUTs

                int delay = 30;

                int[] arrayRutSinDigito = new int[8]; //array rut sin digito verif.
                int[] arrayPonderado = new int[8];    // array ponderado
                int digitoV;
                int sumaPonderada;
                float sumaParcialModulo;
                int sumaParcialModulo2;
                



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
              //  (arrayRutSinDigito[0] * 3);


                sumaParcialModulo = sumaPonderada / 11; 

                int sumaParcialModuloTuncado = (int)Decimal.Truncate((decimal)sumaParcialModulo); //Se le quita parte decimal a SumaParcialModulo

                sumaParcialModuloTuncado *= 11; //Se multiplica sin decimal

                sumaParcialModulo2 = sumaPonderada - sumaParcialModuloTuncado;


                digitoV = 11 - sumaParcialModulo2;

                if (digitoV == 11) { digitoV = 0; }



                Console.WriteLine(
                     // arrayRutSinDigito[0] +          //Impresión final de RUT
                      arrayRutSinDigito[1] + "." +
                      arrayRutSinDigito[2] +
                      arrayRutSinDigito[3] +
                      arrayRutSinDigito[4] + "." +
                      arrayRutSinDigito[5] +
                      arrayRutSinDigito[6] +
                      arrayRutSinDigito[7] + "-" + digitoV);

                Console.ReadKey();



            }//este es el del for           
        }

    }
}
