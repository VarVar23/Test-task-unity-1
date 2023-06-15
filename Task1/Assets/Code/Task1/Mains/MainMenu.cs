using UnityEngine;

public class MainMenu : MonoBehaviour
{
    #region Views

    [SerializeField] private MenuButtonsView _menuButtonsView;

    #endregion

    #region Models

    #endregion

    #region Controllers

    private OpenSceneController _openSceneController;
    private BlockOrientation _blockOrientation;

    #endregion

    private void Awake()
    {
        Initialize();
        _blockOrientation.OnlyPortraitOrientation();
    }

    private void Initialize()
    {
        _openSceneController = new OpenSceneController();

        _openSceneController.IntitializeSimpleLoading(_menuButtonsView.GaleryButton, CONSTANTS.IndexSceneLoading);
        _blockOrientation = new BlockOrientation();
    }
}
