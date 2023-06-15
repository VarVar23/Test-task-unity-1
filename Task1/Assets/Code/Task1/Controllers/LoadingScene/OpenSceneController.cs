using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenSceneController 
{
    public void IntitializeSimpleLoading(Button buttonOpenScene, int indexScene) =>
        buttonOpenScene.onClick.AddListener(() => LoadSimpleScene(indexScene));

    public void LoadSimpleScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }

    public IEnumerator LoadAsyncScene(Text progressText, int indexScene)
    {
        AsyncOperation level = SceneManager.LoadSceneAsync(indexScene);
        level.allowSceneActivation = false;

        while (level.progress < 0.9f)
        {
            progressText.text = (level.progress * 100).ToString() + " %";
            yield return new WaitForSeconds(0.05f);
        }

        progressText.text = "100 %";

        yield return new WaitForSeconds(2);
        level.allowSceneActivation = true;
    }
}
