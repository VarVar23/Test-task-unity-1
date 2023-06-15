using UnityEngine;

public class MainViewer : MonoBehaviour
{
    #region Views

    [SerializeField] private ViewerView _viewerView;
    [SerializeField] private BackButtonsView _backButtonsView;

    #endregion

    #region Models

    [SerializeField] private LoadImageSO _loadImageSO;

    #endregion

    #region Controllers

    private LoadImageInViewer _loadImageInViewer;
    private ChangeScreenOrientation _changeOrientation;
    private BackButtonsController _backButtonsController;
    private OpenSceneController _openSceneController;
    private BlockOrientation _blockOrientation;

    #endregion

    private void Awake()
    {
        Initialize();

        _blockOrientation.AutoOrientation();
        _backButtonsController.Awake(CONSTANTS.IndexSceneGallery);
    }

    private void Start()
    {
        StartCorutines();

        _changeOrientation.Start();
    }

    private void Update()
    {
        _backButtonsController.Update();
    }

    private void FixedUpdate()
    {
        _changeOrientation.CheckChangeOrientation();
    }

    private void StartCorutines()
    {
        StartCoroutine(_loadImageInViewer.LoadCorutine());
    }

    private void Initialize()
    {
        _openSceneController = new OpenSceneController();
        _loadImageInViewer = new LoadImageInViewer(_viewerView, _loadImageSO);
        _changeOrientation = new ChangeScreenOrientation(_viewerView);
        _backButtonsController = new BackButtonsController(_backButtonsView, _openSceneController);
        _blockOrientation = new BlockOrientation();
    }
}
