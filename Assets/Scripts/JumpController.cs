using UnityEngine;
using UnityEngine.UI; //эта библиотека нужна для работы с интерфейсом
using UnityEngine.SceneManagement;

public class JumpController : MonoBehaviour
{
    [SerializeField] GameObject Hero;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Text TextComponent;
    [SerializeField] private AudioClip Sound;
    [SerializeField] private int jump;
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
            //AudioSource.PlayClipAtPoint(JumpSound, transform.position);
        }
        if (Jump == 0 && isGrounded)
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene().name);
            isGrounded = false;
        }

    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapPoint(groundCheck.position, whatIsGround);

    }
}