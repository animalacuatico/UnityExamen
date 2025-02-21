using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lakitu : MonoBehaviour
{
    public float LakituSpeed = 5, cooldownSpawn = 5, movementTime = 3f;
    private Rigidbody2D rb2D;
    private Vector2 dirVectorRight;
    private Vector2 dirVectorLeft;
    public GameObject objectToSpawn;
    void Start()
    {
        dirVectorRight = new Vector2(3, 0);
        dirVectorLeft = new Vector2(-3, 0);
        rb2D = GetComponent<Rigidbody2D>();
        StartCoroutine(GoRight());
    }
    IEnumerator GoRight()
    {
        transform.Translate(dirVectorRight);
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(movementTime);
        StartCoroutine(GoLeft());
    }
    IEnumerator GoLeft()
    {
        transform.Translate(dirVectorLeft);
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(movementTime);
        StartCoroutine(GoRight());
    }

}
