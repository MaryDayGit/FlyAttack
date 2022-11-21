using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void Start()
    {
        SaveData.LoadGameInfo();
        Debug.Log(GlobalCs.startGameScene);
        if (GlobalCs.startGameScene == false)
        {
            SceneManager.LoadScene(1);
            GlobalCs.startGameScene = true;
        }
        else { SceneManager.LoadScene(2); }
    }

}
