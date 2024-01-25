using UnityEngine;

public class KillTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _killObject;
    [SerializeField] private float _additionalForce = 5;
    [SerializeField] private AudioClip _deathClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.gameObject.GetComponent<HeroMove>();
        if (player != null && !player.IsDead)
        {
            player.Jump(_additionalForce);
            player.GetComponent<JumpController>().Jump += 2;
            AudioSource.PlayClipAtPoint(_deathClip, transform.position);
            Destroy(_killObject);
        }
    }
}