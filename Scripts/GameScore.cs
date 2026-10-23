// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameScore
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
	public static int scoreValue;

	public Text score;

	private void Start()
	{
		scoreValue = 0;
	}

	private void Update()
	{
		score.text = "Puntos: " + scoreValue;
	}
}
