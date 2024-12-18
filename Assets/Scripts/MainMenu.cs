using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Button world2Button;
    public Button world3Button;
    public Button world4Button;
    public Button world5Button;
    public void StartLevel1()
    {
        SceneManager.LoadScene("Level1Lesson");
    }
    
    public void StartLevel2()
    {
        SceneManager.LoadScene("Level2Lesson");
    }
    public void StartLevel3()
    {
        SceneManager.LoadScene("Level3Lesson");
    }
    public void StartLevel4()
    {
        SceneManager.LoadScene("Level4Lesson");
    }
    public void StartLevel5()
    {
        SceneManager.LoadScene("Level5Lesson");
    }
    public void Reset(){
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        SceneManager.LoadScene("Menu");

    }

    void Start(){
        world2Button.gameObject.SetActive(false);
        world3Button.gameObject.SetActive(false);
        world4Button.gameObject.SetActive(false);
        world5Button.gameObject.SetActive(false);
        //Debug.Log("World2Unlocked: " + PlayerPrefs.GetInt("World2Unlocked", 0));
    }
    void Update(){
        if(PlayerPrefs.GetInt("World2Unlocked", 0) == 1){
            world2Button.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("World3Unlocked", 0) == 1){
            world3Button.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("World4Unlocked", 0) == 1){
            world4Button.gameObject.SetActive(true);
        }
        if(PlayerPrefs.GetInt("World5Unlocked", 0) == 1){
            world5Button.gameObject.SetActive(true);
        }
    }

}
