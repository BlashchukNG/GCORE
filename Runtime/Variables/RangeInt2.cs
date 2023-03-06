using System;

namespace GCORE.Variables
{
  [Serializable]
  public struct RangeInt2
  {
    public int min;
    public int max;

    public RangeInt2(int min, int max)
    {
      this.max = max;
      this.min = min;
    }
  }
}