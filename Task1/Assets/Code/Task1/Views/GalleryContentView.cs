using UnityEngine;
using UnityEngine.UI;

public class GalleryContentView : MonoBehaviour
{
    [SerializeField] private GridLayoutGroup _contentGridLayoutGroup;

    public GridLayoutGroup ContentGrid => _contentGridLayoutGroup;
}
