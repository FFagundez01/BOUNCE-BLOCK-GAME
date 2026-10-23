// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// VidaScript
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class VidaScript : MonoBehaviour
{
	public static int Vidas;

	public Text score;

	[SerializeField]
	public GameObject objVidas;

	private void Start()
	{
		Vidas = 10;
	}

	private void Update()
	{
		if (Vidas > 0)
		{
			score.text = "Vidas: " + Vidas;
		}
		else if (Vidas == 0)
		{
			score.fontSize = 120;
			score.transform.localPosition = new Vector2(0f, 0f);
			score.text = "PERDISTE";
			Object.FindObjectOfType<Sounds>().Yells[0].Play();
			Vidas = -1;
			PlayerPrefs.SetInt("HighestPuntoPartida", PuntosScena2.puntoMasAlto);
			PlayerPrefs.SetInt("HighestRachaPartida", PuntosScena2.rachaMasAlta);
			Object.FindObjectOfType<Movement>().StopMovent();
			StartCoroutine(Wait3seconds());
		}
	}

	public IEnumerator Wait3seconds()
	{
		yield return new WaitForSeconds(3f);
		Object.FindObjectOfType<Reintentar>().EnablePanel();
	}
}
