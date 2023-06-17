using UnityEngine;

public class BackButtonsController
{
    private BackButtonsView _backButtonsView;
    private OpenSceneController _openSceneController;
    private int _sceneIndex;

    public BackButtonsController(BackButtonsView backButtonsView, OpenSceneController openSceneController) 
    {
        _backButtonsView = backButtonsView;
        _openSceneController = openSceneController;
    }

    public void Awake(int sceneIndex)
    {
        _sceneIndex = sceneIndex;

        foreach(var backButton in _backButtonsView.BackButtons)
        {
            backButton.onClick.AddListener(OpenScene);
        }
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            OpenScene();
        }
    }

    private void OpenScene()
    {
        _openSceneController.LoadSimpleScene(_sceneIndex);
    }
}
