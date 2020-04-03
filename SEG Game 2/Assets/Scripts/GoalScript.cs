using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour{

  public GameObject gameOverUI;
  public GameObject scoreUI;
  public GameObject sphere;

  [SerializeField]
  public Text ScoreText;

  public int score;

  void Update(){
    Vector3 p = sphere.transform.position;
    Vector3 s = sphere.transform.localScale;

    if (p[1] == 184.104){
      ScoreText.text = "0";
    }
    else {
      score = (int)(p[1] - 184.104) * -1;
      ScoreText.text = score.ToString();
    }
  }

 void OnCollisionEnter(Collision col){
     if(col.gameObject.name == "Goal Fence A" || col.gameObject.name == "Goal Fence B"){
     Time.timeScale = 0f;
     scoreUI.SetActive(false);
     gameOverUI.SetActive(true);
   }

 }


}
