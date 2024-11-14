using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class PlayerCollision : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;
    public int rscore = 1000;
    public TextMeshProUGUI livesText; 
    public TextMeshProUGUI scoreText;   
    public int bonus = 1;


    void Start(){
        UpdateLivesText();
        UpdateScoreText();
    }

    void UpdateLivesText(){
        livesText.text = "Lives: " + lives;
    }

    void UpdateScoreText(){
        scoreText.text = "Score: " + score + " / " + rscore ;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.gameObject.CompareTag("Rock")){
            lives --;
            //Debug.Log(lives);
            UpdateLivesText();
            Destroy(collision.gameObject);
            if (lives <= 0){
                // game over logic
            }
        }
                
        if (collision.gameObject.CompareTag("Trash")){
            Debug.Log(score);
            score += 100;
            UpdateScoreText();
            Destroy(collision.gameObject);
        }
    }

}

