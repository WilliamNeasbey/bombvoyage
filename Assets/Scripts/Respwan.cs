using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respwan : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider test)
    {

        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}
