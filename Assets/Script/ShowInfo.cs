using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public GameObject infoPrefab; // Drag and drop your info canvas here in the inspector]

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entered");
            Instantiate(infoPrefab, infoPrefab.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(GameObject.FindWithTag("InfoCanvas"));
        }
    }
}
