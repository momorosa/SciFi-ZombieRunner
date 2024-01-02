using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float damage = 40f;

    PlayerHealth target;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    // Testing to see if BroadcastMessage is working
    // public void OnDamageTaken()
    // {
    //     Debug.Log(name + " I also know that we took damage");
    // }

    public void AttackHitEvent()
    {
        if (target == null) return;
        target.TakeDamage(damage);

    }
}
