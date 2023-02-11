using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PolymorphismC : PillarControl  // INHERITANCE
{
    // Start is called before the first frame update
    public override void Start()   //POLYMORPHISM
    {
        pillarNum = 2;
        pillarName = "Polymorphism";
        pillarText = "The word polymorphism means having many forms. It is the ability to take more than one form. It is a feature that provides a function or an operator with more than one definition. It can be implemented using function overloading, operator overload, function overriding, virtual function. An operation may show off different behaviors at different times. C++ supports operator overloading and function overloading.";

        GetPillar();  //find the cube and animator

    }



}