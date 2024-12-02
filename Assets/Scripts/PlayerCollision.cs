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
    public TextMeshProUGUI completeText;  
    public TextMeshProUGUI loseText;  
    public Button completeButton; 
    public Button loseButton;
    public int bonus = 1;


    void Start(){
        UpdateLivesText();
        UpdateScoreText();
        completeText.gameObject.SetActive(false);
        completeButton.gameObject.SetActive(false);
        loseButton.gameObject.SetActive(false);
        loseText.gameObject.SetActive(false);
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
                loseText.text = "You Lost!";
                loseText.gameObject.SetActive(true);
                loseButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
        }
                
        if (collision.gameObject.CompareTag("Trash")){
            //Debug.Log(score);
            score += 100;
            UpdateScoreText();
            Destroy(collision.gameObject);
            if(score >= rscore){
                completeText.text = "You Won!";
                completeText.gameObject.SetActive(true);
                completeButton.gameObject.SetActive(true);
                //PlayerPrefs.SetInt("World2Unlocked", 1); 
                //PlayerPrefs.Save();
                Time.timeScale = 0f;
            }
        }
    }

}

