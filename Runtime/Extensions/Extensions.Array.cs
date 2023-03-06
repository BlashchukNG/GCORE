using UnityEngine;

namespace GIG.Asset.Extensions
{
    public static partial class Extensions
    {
        public static T GetRandom<T>(this T[] obj) => obj[Random.Range(0, obj.Length)];
    }
}