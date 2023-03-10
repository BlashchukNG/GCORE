using UnityEngine;

namespace GCORE.Extensions
{
    public static partial class Extensions
    {
        public static void Enable(this GameObject gameObject) => gameObject.SetActive(true);
        public static void Disable(this GameObject gameObject) => gameObject.SetActive(false);
    }
}