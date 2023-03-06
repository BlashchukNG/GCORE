using UnityEngine;

namespace GCORE.Helpers.Vectors
{
  public static class Vector3Helper
  {
    public static Vector3 GetMiddlePoint(Vector3 a, Vector3 b) => (a + b) / 2f;

    public static Vector3 RotateVector(Vector3 a, float angle) =>
      Quaternion.Euler(0, 0, angle) * a;
  }
}