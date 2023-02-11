using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceC : PillarControl  // INHERITANCE
{
    // Start is called before the first frame update
    public override void Start()    //POLYMORPHISM
    {
        pillarNum = 1;
        pillarName = "Inheritance";
        pillarText = "Inheritance is the process in which two classes have a relationship with each other, and objects of one class acquire properties and features of the other class. The class which inherits the features is known as the child class, and the class whose features it inherited is called the parent class.";

        GetPillar();  //find the cube and animator

    }



}