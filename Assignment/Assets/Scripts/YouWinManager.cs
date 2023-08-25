using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinManager : MonoBehaviour
{
    public GameObject youWinUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            youWinUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
