using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerHealth : MonoBehaviour
{
    private int playerHealth;
    [SerializeField] private GameObject FailScreen;


    private void Start()
    {
        playerHealth = 150;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= 50;
        }
    }

    private void Update()
    {
        if(playerHealth <= 0)
        {
            gameObject.SetActive(false);
            FailScreen.SetActive(true);
        }
    }
}
