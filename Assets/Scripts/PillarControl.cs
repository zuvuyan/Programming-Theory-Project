using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarControl : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Canvas").GetComponent<GameManager>();
        Debug.Log(" Game Manager object initialized");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
           
            gameManager.infoText.text = "text";
            // activate info Box for Pillar
            Debug.Log("Pillar Activated");
        }
    }
}
