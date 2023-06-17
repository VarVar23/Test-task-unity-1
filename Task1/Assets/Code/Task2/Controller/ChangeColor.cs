public class ChangeColor
{
    private CubeView _cubeView;
    private RandomColor _randomColor;

    public ChangeColor(CubeView cubeView, RandomColor randomColor)
    {
        _cubeView = cubeView;
        _randomColor = randomColor;
    }

    public void Awake()
    {
        _cubeView.Click += Change;
    }

    private void Change()
    {
        var cubeMaterial = _cubeView.CubeMaterial;
        cubeMaterial.color = _randomColor.GetRandomColor(cubeMaterial);
    }
}
