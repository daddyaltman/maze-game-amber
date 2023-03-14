using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActiveTrap : MonoBehaviour, IDamagable
{
    public LayerMask whatIDamage;


    public void Die()
    {
        Destroy(gameObject);
    }
    public void TakeDamage(int damage)
    {

    }

    public abstract void ApplyDamage(IDamagable damagable);
}
