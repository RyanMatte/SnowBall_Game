using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne : MonoBehaviour
{

    public GameObject howToPlayUI;
    public GameObject scoreUI;

    void Start()
    {
        howToPlayUI.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Mouse0)){
        if (howToPlayUI.activeSelf == true){
          howToPlayUI.SetActive(false);
          scoreUI.SetActive(true);
          Time.timeScale = 1f;
          PauseMenu.GameIsPaused = false;
        }
      }
    }
}
