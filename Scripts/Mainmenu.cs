// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Mainmenu
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
	private void Start()
	{
		Object.FindObjectOfType<Movement>().StopMovent();
	}

	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		Object.FindObjectOfType<Movement>().EnableMovent();
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
