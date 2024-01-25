using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    [SerializeField] private Button Button;
    [SerializeField] private GameObject _loading;
    [SerializeField] private float _loadTime = 2;
    [SerializeField] private string _sceneName = "Level1";
    [SerializeField] private bool _resetCoins;

    void Start()
    {
        Button.onClick.AddListener(TaskOnClick);
    }
    
    void TaskOnClick()
    {
        if (_resetCoins)
        {
            PlayerPrefs.SetInt("Coin", 0);
            PlayerPrefs.SetInt("Jump", 0);
            PlayerPrefs.Save();
        }
        _loading.SetActive(true);
        StartCoroutine(WaitTime());
    }

    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(_loadTime);
        SceneManager.LoadScene(_sceneName);
    }
}