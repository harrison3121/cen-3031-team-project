using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button world2Button;
    public void StartLevel1()
    {
        SceneManager.LoadScene("Level1Lesson");
    }
    
    void Start(){
        if (PlayerPrefs.GetInt("World2Unlocked", 0) == 1)
        {
            world2Button.interactable = true; 
        }
        else
        {
            world2Button.interactable = false; 
        }
    }

}
