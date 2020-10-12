using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject scoreCanvas;
    public GameObject endGameCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            scoreCanvas.SetActive(false);
            endGameCanvas.SetActive(true);
        }
    }
}
