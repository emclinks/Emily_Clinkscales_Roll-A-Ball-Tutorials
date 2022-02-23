using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Rotate the gameobject per update by 15 x 30 x 45 per axis.
        //multiplied via Deltatime > per frame.
        
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
    }
}
