using UnityEngine;
using UnityEngine.UI;

public class ViewerView : MonoBehaviour
{
    [SerializeField] private GameObject _portrait;
    [SerializeField] private GameObject _landscape;
    [SerializeField] private Image[] _images;
    [SerializeField] private Button[] _closeButtons;

    public GameObject Portrait => _portrait;
    public GameObject Landscape => _landscape;
    public Image[] Images => _images;
    public Button[] CloseButtons => _closeButtons;
}
