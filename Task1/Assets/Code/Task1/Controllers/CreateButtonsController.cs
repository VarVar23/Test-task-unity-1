using UnityEngine;
using UnityEngine.UI;

public class CreateButtonsController 
{
    public Button[] Buttons => _buttons;
    public Image[] Images => _images;

    private GalleryContentView _galleryContentView;
    private LoadImageSO _modelLoad;
    private Button[] _buttons;
    private Image[] _images;

    public CreateButtonsController(GalleryContentView galleryContentView, LoadImageSO modelLoad)
    {
        _galleryContentView = galleryContentView;
        _modelLoad = modelLoad;
    }

    public void Awake()
    {
        CreateImages();
    }

    private void CreateImages()
    {
        int count = _modelLoad.CountImages;
        _buttons = new Button[count];
        _images = new Image[count];

        for (int i = 0; i < count; i++)
        {
            _buttons[i] = GameObject.Instantiate(_modelLoad.PrefabButton, _galleryContentView.ContentGrid.transform);
            _images[i] = _buttons[i].GetComponent<Image>();
        }
    }
}
