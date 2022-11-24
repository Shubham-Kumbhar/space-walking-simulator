using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENECHANGER : MonoBehaviour
{

    private void Start()
    {
        Cursor.visible = true;

    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void credits()
    {
        SceneManager.LoadScene(6);
    }
    public void quid()
    {
        Application.Quit();
    }
}
