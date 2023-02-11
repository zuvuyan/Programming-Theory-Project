using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncapsulationC : PillarControl  // INHERITANCE
{
    // Start is called before the first frame update
    public override void Start()
    {
        pillarNum = 3;
        pillarName = "Encapsulation";
        pillarText = "In common terms, Encapsulation is defined as wrapping up of data and information under a single unit. In object-oriented programming, Encapsulation is defined as binding together the data and the functions that manipulate them. Encapsulation also leads to data abstraction or hiding. Using Encapsulation also hides the data.";

        GetPillar();  //find the cube and animator

    }



}
