using UnityEngine;
public class DeadEnd : MonoBehaviour
{
	[SerializeField] GameObject Hero;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Hero.GetComponent<CoinController>().Coin = 0;
            Hero.GetComponent<JumpController>().Jump = 10;
            Hero.transform.position = new Vector2(-14, -4);
        }
    }
}
