using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public Sprite playerDead;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit detected");
        Time.timeScale = 0f;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = playerDead;
    }
}
