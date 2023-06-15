using UnityEngine;
using UnityEngine.UI;

public class BackButtonsView : MonoBehaviour
{
    [SerializeField] private Button[] _backButtons;

    public Button[] BackButtons => _backButtons;
}
