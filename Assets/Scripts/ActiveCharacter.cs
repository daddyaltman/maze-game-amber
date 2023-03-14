using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActiveCharacter : MonoBehaviour, IDamagable
{
    public Rigidbody2D body;
    float horizontal;
    float vertical;
    public float speed = 16.0f;
    protected int maxHp;
    protected int currentHp;

    public LayerMask whatIDamage;


    private void Update()
    {
        Movment();
    }
    public virtual void Movment()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        body.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
     public abstract void ApplyDamage(IDamagable damage);
   
    
    public abstract void CharacterPowers();

    public void Die()
    {
        Destroy(gameObject);
    }
    public void TakeDamage(int damage)
    {

    }

   
}
