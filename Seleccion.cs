using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePractica
{
    internal class Seleccion
    {

        public void EjercicioAscedente()
        {
            int[] numeros = new int[20];
            Random random = new Random();

            // Llenar el arreglo con números aleatorios
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(0, 21);
            }

            // Ordenar el arreglo de menor a mayor
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                int numeroMenor = i;

                // Encontrar el número más pequeño en el subarreglo restante
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    //SI TENGO 9 Y 6, EL NUMERO MENOR O LA VARIABLE DEBERIA DE CONTENER EL 9 Y COMO ES MAYOR AL SIGUIENTE NUMERO POS ENTRA EN EL IF
                    if (numeros[numeroMenor] > numeros[j])
                    {
                        //Y SE TIENE QUE ASIGNAR EL VALOR SIGUIENTE A LA POSICION ANTERIOR
                        numeroMenor = j;
                    }
                }

                // Intercambiar el número actual con el más pequeño encontrado
                int temporal = numeros[i];
                numeros[i] = numeros[numeroMenor];
                numeros[numeroMenor] = temporal;
            }
            //9,6
            // Imprimir los números ordenados
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
