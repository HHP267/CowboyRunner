using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void playGame()
    {
        //Application.LoadLevel("Gameplay");
        SceneManager.LoadScene("Gameplay");
    }
}
