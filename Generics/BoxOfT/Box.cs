﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        List<T> elements;
        public Box()
        {
            elements = new List<T>();

        }

        public int Count { get { return elements.Count; } }
        public void Add(T element)
        {
            elements.Insert(0,element);
        }

        public T Remove()
        {
            T element = elements[0];
            elements.RemoveAt(0);
            return element;
        }
    }
}
