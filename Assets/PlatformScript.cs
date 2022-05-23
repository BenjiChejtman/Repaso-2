using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float xSpeed;
    public float xRightLimit;
    public float xLeftLimit;
    public bool toRight;
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(toRight) // si el booleano es true que se mueva para la derecha
        {
            transform.position += new Vector3(xSpeed, 0, 0);  //+= para que se vaya incrementando el valor y se desplaze.
        }
        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }

        if(transform.position.x >= xRightLimit) //no es exacto, entonces ponemos mayor o igual //si se pasa o llega ala rightlimit.
        {
            toRight = false;
        }
        else if (transform.position.x <= xLeftLimit) 
        {
            toRight = true;
        }
        
    }
}
