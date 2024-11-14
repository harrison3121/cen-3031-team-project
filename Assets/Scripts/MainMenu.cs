using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartLevel1()
    {
        SceneManager.LoadScene("Level1Quiz");
    }


}
