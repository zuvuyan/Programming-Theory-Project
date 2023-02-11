using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarControl : MonoBehaviour
{
    protected GameManager gameManager;
   
    [SerializeField]
    protected Material pillarMaterial;
    [SerializeField]
    protected Material glassMaterial;

    [SerializeField]
    protected Color pillarColor { get; set; }
    [SerializeField]
    protected string pillarName { get; set; } //Encapulation;
    //public static string pillarText = "Test Text";   
    protected string pillarText { get; set; } //Encapulation
    [SerializeField]
    protected int pillarNum { get; set; } //Encapulation

    // references to child cube object so we can manipulate it
    protected GameObject pillarChild;
    protected Animator m_Animator;


    // Start is called before the first frame update
    public virtual void Start()
    {

        GetPillar();  //find the cube and animator  //ABSTRACTION
    }

 

    public virtual void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            // Flash the pillar
            FlashPillar();   //ABSTRACTION

            // set info Box text
            gameManager.infoTitleText.text = pillarName;
            gameManager.infoText.text = pillarText;
            Debug.Log("PT: " + pillarText);

            // activate info Box for Pillar
            gameManager.infoBoxActive = true;
            gameManager.infoScreen.gameObject.SetActive(true);
            Debug.Log("Pillar Activated");
        }
    }

    public virtual void GetPillar()
    {
        // GET REF TO COMMUNICATE WITH GAME MANAGER SCRIPT
        gameManager = GameObject.Find("Canvas").GetComponent<GameManager>();

        //Find the cube child object & its animator

        pillarChild = transform.GetChild(0).gameObject;

        m_Animator = pillarChild.GetComponent<Animator>();

    }

    public virtual void FlashPillar()
    {    
        // Change the material, so we can flash it
        pillarChild.GetComponent<MeshRenderer>().material = pillarMaterial;

        m_Animator.SetTrigger("Flash Oneshot");   
    }

 

}
