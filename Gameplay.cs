using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour {

    [SerializeField]
    private GameObject pausePanel;

    [SerializeField]
    private Button restart;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text pauseText;

    private int score;

    private void Start()
    {
        scoreText.text = score + "M";
        StartCoroutine(CountScore());
        PlayerDied.endGame += PlayerDiedEndTheGame;
    }

    IEnumerator CountScore()
    {
        yield return new WaitForSeconds(0.6f);
        score++;
        scoreText.text = score + "M";
        StartCoroutine(CountScore());
    }

    //void onEnable()
    //{
      //  PlayerDied.endGame += PlayerDiedEndTheGame;
    //}
    //void onDisable()
    //{
      //  PlayerDied.endGame -= PlayerDiedEndTheGame;
    //}

    void PlayerDiedEndTheGame()
    {
        if (!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetInt("Score", 0);
        }
        else
        {
            int highScore = PlayerPrefs.GetInt("Score");

            if (highScore < score)
            {
                PlayerPrefs.SetInt("Score", score);
            }
        }

        pausePanel.SetActive(true);
        pauseText.text = "Game Over";
        restart.onClick.RemoveAllListeners();
        restart.onClick.AddListener(() => RestartGame());
        Time.timeScale = 0f;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        restart.onClick.RemoveAllListeners();
        restart.onClick.AddListener(() => ResumeGame());
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        //Application.LoadLevel("MainMenu");
        SceneManager.LoadScene("MainMenu");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        //Application.LoadLevel("Gameplay");
        SceneManager.LoadScene("MainMenu");

    }


}
