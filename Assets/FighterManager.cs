using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterManager : MonoBehaviour
{
    public GameObject fighterPrefab; //fighter character
    public int teamSize = 3; // size of each team of fighters
    public string[] fighterNames;  //list of fighter names
    public GameObject[] teamAFighters;  //fighter team
    public GameObject[] teamBFighters; //fighter team

    // Start is called before the first frame update
    void Start() //code to create and call team
    {
        teamAFighters = CreateTeam(teamAFighters);
        teamBFighters = CreateTeam(teamBFighters);

        //assign two fighters to battle
        GameObject randomA = teamAFighters[Random.Range(0, teamSize)];
        GameObject randomB = teamBFighters[Random.Range(0, teamSize)];
 

        //assign fighter stats
    }

    public GameObject[] CreateTeam(GameObject[] incTeam)
    {
        //create team and spawn fighters
        incTeam = new GameObject[teamSize];
        for(int i = 0; i < teamSize; i++)
        {
            GameObject go = Instantiate(fighterPrefab); // spawning fighter
            incTeam[i] = go; //assigning fighter to team
            go.GetComponent<Character>().UpdateName(fighterNames[Random.Range(0, fighterNames.Length)]); //random name for fighter
        }
        return incTeam;
    }
    // Update is called once per frame
    void Update()
    {

        int killed = 0;
        for (int i = 0; i < teamSize; i++)
        {
            if (teamAFighters[i].GetComponent<Stats>().health <= 0)
            {
                killed++;
            }
            if (killed >= teamSize)
            {
                Debug.Log("Team A is defeated!");
                Application.Quit();
            }
        }
        killed = 0;
        for (int x = 0; x < teamSize; x++)
        {
            if (teamBFighters[x].GetComponent<Stats>().health <= 0)
            {
                killed++; //character defeated
            }
            else
            {
                
            }
            if (killed >= teamSize)
            {
                Debug.Log("Team B is defeated!");
                Application.Quit();
            }
        }
    }
}
