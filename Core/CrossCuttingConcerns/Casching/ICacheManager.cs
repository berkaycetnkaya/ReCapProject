﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Casching
{
    public interface ICacheManager
    {   

        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value,int duration);

        bool IsAdded(string key); 
        void Remove(string key);
        void RemoveByPattern(string pattern);  
    }
}
