using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "LoadImageInGallerySO", menuName = "Config/LoadImageInGallerySO", order = 0)]
public class LoadImageSO : ScriptableObject
{
    [SerializeField] private Button _prefabButton;
    [SerializeField] private int _startCountLoadImage;
    [SerializeField] private int _countImages;
    [SerializeField] private string _url;

    public Button PrefabButton => _prefabButton;
    public int StartCountLoadImage => _startCountLoadImage;
    public int CountImages => _countImages;
    public string Url => _url;
}
