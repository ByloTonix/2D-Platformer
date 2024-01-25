using UnityEngine;

public class DeadAnimation : MonoBehaviour
{
	private Animator anim;
	private static readonly int IsDead = Animator.StringToHash("isDead");

	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	public void Dead()
	{
		anim.SetBool(IsDead, true);
	}
}
