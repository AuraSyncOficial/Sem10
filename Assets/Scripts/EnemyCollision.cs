using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public float time = 3f;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("enemy"))
        {

            Destroy(other.gameObject, time);
        }
    }
}