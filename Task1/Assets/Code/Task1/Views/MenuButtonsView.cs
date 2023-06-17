using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsView : MonoBehaviour
{
    [SerializeField] private Button _galeryButton;
    [SerializeField] private Button _taskButton;

    public Button TaskButton => _taskButton;
    public Button GaleryButton => _galeryButton;
}
