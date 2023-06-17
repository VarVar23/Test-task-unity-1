using UnityEngine;

public class MainTask2 : MonoBehaviour
{
    #region Views

    [SerializeField] private CubeView _cubeView;
    [SerializeField] private BackButtonsView _backButtonsView;

    #endregion

    #region Models

    #endregion

    #region Controllers

    private RandomColor _randomColor;
    private ChangeColor _changeColor;
    private BackButtonsController _backButtonsController;
    private OpenSceneController _openSceneController;

    #endregion

    private void Awake()
    {
        Initialize();

        _changeColor.Awake();
        _backButtonsController.Awake(0);
    }

    private void Initialize()
    {
        _randomColor = new RandomColor();
        _changeColor = new ChangeColor(_cubeView, _randomColor);
        _openSceneController = new OpenSceneController();
        _backButtonsController = new BackButtonsController(_backButtonsView, _openSceneController);
    }
}
