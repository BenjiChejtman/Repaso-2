using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float xSpeed;
    public float xRightLimit;
    public float xLeftLimit;
    public bool toRight;
    public GameObject prefab1;
    public GameObject prefab2;

    GameObject clone1;
    GameObject clone2;

    public GameObject baseDer;
    public GameObject baseIzq;
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
            clone2 = Instantiate(prefab2);                                                //el cambio de sentido ocurre cuando se cambian los booleanos
            //Destroy(clone2, 2);
            clone2.transform.position = baseDer.transform.position + new Vector3(0, 1, 0); //instanciamos el clone en el lugar de la Base Izquierda 1m arriba, para que se instancie justo encima de la misma


        }
        else if (transform.position.x <= xLeftLimit)    
        {
            toRight = true;
            clone1 = Instantiate(prefab1);
            //Destroy(clone1, 2);
            clone1.transform.position = baseIzq.transform.position + new Vector3(0, 1, 0); //instanciamos el clone en el lugar de la Base Izquierda 1m arriba, para que se instancie justo encima de la misma
        }
        
    }
}
