using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ActiveCharacter[] activeCharacters;
    public ActiveCharacter currentCharacter;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchChar();
        }
   
    }
    public void SwitchChar()
    {
       var activeCharacter = activeCharacters[ Random.Range(0, activeCharacters.Length)];
        activeCharacter.gameObject.SetActive(true);
        currentCharacter.gameObject.SetActive(false);
        currentCharacter = activeCharacter;
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.layer == 7)
        {
            currentCharacter.ApplyDamage(collision.gameObject.GetComponent<IDamagable>());
        }

        
    }
}
