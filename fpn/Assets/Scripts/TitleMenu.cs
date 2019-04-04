using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    [SerializeField]
    private string gamescenename;

    public void loadgamescene()
    {
        SceneManager.LoadScene(gamescenename);
    }

    public void exitscene()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
