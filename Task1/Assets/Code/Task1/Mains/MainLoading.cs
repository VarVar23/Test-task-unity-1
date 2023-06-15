using UnityEngine;
using UnityEngine.UI;


public class MainLoading : MonoBehaviour
{
    [SerializeField] private Text _progressText;
    private int _indexLoadScene;

    #region Controllers

    private OpenSceneController _openSceneController;
    private BlockOrientation _blockOrientation;

    #endregion

    private void Awake()
    {
        _indexLoadScene = CONSTANTS.IndexSceneGallery;
        Initialize();

        _blockOrientation.OnlyPortraitOrientation();
    }

    private void Start()
    {
        StartCorutines();
    }

    private void Initialize()
    {
        _openSceneController = new OpenSceneController();
        _blockOrientation = new BlockOrientation();
    }

    private void StartCorutines()
    {
        StartCoroutine(_openSceneController.LoadAsyncScene(_progressText, _indexLoadScene));
    }
}
