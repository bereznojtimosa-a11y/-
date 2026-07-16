using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{   //составление значений
    public int heath = 5;
    public int level = 3;
    public float speed = 2.1f;
    
     
    // Start is called before the first frame update
    void Start()
    {   //изменение значения
        heath += level;
        // вывод полученого
        print(heath);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
