using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    
    public float jumpFactor = 4.5f;
    
    void OnTriggerEnter(Collider other)
    {   //метод
        //больше прыжок
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;

    }

    void OnTriggerExit(Collider other)
    {   //прежнее значение
         other.GetComponent<Jump>().jumpStrength /= jumpFactor;

    }
    
}
