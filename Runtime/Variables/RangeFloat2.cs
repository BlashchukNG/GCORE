using System;

namespace GCORE.Variables
{
  [Serializable]
  public struct RangeFloat2
  {
    public float min;
    public float max;

    public RangeFloat2(float min, float max)
    {
      this.max = max;
      this.min = min;
    }
  }
}