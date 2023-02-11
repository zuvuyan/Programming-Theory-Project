using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = true;
    public bool infoBoxActive;
    public TextMeshProUGUI infoText;
    public GameObject infoScreen;
    // initalise array of 4 pillars
    public GameObject[] fourPillars = new GameObject[4];
    public GameObject pillarPrefab;


    // Start is called before the first frame update
    void Start()
    {
        // make objects - abstracted method
        MakePillars();

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
            infoBoxActive = false;
            infoScreen.gameObject.SetActive(infoBoxActive);

        }
    }


    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    private void MakePillars()
    {
        // Initialise array of pillar positions
        float pillarYPos = -0.2f;
        Vector3[] pillarPos = new[]
        {
        new Vector3 (-6.2f, pillarYPos, 0),
        new Vector3(-2f, pillarYPos, 0),
        new Vector3(1.9f, pillarYPos, 0),
        new Vector3(5.8f, pillarYPos, 0)
        };

        // Make the pillars
        for (int i = 0; i < fourPillars.Length; i++)     
            Instantiate(pillarPrefab, pillarPos[i], Quaternion.identity);      

    }
      

}  //END

    



    
   





