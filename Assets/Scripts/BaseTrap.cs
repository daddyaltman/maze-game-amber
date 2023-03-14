using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTrap : MonoBehaviour 
{
    public ActiveTrap[] activeTraps;
    public ActiveTrap currentTrap;
  
    public void SpawnTrap()
    {
        var ActiveTrap = activeTraps[Random.Range(0, activeTraps.Length)];
        ActiveTrap.gameObject.SetActive(true);
        currentTrap = ActiveTrap;

    }
    public void Start()
    {
        DisableUnusedTraps();
        SpawnTrap();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("player colided with trap");
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit trap");
            currentTrap.ApplyDamage(collision.gameObject.GetComponent<IDamagable>());
            currentTrap.Die();
        }


    }
    public void DisableUnusedTraps()
    {  foreach (var currentTrap in activeTraps)
        {
            currentTrap.gameObject.SetActive(false);
        }

    }

}
