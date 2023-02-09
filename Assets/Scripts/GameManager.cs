using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = true;
    public bool infoBoxActive;
    public TextMeshProUGUI infoText;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            // code here

        }
    }

    public void InfoExit()
    {
        if (isGameActive && infoBoxActive)
        {
            // Reset the Pillar and clear info Box
            Debug.Log("Clear info Box");
        }
    }


    public void ExitGame()
    {
        Application.Quit();
    }

}
