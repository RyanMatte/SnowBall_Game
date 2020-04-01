using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{


    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject howToPlayUI;
    public GameObject scoreUI;

    public GameObject sphere;

    [SerializeField]
    public Text ScoreText;

    public int score;






    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
        Vector3 p = sphere.transform.position;
        Vector3 s = sphere.transform.localScale;

        if (p[1] == 184.104){
          ScoreText.text = "0";
        }
        else {
          score = (int)(p[1] - 184.104) * -1;
          ScoreText.text = score.ToString();
        }



        Debug.Log((p[1] - s[1]) - p[1] - s[1]);
        Debug.Log(s[1]);
        Debug.Log(p[1]);



    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        scoreUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LevelOne(){
      SceneManager.LoadScene("Scenes/Level 1");
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        scoreUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/Testing Scene");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
