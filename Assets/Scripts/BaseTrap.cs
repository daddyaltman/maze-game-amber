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
        currentTrap.gameObject.SetActive(false);
        currentTrap = ActiveTrap;

    }
    public void Start()
    {
        SpawnTrap();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Debug.Log("hit trap");
            SpawnTrap();
            currentTrap.ApplyDamage(collision.gameObject.GetComponent<IDamagable>());
        }


    }

}
