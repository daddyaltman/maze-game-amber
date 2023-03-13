using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable 
{
   public abstract void TakeDamage(int damage);
    public abstract void Die();

   // public abstract void ApplyDamage();
}
