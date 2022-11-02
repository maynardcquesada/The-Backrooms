using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PlayGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ApplicationClose();
        }
    }
    public void ApplicationClose()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        mainMenuCanvas.SetActive(false);
    }
}
