﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Extensions
{
    //Utilização de Extension Method para ser possível implementar o ForEach em uma unica linha

    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> itemAction)
        {
            foreach (var item in items)
            {
                itemAction(item);
            }
        }
    }
}
