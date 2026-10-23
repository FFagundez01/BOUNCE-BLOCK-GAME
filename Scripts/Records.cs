// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Records
using UnityEngine;
using UnityEngine.UI;

public class Records : MonoBehaviour
{
	[SerializeField]
	public Text highestScoreTxt;

	[SerializeField]
	public Text highestRachaTxt;

	private void Start()
	{
		highestScoreTxt.text = "Puntaje Más Alto: " + PlayerPrefs.GetInt("HighestPuntoPartida");
		highestRachaTxt.text = "Racha Más Alta: " + PlayerPrefs.GetInt("HighestRachaPartida");
	}

	private void Update()
	{
	}
}
