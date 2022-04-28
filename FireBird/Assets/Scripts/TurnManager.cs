using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour 
{
    static Dictionary<string, List<TacticsMove>> units = new Dictionary<string, List<TacticsMove>>();
    static Queue<string> turnKey = new Queue<string>();
    static Queue<TacticsMove> turnTeam = new Queue<TacticsMove>();

    
    public static GameObject ded;

    // Use this for initialization
    void Start () 
	{
        Time.timeScale = 1;
        ded = GameObject.FindGameObjectWithTag("dedScreen");
        ded.SetActive(false);
        ded.gameObject.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
        ded.gameObject.transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () 
	{
        if (turnTeam.Count == 0)
        {
            InitTeamTurnQueue();
        }
	}

    static void InitTeamTurnQueue()
    {
        List<TacticsMove> teamList = units[turnKey.Peek()];

        foreach (TacticsMove unit in teamList)
        {
            turnTeam.Enqueue(unit);
            Debug.Log(units[unit.tag].Count + " is the amount in team "+ unit.tag);
        }
        //Debug.Log(units[]);

        StartTurn();
    }

    public static void StartTurn()
    {
        Debug.Log("RIGHT OVER HERE!");
        Debug.Log ("the teams count iz: " + turnTeam.Count);
        if (turnTeam.Count > 0)
        {
            turnTeam.Peek().BeginTurn();
        }
    }

    public static void EndTurn()
    {
        TacticsMove unit = turnTeam.Dequeue();
        unit.EndTurn();
        //AttackScript.Attack();

        if (turnTeam.Count > 0)
        {
            StartTurn();
        }
        else
        {
            string team = turnKey.Dequeue();
            turnKey.Enqueue(team);
            InitTeamTurnQueue();
        }
    }

    public static void AddUnit(TacticsMove unit)
    {


        // Debug.Log("addwork");

        List<TacticsMove> list;

        if (!units.ContainsKey(unit.tag))
        {
            list = new List<TacticsMove>();
            units[unit.tag] = list;
            Debug.Log(list);

            if (!turnKey.Contains(unit.tag))
            {
                turnKey.Enqueue(unit.tag);
            }
        }
        else
        {
            list = units[unit.tag];
        }

        list.Add(unit);
        Debug.Log("addwork");
    }

    public void FixedUpdate()
    {
        //if()
    }






    public static void RemoveUnit(TacticsMove unit, GameObject ded)
    {
        // List<TacticsMove> list;
        //Debug.Log("Remove work");
        //GameObject ded;
        //GameObject ded = TurnManager ded;
        int d = units[unit.tag].Count;
        Debug.Log(unit.tag + " count is " + units[unit.tag].Count);
        units[unit.tag].Remove(unit);
        Destroy(unit);
        int s = d - units[unit.tag].Count;
        Debug.Log("unit count changed by " + s + unit.tag);

        if (units[unit.tag].Count <=0)
        {
            Debug.Log(unit.tag +" Count = 0");
            Time.timeScale = 0;
            ded.gameObject.SetActive(true);
            if (units["NPC"].Count <= 0)
            {
                ded.gameObject.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
            }
            if (units["Player"].Count <= 0)
            {
                ded.gameObject.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
            }
            units.Clear();
            turnTeam.Clear();
        }
        
        
        //AddUnit().list.Remove(unit);
    }    
    
    /*public static void EndGame(TurnManager ded)
    {
        if (units[unit.tag].Count <= 0)
        {
            Debug.Log("Count = 0");

            ded.gameObject.SetActive(true);
        }
    }
    */

}
