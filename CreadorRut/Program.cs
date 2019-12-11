using System;
using System.Threading;

namespace CreadorRut
{


    class Program
    {





        static void Main()
        {
            int delay = 30;

            int[] arrayRutSinDigito = new int[8]; //array rut sin digito verif.
            int[] arrayPonderado = new int[8];    // array ponderado
            int digitoV;
            int sumaPonderada = 0;
            int sumaParcialModulo;
            int sumaParcialModulo2;



            Random rnd = new Random();


            arrayRutSinDigito[0] = rnd.Next(0, 9); //Se asigna array a rut
            Thread.Sleep(delay);                    // Delay para asegurar aleatorieidad
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


            arrayPonderado[7] = arrayRutSinDigito[7] *2;    //se ponderan los digitos para hacer el caluclo de digito verif.
            arrayPonderado[6] = arrayRutSinDigito[6] *3;
            arrayPonderado[5] = arrayRutSinDigito[5] *4;
            arrayPonderado[4] = arrayRutSinDigito[4] *5;
            arrayPonderado[3] = arrayRutSinDigito[3] *6;
            arrayPonderado[2] = arrayRutSinDigito[2] *7;
            arrayPonderado[1] = arrayRutSinDigito[1] *2;
            arrayPonderado[0] = arrayRutSinDigito[0] *3;

            foreach (int item in arrayPonderado)
            {
                sumaPonderada += item;
            }

            sumaParcialModulo = sumaPonderada / 11;
            sumaParcialModulo *= 11;

            sumaParcialModulo2 = sumaPonderada - sumaParcialModulo;


            digitoV = 11 - sumaParcialModulo2;

            if (digitoV == 11) { digitoV = 0; }



            Console.WriteLine(
                  arrayRutSinDigito[0] + "." +          //Impresión final de RUT
                  arrayRutSinDigito[1] +
                  arrayRutSinDigito[2] +
                  arrayRutSinDigito[3] + "." +
                  arrayRutSinDigito[4] +
                  arrayRutSinDigito[5] +
                  arrayRutSinDigito[6] + "-" + digitoV);
            Console.WriteLine("suma ponderada=" + sumaPonderada);
            Console.WriteLine("Suma parcial modulo =" + sumaParcialModulo);
            Console.WriteLine("Suma parcial modulo 2 =" + sumaParcialModulo2);
            Console.WriteLine("Digito verificador =" + digitoV);



            Console.WriteLine("array ponderado:");



        }


    }
}
