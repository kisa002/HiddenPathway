using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public int userMode;

	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	public void MenuClick(int menu)
    {
        userMode = menu;

        SceneManager.LoadScene("HiddenPathway");
    }
}
