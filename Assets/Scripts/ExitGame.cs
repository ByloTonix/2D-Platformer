using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public Button Button;   
    
    void Start()
    {
        Button btn = Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }   
    void TaskOnClick()
    {
        SceneManager.LoadScene("Level0");
    }
}