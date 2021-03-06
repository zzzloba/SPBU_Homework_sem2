﻿using System;

namespace Homework
{
    /// <summary>
    /// Класс, реализующий алгоритм Адлера получения хеша
    /// </summary>
    public class AdlerHash : IHashFunction
    {
        long IHashFunction.HashFunction(string word)
        {
            long a = 1;
            long b = 0;
            const uint modAdler = 65521;

            foreach (char c in word)
            {
                a = (a + c) % modAdler;
                b = (b + a) % modAdler;
            }

            return Math.Abs((b << 16) | a);
        }
    }
}
