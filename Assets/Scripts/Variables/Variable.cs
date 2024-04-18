using System;
using UnityEngine;

namespace Variables
{
    public abstract class Variable<T> : ScriptableObject
    {
        private Action<T> _onValueChange;
        private T _value;
    
        public T Value
        {
            get => _value;
        
            set
            {
                _value = value;
                _onValueChange?.Invoke(_value);
            }
        }
    
    }
}
