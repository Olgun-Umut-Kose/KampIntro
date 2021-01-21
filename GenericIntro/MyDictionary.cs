using System;
using System.Collections.Generic;
using System.Text;


namespace GenericIntro
{
    class MyDictionary<TKey,TVal>
    {
        private List<TKey> _keys;
        private List<TVal> _vals;

        public MyDictionary()
        {
            _keys = new List<TKey>();
            _vals = new List<TVal>();
        }

        public void Add(TKey key, TVal val)
        {
            _keys.ForEach(k => // foreach in başka bir kullanımı
            {
                if (k.Equals(key))
                {
                    throw new ArgumentException(); // hata fırlatma bilmeyenler önemsemesin
                }
            });

            _keys.Add(key);
            _vals.Add(val);
        }

        public TVal GetValue(TKey key)
        {
            int index = _keys.IndexOf(key);
            TVal value = _vals[index];
            return value;
        }
        public TKey GetKey(TVal val)
        {
            int index = _vals.IndexOf(val);
            TKey key = _keys[index];
            return key;
        }


    }
}
