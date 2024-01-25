using UnityEngine;
using UnityEngine.UI; //эта библиотека нужна для работы с интерфейсом
using UnityEngine.SceneManagement;

public class JumpController : MonoBehaviour
{
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Text TextComponent;
    [SerializeField] public int jump;
    public bool isGrounded;
    public int Jump
    {
        get => jump;
        set
        {
            jump = value;
            TextComponent.text = $"Количество оставшихся прыжков: {value}";
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump--;
            var jumps = PlayerPrefs.GetInt("Jump", 0);
            PlayerPrefs.SetInt("Jump", jumps + 1);
            PlayerPrefs.Save();
        }
        if (Jump == 0 && isGrounded)
        {
            SceneManager.LoadScene("Level1");
            isGrounded = false;
        }

    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapPoint(groundCheck.position, whatIsGround);
    }

    void Awake()
    {
        Jump = jump;
    }
}