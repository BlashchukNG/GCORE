namespace GIG.Asset.Helpers.Progress
{
  public static class ProgressHelper
  {
    public static float GetProgress(float current, float max) =>
      (current * 100 / max) / 100;
  }
}