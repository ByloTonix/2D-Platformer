using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Collections;


public class DeadEnd : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {   
            other.GetComponent<CoinController>().Coin = 0;
            var heroMove = other.GetComponent<HeroMove>();
            if (heroMove.IsDead)
            {
                return;
            }
            
            heroMove.IsDead = true;
            var deadAnimation = other.GetComponent<DeadAnimation>();
            StartCoroutine(WaitTime(deadAnimation));
        }

        IEnumerator WaitTime(DeadAnimation animation)
        {   
            animation.Dead();
            yield return new WaitForSeconds(0.8f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
