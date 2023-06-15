using UnityEngine;

public class ChangeScreenOrientation 
{
    private ScreenOrientation _currentOrientation;
    private ViewerView _viewerView;

    public ChangeScreenOrientation(ViewerView viewerView)
    {
        _viewerView = viewerView;
    }

    public void Start()
    {
        _currentOrientation = Screen.orientation;
    }

    public void CheckChangeOrientation()
    {
        if (_currentOrientation == Screen.orientation) return;

        bool portrait = Screen.orientation == ScreenOrientation.Portrait;

        _viewerView.Portrait.SetActive(portrait);
        _viewerView.Landscape.SetActive(!portrait);

        _currentOrientation = Screen.orientation;
    }
}
