using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour
{
    //Code References.
    PlayerController playerController;
    //Other References
    public AudioSource Collect;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Subspace"))
        {
            other.gameObject.SetActive(false);
            Collect.Play();
            playerController.PlanetEaten();
        }
    }
}
