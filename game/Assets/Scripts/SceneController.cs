using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneController : PersistentSingleton<SceneController>
{
    // Start is called before the first frame update

   
    public void ChangeScene()
    {
        SceneManager.LoadScene("COMP397Sec001_Labs");

    }
    public void ChangeSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
