using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractionC : PillarControl  // INHERITANCE
{
    // Start is called before the first frame update
    public override void Start()    //POLYMORPHISM
    {
        pillarNum = 0;
        pillarName = "Abstraction";
        pillarText = "Data abstraction is the most essential function of object-oriented programming in C++. Abstraction means displaying only basic information and hiding the details. Data abstraction refers to providing only necessary information about the data to the outside world, hiding the background info or implementation. We can implement Abstraction in C++ using classes.The class helps us group data members and member functions using available access specifiers.A class can decide which data member will be visible to the outside world and not.";

        GetPillar();  //find the cube and animator

    }



}
