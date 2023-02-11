using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarControl : MonoBehaviour
{
    private GameManager gameManager;
    public Color pillarColor;
    public Material pillarMaterial;
    public Material glassMaterial;
    public string pillarName;
    //public static string pillarText = "Test Text";
    public static string[] pillarText = new string[4];
    public int stringIndex = 0;
   
    // references to child cube object so we can manipulate it
private GameObject pillarChild;
    private Animator m_Animator;


    // Start is called before the first frame update
    void Start()
    {
        // Setup the info strings
        pillarText[0] = "Data abstraction is the most essential function of object-oriented programming in C++. Abstraction means displaying only basic information and hiding the details. Data abstraction refers to providing only necessary information about the data to the outside world, hiding the background info or implementation. We can implement Abstraction in C++ using classes.The class helps us group data members and member functions using available access specifiers.A class can decide which data member will be visible to the outside world and not.";
        pillarText[1] = "Inheritance is the process in which two classes have a relationship with each other, and objects of one class acquire properties and features of the other class. The class which inherits the features is known as the child class, and the class whose features it inherited is called the parent class.";
        pillarText[2] = "The word polymorphism means having many forms. It is the ability to take more than one form. It is a feature that provides a function or an operator with more than one definition. It can be implemented using function overloading, operator overload, function overriding, virtual function. An operation may show off different behaviors at different times. C++ supports operator overloading and function overloading.";
        pillarText[3] = "In common terms, Encapsulation is defined as wrapping up of data and information under a single unit. In object-oriented programming, Encapsulation is defined as binding together the data and the functions that manipulate them. Encapsulation also leads to data abstraction or hiding. Using Encapsulation also hides the data.";


    gameManager = GameObject.Find("Canvas").GetComponent<GameManager>();
        //Debug.Log(" Game Manager object initialized");

        GetPillar();  //find the cube and animator
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            // Flash the pillar
            FlashPillar();

            // set info Box text
            gameManager.infoText.text = pillarText[stringIndex];
            Debug.Log("PT: " + pillarText[stringIndex]);

            // activate info Box for Pillar
            gameManager.infoBoxActive = true;
            gameManager.infoScreen.gameObject.SetActive(true);
            Debug.Log("Pillar Activated");
        }
    }

    void GetPillar()
    {
        //Find the cube child object & its animator
       
        pillarChild = transform.GetChild(0).gameObject;

        m_Animator = pillarChild.GetComponent<Animator>();

    }

    void FlashPillar()
    {    
        // Change the material, so we can flash it
        pillarChild.GetComponent<MeshRenderer>().material = pillarMaterial;

        m_Animator.SetTrigger("Flash Oneshot");   
    }

 

}
