using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void Start()
    {
        SaveData.LoadGameInfo();
        if (GlobalCs.startGame == false)
        {
            SceneManager.LoadScene(1);
            GlobalCs.startGame = true;
        }
        else { SceneManager.LoadScene(2); }
    }

}
