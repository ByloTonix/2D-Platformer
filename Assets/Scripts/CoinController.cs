using System;
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
            PlayerPrefs.SetInt("Coin", value);
            PlayerPrefs.Save();
            TextComponent.text = $"Количество монет: {value}";
        }
    }

    private void Start()
    {
	    Coin = PlayerPrefs.GetInt("Coin", 0);
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