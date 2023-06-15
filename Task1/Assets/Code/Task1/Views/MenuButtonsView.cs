using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsView : MonoBehaviour
{
    [SerializeField] private Button _galeryButton;

    public Button GaleryButton => _galeryButton;
}
