using System.Collections;
using UnityEngine;

public class LoadImageInViewer
{
    private LoadImageSO _modelLoad;
    private ViewerView _viewerView;

    public LoadImageInViewer(ViewerView viewerView, LoadImageSO modelLoad)
    {
        _viewerView = viewerView;
        _modelLoad = modelLoad;
    }

    private Sprite CreateSprite(Texture2D texture)
    {
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }

    public IEnumerator LoadCorutine()
    {
        string url = _modelLoad.Url + OpenImageNumber.ImageNumber + ".jpg";

        for (int i = 0; i < _viewerView.Images.Length; i++)
        {
            using (WWW www = new WWW(url))
            {
                yield return www;

                _viewerView.Images[i].sprite = CreateSprite(www.texture);
            }
        }
    }
}
