// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Spawner
using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField]
	private GameObject Box1;

	[SerializeField]
	private GameObject Box2;

	[SerializeField]
	private GameObject Box3;

	[SerializeField]
	private float box1Time;

	[SerializeField]
	private float box2Time;

	[SerializeField]
	private float box3Time;

	private void Start()
	{
		StartCoroutine(spawnEnemy(box1Time, Box1));
		StartCoroutine(spawnEnemy(box2Time, Box2));
		StartCoroutine(spawnEnemy(box3Time, Box3));
	}

	private void Update()
	{
	}

	private IEnumerator spawnEnemy(float interval, GameObject enemy)
	{
		yield return new WaitForSeconds(interval);
		GameObject obj = Object.Instantiate(enemy, new Vector2(Random.Range(-10f, 10f), -5f), Quaternion.identity);
		obj.GetComponent<Enemy>().isInTheZone = false;
		obj.GetComponent<Enemy>().gameObject.SetActive(value: true);
		StartCoroutine(spawnEnemy(interval, enemy));
	}
}
