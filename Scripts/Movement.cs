// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Movement
using UnityEngine;

public class Movement : MonoBehaviour
{
	private Rigidbody2D rb;

	private float moveSpeed;

	private float moveHorizontal;

	private void Start()
	{
		rb = base.gameObject.GetComponent<Rigidbody2D>();
		moveSpeed = 1f;
	}

	private void Update()
	{
		moveHorizontal = Input.GetAxisRaw("Horizontal");
	}

	private void FixedUpdate()
	{
		if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
		{
			rb.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
		}
	}

	public void StopMovent()
	{
		base.gameObject.SetActive(value: false);
	}

	public void EnableMovent()
	{
		base.gameObject.SetActive(value: true);
		Debug.Log("Activame!");
	}
}
