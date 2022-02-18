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

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {

            Stack<int> result = new Stack<int>();

            Stack<int> Pila = new Stack<int>();

            Pila.Push(5);
            Pila.Push(6);
            Pila.Push(3);
            Pila.Push(26);

            int[] elementosPila = Pila.ToArray();
            int[] elementosResultado = result.ToArray();

            for (int i = 0; i < elementosPila.Length; i++)
            {
                if (elementosPila[i + 1] > elementosPila[i])
                {
                    for (int j = 0; j < elementosResultado.Length; j++)
                    {
                        elementosResultado[i] = elementosPila[i + 1];
                        result.Push(elementosResultado[i]);
                    }
                }
                else
                {
                    for (int j = 0; j < elementosResultado.Length; j++)
                    {
                        elementosResultado[i] = -1;
                        result.Push(elementosResultado[i]);
                    }
                }
            }
            return result;
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