using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private GameObject _loading;
    [SerializeField] private float _loadTime = 1;
    [SerializeField] private string _sceneName = "Level2";
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
        	_loading.SetActive(true);
        	StartCoroutine(WaitTime());
        }
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(_loadTime);
        SceneManager.LoadScene(_sceneName);

    }
}
