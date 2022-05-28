using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 using UnityEngine.SceneManagement;

public class BallEventsController : MonoBehaviour 
{ 

    public GameObject gameovertext;
    public GameObject RestartButton; 
   [SerializeField] private int score;
   [SerializeField] private TextMeshProUGUI _scoreText;
   public void Restart()
   {
        SceneManager.LoadScene("SampleScene");
   }
   private void Awake()
   {

       score = 0;
       Time.timeScale = 1;
       
   }
   private void OnTriggerEnter2D(Collider2D collision)
   {
      if (collision.gameObject.CompareTag("Bonus"))
      {
      score++;
      _scoreText.text = score.ToString();  

      }

      if(collision.gameObject.CompareTag("Enemy"))
      {
          gameovertext.SetActive(true);
           Time.timeScale = 0.0f;
           RestartButton.SetActive(true);
      }
   }   

}
