using System.Collections.Generic;

namespace OpgLek6._5
{
    public class Dict<K, V>
    {
        List<KeyValuePair<K, V>> list = new List<KeyValuePair<K, V>>();

        //Methods
        public V Get(K key)
        {
            return list.Find(pair => pair.Key.Equals(key)).Value;

            bool Compare(KeyValuePair<K, V> pair)
            {
                return pair.Key.Equals(key);
            }
            
            //Loops through the list, names the current element pair, and returns the element where its Key equals key
            return list.Find(Compare).Value;
            
            foreach (var pair in list)
            {
                if (pair.Key.Equals(key))
                    return pair;
            }


        }
    }
}
