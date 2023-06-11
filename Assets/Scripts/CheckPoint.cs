using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject Active;
    public GameObject desActive;

    private void OnTriggerEnter(Collider other) {
        switch(other.gameObject.tag)
        {
            case "Player":
                Active.SetActive(true);
                break;
        }
    }

    private void OnTriggerExit(Collider other) {
        switch(other.gameObject.tag)
        {
            case "Player":
                desActive.SetActive(false);
                break;
        }
    }
}
