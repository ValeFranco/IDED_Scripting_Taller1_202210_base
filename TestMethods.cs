using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }
        /*
            Stack<int> result = new Stack<int>();

            Stack<int> Pila = new Stack<int>();

            int[] elementosPila = Pila.ToArray();
            int[] elementosResultado = result.ToArray();
            int n = 1;
            for (int i = elementosPila.Length-1; i >=0; i--)
            {
                while(n<elementosPila.Length-1)
                {
                    if (elementosPila[i - n] > elementosPila[i])
                    {
                        for (int j = elementosResultado.Length - 1; j >= 0; j--)
                        {
                            elementosResultado[i] = elementosPila[i - n];
                            result.Push(elementosResultado[i]);
                        }
                    }
                    else
                    {
                        for (int j = elementosResultado.Length - 1; j >= 0; j--)
                        {
                            elementosResultado[i] = -1;
                            result.Push(elementosResultado[i]);
                        }
                    }
                    n++;
                }
<<<<<<< HEAD
            }*/
        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {

            Stack<int> newstact = new Stack<int>();
            int[] bateria = sourceStack.ToArray();
            int v_m = 0;
            for (int i = 0; i < bateria.Length; i++)
            { 
                if (bateria[i] > v_m)
                {
                    v_m = bateria[i];
                    bateria[i] = -1;
                }
                else
                {
                    bateria[i] = v_m;
                }
              
            }
            for (int i = bateria.Length - 1; i >= 0; i--)
            {
                newstact.Push(bateria[i]);
            }
          
            return newstact;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            //Lenar el diccionario
            for (int i = 0; i < sourceArr.Length; i++)
            {
                if (sourceArr[i] % 2 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Two);
                }
                else
                if (sourceArr[i] % 3 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Three);
                }
                else
                if (sourceArr[i] % 5 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Five);
                }
                else
                if (sourceArr[i] % 7 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Seven);
                }
                else
                {
                    result.Add(sourceArr[i], EValueType.Prime);
                }


            }

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            //foreach (KeyValuePair<int, EValueType> elemenetos in sourceDict)
            //{

            //}
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}