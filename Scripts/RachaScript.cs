// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// RachaScript
using UnityEngine;
using UnityEngine.UI;

public class RachaScript : MonoBehaviour
{
	public Text rachaTxt;

	public int racha;

	public static bool rompeRacha;

	public static bool rebota;

	public static string reboteEsperado;

	public static string reboteInicial;

	public static string reboteActual;

	[SerializeField]
	private GameObject rachaObj;

	public void resetText()
	{
		racha = 0;
		rachaTxt.enabled = false;
		rompeRacha = false;
		rebota = false;
	}

	private void Start()
	{
		racha = 0;
	}

	private void Update()
	{
		if (!rompeRacha && rebota)
		{
			if (racha == 0)
			{
				racha = 1;
				CreaTextoRacha(racha);
				CreaVoces(racha);
				rebota = false;
			}
			else if (ReboteEsperado(reboteEsperado, reboteActual))
			{
				racha++;
				rebota = false;
				if (reboteEsperado == "Left limit")
				{
					reboteEsperado = "Right limit";
				}
				else if (reboteEsperado == "Right limit")
				{
					reboteEsperado = "Left limit";
				}
				CreaTextoRacha(racha);
				CreaVoces(racha);
				if (PuntosScena2.rachaMasAlta < racha)
				{
					PuntosScena2.rachaMasAlta = racha;
				}
			}
		}
		else if (rompeRacha)
		{
			resetText();
		}
	}

	public void CreaTextoRacha(int racha1)
	{
		LeanTween.scale(rachaObj, new Vector2(1f, 1f), 0.5f).setEase(LeanTweenType.easeOutElastic);
		rachaTxt.enabled = true;
		rachaTxt.text = "Racha de " + racha1;
		rachaObj.transform.localScale = new Vector2(0f, 0f);
	}

	public void CreaVoces(int racha2)
	{
		if (racha2 == 1)
		{
			Object.FindObjectOfType<Sounds>().Yells[Random.Range(4, 6)].Play();
		}
		if (racha2 % 10 == 0)
		{
			VidaScript.Vidas++;
			Object.FindObjectOfType<Sounds>().Yells[3].Play();
		}
		if (racha2 % 5 == 0 && racha2 % 10 != 0)
		{
			Object.FindObjectOfType<Sounds>().Yells[2].Play();
		}
	}

	public static bool ReboteEsperado(string ladoEsperado, string ladoRebote)
	{
		return ladoEsperado == ladoRebote;
	}
}
