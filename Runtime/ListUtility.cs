using System;
using System.Collections.Generic;
using System.Linq;

namespace WinuXGames.SplitFramework.Utility
{
    public static class ListExtension
    {
        public static Dictionary<string, List<T>> ToFieldDictionary<T>(this IEnumerable<T> list, Func<T, string> keySelector) => 
            list.GroupBy(keySelector).ToDictionary(x => x.Key, x => x.ToList());


    }
}