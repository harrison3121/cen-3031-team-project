using UnityEngine;

public class ContinueButtonScript : MonoBehaviour
{
    public GameObject textPanel;   
    public GameObject formPanel;  

    public void ShowFormPanel()
    {
        textPanel.SetActive(false); 
        formPanel.SetActive(true);  
    }
}
