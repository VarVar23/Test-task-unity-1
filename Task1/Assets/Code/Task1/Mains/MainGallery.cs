using UnityEngine;

public class MainGallery : MonoBehaviour
{
    #region Views

    [SerializeField] private GalleryContentView _galleryContentView;
    [SerializeField] private BackButtonsView _backButtonsView;

    #endregion

    #region Models

    [SerializeField] private LoadImageSO _loadImageInGallerySO;

    #endregion

    #region Controllers

    private LoadImagesInGallery _loadImagesInGallery;
    private CreateButtonsController _createButtons;
    private OpenSceneController _openSceneController;
    private BackButtonsController _backButtonsController;
    private OpenImages _openImages;
    private BlockOrientation _blockOrientation;

    #endregion

    private void Awake()
    {
        Initialize();

        _createButtons.Awake();
        _loadImagesInGallery.Awake();
        _backButtonsController.Awake(CONSTANTS.IndexSceneMenu);
        _blockOrientation.OnlyPortraitOrientation();
    }

    private void Start()
    {
        _openImages.Start();

        StartCorutines();
    }

    private void Update()
    {
        _backButtonsController.Update();
    }

    private void Initialize()
    {
        _createButtons = new CreateButtonsController(_galleryContentView, _loadImageInGallerySO);
        _loadImagesInGallery = new LoadImagesInGallery(_galleryContentView, _loadImageInGallerySO, _createButtons);
        _openSceneController = new OpenSceneController();
        _openImages = new OpenImages(_createButtons, _openSceneController);
        _backButtonsController = new BackButtonsController(_backButtonsView, _openSceneController);
        _blockOrientation = new BlockOrientation();
    }

    private void StartCorutines()
    {
        StartCoroutine(_loadImagesInGallery.CorutineLoadingImage());
    }
}
