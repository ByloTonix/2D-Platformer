using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Button Button;
    [SerializeField] private bool isPaused;

    void Update()
    {
        Button.onClick.AddListener(TaskOnClick);
    }   
    void TaskOnClick()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            isPaused = false;
        }
    }
}