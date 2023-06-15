using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadImagesInGallery 
{
    private GalleryContentView _galleryContentView;
    private LoadImageSO _modelLoad;
    private RectTransform _content;
    private CreateButtonsController _createButtonsController;
    private Image[] _images;
    private float _offset;
    private int _stage;

    public LoadImagesInGallery(GalleryContentView galleryContentView, LoadImageSO modelLoad, CreateButtonsController createButtonsController)
    {
        _galleryContentView = galleryContentView;
        _modelLoad = modelLoad;
        _createButtonsController = createButtonsController;
    }

    public void Awake()
    {
        _images = _createButtonsController.Images;
        _content = _galleryContentView.ContentGrid.GetComponent<RectTransform>();
        _offset = _galleryContentView.ContentGrid.cellSize.y;
        _offset += _galleryContentView.ContentGrid.spacing.y;
        _stage = 1;
    }

    private string UpdateUrl(int index)
    {
        return _modelLoad.Url + (index + 1) + ".jpg";
    }

    private Sprite CreateSprite(Texture2D texture)
    {
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }

    public IEnumerator CorutineLoadingImage()
    {
        string url = "";

        yield return StartLoadingImages(url);
        yield return LoadingOfTheFlyImages(url);
    }

    private IEnumerator StartLoadingImages(string url)
    {
        for (int i = 0; i < _modelLoad.StartCountLoadImage; i++)
        {
            url = UpdateUrl(i);

            using (WWW www = new WWW(url))
            {
                yield return www;

                _images[i].sprite = CreateSprite(www.texture);
            }
        }
    }

    private IEnumerator LoadingOfTheFlyImages(string url)
    {
        int constraintCount = _galleryContentView.ContentGrid.constraintCount;
        int i = _modelLoad.StartCountLoadImage;

        while (i < _modelLoad.CountImages)
        {
            while (_content.localPosition.y < _offset * _stage)
            {
                yield return new WaitForSeconds(0.5f);
            }

            for (int j = 0; j < constraintCount; j++)
            {
                url = UpdateUrl(i);

                using (WWW www = new WWW(url))
                {
                    yield return www;

                    _images[i].sprite = CreateSprite(www.texture);
                }

                i++;
            }

            _stage++;
        }
    }
}
