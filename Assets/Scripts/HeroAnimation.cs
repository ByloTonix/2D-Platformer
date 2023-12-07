using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimation : MonoBehaviour
{
	[SerializeField] private Animator anim;
	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private HeroMove pm;

	void Start()
	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		pm = GetComponent<HeroMove>();
	}

	void Update()
	{
		if (pm == null || pm.isGrounded)
		{
			anim.SetBool ("isJumping", false);
			anim.SetFloat ("speed", Mathf.Abs (rb.velocity.x));
		}
		else
		{
			anim.SetFloat ("speed", 0);
			anim.SetBool ("isJumping", true);
		}
	}
}