using UnityEngine;

namespace GCORE.Extensions
{
    public static partial class Extensions
    {
        public static void Enable(this Collider2D col) => col.enabled = true;
        public static void Disable(this Collider2D col) => col.enabled = false;
    }
}