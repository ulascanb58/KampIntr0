using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] _keys;
        T2[] _values;
        T1[] _tempKeys;
        T2[] _tempValues;

        public MyDictionary()
        {
            _keys = new T1[0];
            _values=new T2[0];

        }

        public void Add(T1 key, T2 value)
        {
            _tempKeys = _keys;
            _tempValues = _values;
            _keys=new T1[_keys.Length+1];
            _values=new T2[_values.Length+1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
            }

            for (int j = 0; j < _tempValues.Length; j++)
            {
                _values[j] = _tempValues[j];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        public int Count
        {
            get { return _keys.Length; }
           
        }

    }
}
