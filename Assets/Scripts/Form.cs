using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using NUnit.Framework.Constraints;

public class Form : MonoBehaviour
{
    public TextMeshProUGUI formQuestions;
    public TMP_InputField recycleInput;       
    public TMP_InputField localProduceInput; 
    public TMP_InputField clothesInput;      
    public TextMeshProUGUI resultText;    
    public Button submitButton;   
    public Button toLevel;  

    void Start(){
        formQuestions.gameObject.SetActive(true);
        resultText.gameObject.SetActive(false);
        toLevel.gameObject.SetActive(false);
    }
    public void ToLevel(){
        SceneManager.LoadScene("Level1");
    }
    public void EvaluateAnswers()
    {
        formQuestions.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(false);
        toLevel.gameObject.SetActive(true);
       
        int recycleScore = int.Parse(recycleInput.text);
        int localProduceScore = int.Parse(localProduceInput.text);
        int clothesScore = int.Parse(clothesInput.text);


        string feedback = "Areas to improve:\n";


        if (recycleScore < 3)
        {
            feedback += "- Recycling habits could be improved.\n";
        }
        
        if (localProduceScore < 3)
        {
            feedback += "- Consider buying more locally-produced goods.\n";
        }
        
        if (clothesScore > 3)
        {
            feedback += "- Try reducing the frequency of buying new clothes.\n";
        }

        if (recycleScore > 3 && localProduceScore > 3 && clothesScore < 3)
        {
            feedback = "Great job! You're making environmentally friendly choices!";
        }


        resultText.text = feedback;
        resultText.gameObject.SetActive(true);
        recycleInput.gameObject.SetActive(false);
        clothesInput.gameObject.SetActive(false);
        localProduceInput.gameObject.SetActive(false);
    }
}
