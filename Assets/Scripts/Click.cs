using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    [SerializeField] private Button Button;
    [SerializeField] private GameObject _loading;
    [SerializeField] private float _loadTime = 2;

    void Start()
    {
        Button btn = Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }   
    void TaskOnClick() {
        _loading.SetActive(true);
        StartCoroutine(WaitTime());
    }

    private IEnumerator WaitTime() {
        yield return new WaitForSeconds(_loadTime);
        SceneManager.LoadScene("Level1");
    }
}