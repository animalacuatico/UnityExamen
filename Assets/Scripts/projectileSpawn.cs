using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProjectile : MonoBehaviour
{
    public float destroyProjectileTime = 2;
    private float currentTime;
    private void Update()
    {
        currentTime = Time.deltaTime;
        if (currentTime >= destroyProjectileTime)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<MarioScript>())
        {
            GameManager.instance.LoadScene("Game");
        }
    }
}
