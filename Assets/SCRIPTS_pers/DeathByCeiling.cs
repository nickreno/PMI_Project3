using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static OVRPlugin;

public class DeathByCeiling : MonoBehaviour
{
    public GameObject deathCanvas;
    public GameObject blockDoor;

    public static bool isSafe = false;

    private void OnTriggerEnter(Collider safety)
    {
        if (safety.gameObject.name == "SafePane")
        {
            isSafe = true;
        }
    }

    private void Update()
    {

        if (CeilingCollapse.timeRemaining <= 0 && isSafe != true)
        {
            deathCanvas.SetActive(true);
            blockDoor.SetActive(true);
        }
    }
}
