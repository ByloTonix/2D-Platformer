using UnityEngine;
using UnityEngine.UI; //эта библиотека нужна для работы с интерфейсом

public class CoinController : MonoBehaviour
{
	[SerializeField] private Text TextComponent;
    [SerializeField] private AudioClip CoinSound;
    [SerializeField] private int coin;
    public int Coin
    {
        get => coin;
        set
        {
            coin = value;
            TextComponent.text = $"Количество монет: {value}";
        }
    }
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Coin")
		{
			Coin++;
			AudioSource.PlayClipAtPoint(CoinSound, transform.position);
            Destroy(other.gameObject);
        }
    }
}