using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WitchTime : MonoBehaviour
{
    public float slowmoTime = 5.5f, slowedTime = 0.25f;
    public AudioClip witchTime;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(SlowTime());
        }
    }
    IEnumerator SlowTime()
    {
        Time.timeScale = slowedTime;
        Debug.Log("Slowed time.");
        AudioManager.instance.PlayAudio(witchTime, "witchTimeSound");
        yield return new WaitForSeconds(slowmoTime);
        Time.timeScale = 1;
        Debug.Log("Time restored.");
    }
}
