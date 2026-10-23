// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Enemy
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public Transform target;

	public float speed;

	public bool isInTheZone;

	public Collider2D trigger;

	private bool unaVez;

	private void OnTriggerEnter2D(Collider2D collider)
	{
		isInTheZone = true;
		if (collider.tag == "Player")
		{
			base.gameObject.SetActive(value: false);
		}
		if (collider.tag == "Player" && !unaVez)
		{
			VidaScript.Vidas--;
			unaVez = true;
			RachaScript.rompeRacha = true;
		}
	}

	private void Start()
	{
		isInTheZone = false;
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
		Vector2 current = base.transform.position;
		Vector2 vector = target.position;
		Vector2 vector2 = new Vector2(current.x, current.y + 5f);
		if (!isInTheZone)
		{
			base.transform.position = Vector2.MoveTowards(current, vector, 1.5f * speed);
		}
		else
		{
			base.transform.position = Vector2.MoveTowards(current, vector2, 0.05f + speed);
		}
	}
}
