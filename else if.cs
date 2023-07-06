using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public in score;
    // Start is called before the first frame update
    void Start()
    {
        /*        if (age < 18)
        {
            Debug.Log("You are teenager");
        }
        else if(age >= 18 && age < 60)
        {
            Debug.Log("You are an adult");
        }
        else
        {
            Debug.Log("You are old");
        }*/
    switch (score)
    {
        case 10:
            Debug.Log("Perfect Score");
            break;
        case 5:
            Debug.Log("The score is half");
            break;
        default:
            Debug.Log("The score is not good enough");
            break;
    }    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
