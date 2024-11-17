using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Lesson1 : MonoBehaviour
{
    public void ToQuiz(){
        SceneManager.LoadScene("Level1Quiz");
    }
}
