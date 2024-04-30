using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CeilingCollapse : MonoBehaviour
{

    public GameObject ceilingGroup;
    public GameObject canvasStart;

    public static float timeRemaining = 12;
    bool timerIsRunning = false;
    GameObject[] ceilingPieces;

    public AudioClip duelFates;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(duelFates);
    }

    public void BeginTimer()
    {
        timerIsRunning = true;
        canvasStart.SetActive(false);
    }

    public void EndTimer()
    {
        timerIsRunning = false; 
    }


    void Update()
    {

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            } else
            {
                timeRemaining = 0;
                timerIsRunning = false;

                //TRIGGER CEILING FALL
                ceilingPieces = GameObject.FindGameObjectsWithTag("FallingCeiling");
                foreach (GameObject piece in ceilingPieces)
                {
                    piece.GetComponent<Rigidbody>().useGravity = true;
                }
                            
            }
        }


        
    }
}
