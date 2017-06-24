using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMenu : MonoBehaviour {

    GameManager gameManager;

    public GameObject startLearningButton;
    public GameObject gameControlPanel;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        startLearningButton = GameObject.Find("StartLearningButton");
        gameControlPanel = GameObject.Find("Canvas").transform.FindChild("GameControlPanel").gameObject;
    }

    private void Update() //이거 되게 비논리적이지만, 개발하기 귀차니즘...
    {
        if (gameManager.userMode == 2) //일반 사용자
        {
            startLearningButton.SetActive(false);
            gameControlPanel.SetActive(false);
        }

    }
}
