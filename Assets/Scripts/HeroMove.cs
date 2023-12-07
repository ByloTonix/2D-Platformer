using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
	[SerializeField] private LayerMask whatIsGround;
	[SerializeField] private Transform groundCheck;
	[SerializeField] private float jumpForce;
	[SerializeField] private float speed;
	[SerializeField] private bool isLookingLeft;
	public bool isGrounded;
	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			Jump();
			isGrounded = false;
		}
	}

	public void Jump(float additional = 0) {
		rb.AddForce (Vector2.up * (jumpForce + additional) , ForceMode2D.Impulse);
	}

	void FixedUpdate()
	{
		isGrounded = Physics2D.OverlapPoint(groundCheck.position, whatIsGround);
		float x = Input.GetAxis("Horizontal");
		Vector3 move = new Vector3(x * speed, rb.velocity.y, 0f);
		rb.velocity = move;
		if (x < 0 && !isLookingLeft)
			TurnTheEnemy();
		if (x > 0 && isLookingLeft)
			TurnTheEnemy();
		}

	void TurnTheEnemy()	
	{
		isLookingLeft = !isLookingLeft;
		transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
	}
}