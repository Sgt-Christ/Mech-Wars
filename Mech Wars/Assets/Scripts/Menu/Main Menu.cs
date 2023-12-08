using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LlamAcademy.Menu
{
    public class MainMenu : MonoBehaviour
    {
        public string firstLevel;

        public void Play()
        {
            SceneManager.LoadScene(firstLevel);
        }

        public void QuitGame()
        {
            Application.Quit();
            Debug.Log("Quit Game");
        }
    }
}
