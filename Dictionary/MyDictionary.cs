using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
     public class MyDictionary<K,V>
    {
        //array oluşturuldu
        K[] key;
        V[] value;
        public MyDictionary()
        {
            //oluşturulan arraye yer açtık
            key = new K [0];
            value = new V [0];
        }
     public void Add(K keys,V values) 
        {
            //key ve value için girilecek değerlerin girilmesi için 1 arttırdık ve geçici elemana emanet ettik
            K[] tempArrayKeys = key;
            key = new K[key.Length + 1];

            V[] tempArrayValues = value;
            value = new V[value.Length + 1];

            //emanet ettiğimiz verileri geri istedik
            for (int i = 0; i < tempArrayKeys.Length && i < tempArrayValues.Length; i++)
            {
                key[i] = tempArrayKeys[i];
                value[i] = tempArrayValues[i];
            }

            //en son girilen değer dahil hepsini bir araya almak için toparlıyoruz
            key[key.Length - 1] = keys;
            value[value.Length - 1] = values;

        }
        //veee sonucu görme zamanıııı:)))
        public int k
        {
            get { return key.Length; }
        }
        public int v
        {
            get { return value.Length; }
        }

    }
}
