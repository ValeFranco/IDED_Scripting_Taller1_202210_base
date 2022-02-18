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
      
            int v_m = 0;
            while (sourceStack.Count != 0)
            {
                int  p = sourceStack.Pop();
               if (p>v_m)
                {
                    v_m = p;
                    newstact.Push(-1);
                }
                else
                {
                    newstact.Push(v_m);
                }
=======
                
               
>>>>>>> 8a31ec43717e4d58abfaddadae20ed803bff19c9
            }
            return newstact;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = null;

            //Lenar el diccionario

            result.Add(4, EValueType.Two);
            result.Add(35, EValueType.Five);
            result.Add(119, EValueType.Seven);
            result.Add(22, EValueType.Two);
            result.Add(17, EValueType.Prime);
            result.Add(27, EValueType.Three);
            result.Add(205, EValueType.Five);

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