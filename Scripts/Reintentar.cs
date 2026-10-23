// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Reintentar
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reintentar : MonoBehaviour
{
	[SerializeField]
	public GameObject panel;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void EnablePanel()
	{
		panel.SetActive(value: true);
	}

	public void ReintentarJuego()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
