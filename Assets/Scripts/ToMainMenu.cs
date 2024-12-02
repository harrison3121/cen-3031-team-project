using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void MainMenu1()
    {
        PlayerPrefs.SetInt("World2Unlocked", 1);
        SceneManager.LoadScene("Menu");
    }

    public void MainMenu2()
    {
        PlayerPrefs.SetInt("World3Unlocked", 1);
        SceneManager.LoadScene("Menu");
    }

    public void MainMenu3()
    {
        PlayerPrefs.SetInt("World4Unlocked", 1);
        SceneManager.LoadScene("Menu");
    }

    public void MainMenu4()
    {
        PlayerPrefs.SetInt("World5Unlocked", 1);
        SceneManager.LoadScene("Menu");
    }
    public void MainMenu5()
    {
        PlayerPrefs.SetInt("Done", 1);
        SceneManager.LoadScene("Menu");
    }
}
