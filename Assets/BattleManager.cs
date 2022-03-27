using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void Battle(GameObject fighterA, GameObject fighterB)
    {
        Character fAStats = fighterA.GetComponent<Character>(); //assigning stats
        Character fBStats = fighterB.GetComponent<Character>();  //assigning stats
       
        if (fAStats.attack > fBStats.defense)
        {
            fBStats.health -= fAStats.attack - fBStats.defense;
            Debug.Log("Fighter A attacks Fighter B");
            Debug.Log("Fighter B's health is now: " + fBStats.health);
        }
        else
        {
            fAStats.health -= fBStats.attack - fAStats.defense;
            Debug.Log("Fighter B attacks Fighter A");
            Debug.Log("Fighter A's health is now: " + fAStats.health);
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Battle(GameObject fighterA, GameObject fighterB);
        }

    } 
}
