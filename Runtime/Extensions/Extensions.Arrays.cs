using System;
using System.Collections.Generic;

namespace GCORE.Extensions
{
  public static partial class Extensions
  {
    public static T GetRandom<T>(this T[] array)
    {
      var rnd = new Random();
      return array[rnd.Next(array.Length)];
    }

    public static T GetRandom<T>(this List<T> list)
    {
      var rnd = new Random();
      return list[rnd.Next(list.Count)];
    }

    public static T GetRandomAndDelete<T>(this List<T> list)
    {
      var rnd = new Random();
      var i = rnd.Next(list.Count);
      var returnValue = list[i];
      list.RemoveAt(i);
      return returnValue;
    }
  }
}