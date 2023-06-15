
public class OpenImages
{
    private CreateButtonsController _createButtonsController;
    private OpenSceneController _openSceneController;

    public OpenImages(CreateButtonsController createButtonsController, OpenSceneController openSceneController)
    {
        _createButtonsController = createButtonsController;
        _openSceneController = openSceneController;
    }

    public void Start()
    {
        var buttons = _createButtonsController.Buttons;

        for(int i = 0; i < buttons.Length; i++)
        {
            int j = i + 1;

            buttons[i].onClick.AddListener(() => Open(j));
        }    
    }

    private void Open(int imageNumber)
    {
        OpenImageNumber.ImageNumber = imageNumber;
        _openSceneController.LoadSimpleScene(CONSTANTS.IndexSceneViewer);
    }

}
