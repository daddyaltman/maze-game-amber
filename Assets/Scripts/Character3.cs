using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character3 : ActiveCharacter
{
    public override void ApplyDamage(IDamagable damage)
    {
       damage.TakeDamage(3);
    }

    public override void CharacterPowers()
    {
        throw new System.NotImplementedException();
    }
}
