using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	[SerializeField] GameObject panelMenu;

	void Awake ()
	{
		panelMenu.SetActive (false); //hide menu in the start
	}

	public void ShowMenu ()
	{
		panelMenu.SetActive (true);
	}

	public void HideMenu ()
	{
		panelMenu.SetActive (false);
	}

	//user settings events

	public void OnUserClickAdsSettings ()
	{
		PlayerPrefs.SetInt ("npa", -1);
		SceneManager.LoadScene (0); //loading scene
	}
}

