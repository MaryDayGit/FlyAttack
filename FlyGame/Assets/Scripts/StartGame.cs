using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void SceneSwitcher()
    {
        SaveData.ResetData();
        SceneManager.LoadScene(2);
    }
}
