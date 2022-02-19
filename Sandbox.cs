using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Here you can write console prints to test your implementation outside the testing environment");

            Dictionary<int, TestMethods.EValueType> result = new Dictionary<int, TestMethods.EValueType>();
            int[] testDict1Elements = { 10, 4, 5, 3, 9, 34, 8, 13, 7 };
            Dictionary<int, TestMethods.EValueType> sortedDict1 = TestMethods.FillDictionaryFromSource(testDict1Elements);
            //foreach (KeyValuePair<int, TestMethods.EValueType> elementos in sortedDict1)
            //{
            //    Console.WriteLine("clave" + elementos.Key + "edad" + elementos.Value);
            //}
           
           

            int[] keys = new int[sortedDict1.Count];
            int i = 0;

            foreach (int Key in sortedDict1.Keys)
            {
                keys[i] = Key;
                i++;
            }

            int[] keysOrdenadas = OrdenaArregloBurbuja(keys);

            for (int j = keysOrdenadas.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(keysOrdenadas[j]);
                foreach (int Key in sortedDict1.Keys)
                {
                    if (keysOrdenadas[j] == Key)
                    {
                        result.Add(Key, sortedDict1[Key]);
                    }
                }
            }
            foreach (KeyValuePair<int, TestMethods.EValueType> elementos in result)
            {
                Console.WriteLine("clave" + elementos.Key + "edad" + elementos.Value);
            }

        }
        static int[] OrdenaArregloBurbuja(int[] coleccion)
        {
            int[] coleccionOrdenada = coleccion;
            int datoTemporal;



            //aqui implementamos el algoritmo de ordenamiento burbuja en forma ascendente
            bool seHizoCambio = true;



            //se repite el ciclo hasta que no se haga cambio (seHizoCambio = false)
            while (seHizoCambio == true)
            {
                //iniciamos cada ciclo indicando que no se hizo cambio
                seHizoCambio = false;



                //recorremos el ciclo para hacer las comparaciones de dos números adjacentes
                for (int i = 0; i < coleccionOrdenada.Length - 1; i++)
                {
                    if (coleccionOrdenada[i] > coleccionOrdenada[i + 1])
                    {
                        //el primero es mayor que el segundo, se cambian de posición
                        datoTemporal = coleccionOrdenada[i + 1];
                        coleccionOrdenada[i + 1] = coleccionOrdenada[i];
                        coleccionOrdenada[i] = datoTemporal;



                        //se hizo ordenamiento, se coloca la variable "bandera" en true
                        seHizoCambio = true;
                    }
                }
            }

            return coleccionOrdenada;
        }
    }
        
}
