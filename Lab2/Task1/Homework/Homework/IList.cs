﻿using System;

namespace Homework
{
    public interface IList
    {
        bool Add(int data, int position);
        bool Remove(int position);
        int Count { get; }
        bool IsEmpty();
        int GetDataByPosition(int position);
        bool SetDataByPosition(int data, int position);
        void Print();
        void Clear();
    }
}
