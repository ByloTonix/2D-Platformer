using UnityEngine;
using UnityEngine.UI;

public class CoinsValue : MonoBehaviour 
{
    [SerializeField] private Text _text;
    [SerializeField] private Text _jumpText;

    private void Awake()
    {
        _text.text = string.Format(_text.text, PlayerPrefs.GetInt("Coin", 0));
        _jumpText.text = string.Format(_jumpText.text, PlayerPrefs.GetInt("Jump", 0));
    }
}
