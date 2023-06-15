using UnityEngine;

public class BlockOrientation
{
    public void OnlyPortraitOrientation()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void OnlyLandscapeOrientation()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void AutoOrientation()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
    }
}
