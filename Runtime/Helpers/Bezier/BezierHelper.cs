using UnityEngine;

namespace GCORE.Helpers.Bezier
{
  public static class BezierHelper
  {
    public static Vector3 Triangle(Vector3 p0, Vector3 p1, Vector3 p2, float t)
    {
      var p0p1 = (1 - t) * p0 + t * p1;
      var p1p2 = (1 - t) * p1 + t * p2;
      return (1 - t) * p0p1 + t * p1p2;
    }

    public static Vector3 Cube(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
      var p0p1 = (1 - t) * p0 + t * p1;
      var p1p2 = (1 - t) * p1 + t * p2;
      var p2p3 = (1 - t) * p2 + t * p3;
      var p0p1p2 = (1 - t) * p0p1 + t * p1p2;
      var p1p2p3 = (1 - t) * p1p2 + t * p2p3;
      return (1 - t) * p0p1p2 + t * p1p2p3;
    }
  }
}