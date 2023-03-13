using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap3 : ActiveTrap
{
    public override void ApplyDamage(IDamagable damage)
    {
        damage.TakeDamage(5);
    }
}

