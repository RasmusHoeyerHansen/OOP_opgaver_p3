using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OpgLek6._1
{
    class HandyMethodz
    {
        public static T Max<T>(List<T> liste) where T: IComparable<T>
        {
            return liste.Max();  
        }

        public T Min<T>(List<T> liste) where T : IComparable<T>
        {
            return liste.Min();
        }

        public static void Copy<T>(T[] source, T[] dest)
        {
            if (source.Length != dest.Length)
            {
                throw new IndexOutOfRangeException();
            }
            source.CopyTo(dest, 0);
        }

        public static void Shuffle<T>(T[] liste)
        {
            Random rand = new Random();
            for (int n = 0; n < liste.Length; n++)
            {
                int i = rand.Next(0, liste.Length),
                    j = rand.Next(0, liste.Length);
                T temp = liste[i];
                liste[i] = liste[j];
                liste[j] = temp;
            }
        }
    }
}
