using UnityEngine;

public class StepSound : MonoBehaviour
{
    [SerializeField] AudioClip footsteps;

    public void FootStepsAudio()
    {
        AudioSource.PlayClipAtPoint(footsteps, transform.position);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            FootStepsAudio();
        }
    }
}