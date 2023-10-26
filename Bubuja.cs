using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePractica
{
    internal class Bubuja
    {

        public void Ejercicio1Ascedente()
        {
            int[] numeros= new int [20];
            int temporal = 0;
            Random numeroAleatorios = new Random();
            //FOR PARA RELLENAR EL ARRAY CON VALORES ALEATORIOS
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = numeroAleatorios.Next(0,21);
            }



            /*
            //SE TIENE QUE USAR EL PRIMER FOR Y NO SE PUEDE ACCEDER A LA ULTIMA POSICION PARA NO TENER NUMEROS IGUALES
            //TAMBIEN ES NECESARIO PARA QUE CON ESTE COMPARAR EL SIGUIENTE NUMERO O POSICION (EL SEGUNDO FOR)
            //EL PRIMER FOR ES LA PRIMERA POSICION Y EL SEGUNDO ES LA SEGUNDA POSICION, EN OTRAS PALABRAS
            


            I= PRIMERA POSICION
            J= SIGUIENTE POSICION
            */

            for (int i =0; i < numeros.Length-1; i++)
            {
                for (int j = i+1; j < numeros.Length; j++)
                    
                {
                    //SE COMPRUEBA QUE EL PRIMER NUMERO (O POSICION) SEA MAYOR A LA SIGUIENTE POSICION
                    if (numeros[i] > numeros[j])
                    {
                        //SE USA UNA VARIABLE TEMPORAL PARA SALVAR O GUARDAR EL VALOR DE LA POSICION ACTUAL
                        temporal= numeros[i];
                        //LUEGO LA POSICION ACTUAL SE CAMBIA POR LA SIGUIENTE POSICION
                        numeros[i] = numeros[j];
                        //LUEGO SE DEBE DE PONER EL VALOR ORIGINAL QUE TENIAMOS ANTES
                        numeros[j] = temporal;
                    }
                }
            }
            //IMPRIMIR
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            
        }


        public void Ejercicio1Descedente()
        {
            int[] numeros= new int[20];
            int temporal = 0;
            Random numeroAleatorio = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = numeroAleatorio.Next(0, 21);
            }


            for (int i = 0; i < numeros.Length-1; i++)
            {
                for (int j = i+1; j < numeros.Length; j++)
                {
                    if (numeros[j] > numeros[i])
                    {
                        temporal = numeros[j];
                        numeros[i]= numeros[j];
                        numeros[i] = temporal;
                    }
                }
            }


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
