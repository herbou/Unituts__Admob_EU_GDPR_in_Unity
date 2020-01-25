using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
	[SerializeField] [Range(2f,8f)] float loadingDelay = 2f;
	[SerializeField] GameObject GDPR_Popup;

	void Start ()
	{
		Invoke ("CheckForGDPR", 1f);
		Invoke ("StartGame", loadingDelay);
	}

	void StartGame ()
	{
		SceneManager.LoadSceneAsync (1);
	}

	//GDPR
	void CheckForGDPR ()
	{
		if (PlayerPrefs.GetInt ("npa", -1) == -1) {
			//show gdpr popup
			GDPR_Popup.SetActive (true);
			//pause the game
			Time.timeScale = 0;
		}
	}

	//Popup events
	public void OnUserClickAccept ()
	{
		PlayerPrefs.SetInt ("npa", 0);
		//hide gdpr popup
		GDPR_Popup.SetActive (false);
		//play the game
		Time.timeScale = 1;
	}

	public void OnUserClickCancel ()
	{
		PlayerPrefs.SetInt ("npa", 1);
		//hide gdpr popup
		GDPR_Popup.SetActive (false);
		//play the game
		Time.timeScale = 1;
	}

	public void OnUserClickPrivacyPolicy ()
	{
		Application.OpenURL ("https://privacyURL.com"); //your privacy url
	}

}
