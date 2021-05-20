using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // tourne sur lui-m�me � la vitesse speed
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
        // vector3: structure donnant la direction suivant laquelle on veut appliquer le mvt
        // Time.deltaTime: fonction qui permet d'avoir le m�me mvt sur ts les ordi ind�pendamment de leur puissance
    }
}
