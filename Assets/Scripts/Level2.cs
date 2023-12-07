using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    [SerializeField] GameObject Hero;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Level0");
        }
    }
}
