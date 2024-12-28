using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (PlayerController.Instance != null)
            {
                PlayerController.Instance.TakeDamage(15);
            }
        }
    }

}
