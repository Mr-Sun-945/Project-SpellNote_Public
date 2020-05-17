using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell
{
    public int id;
    public string title;
    public string description;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Spell(int id, string title, string description, Dictionary<string,int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.stats = stats;
    }

    public void StatsToEffect(ToneBar playerToneBar, ToneBar enemyToneBar)
    {
        foreach(KeyValuePair<string, int> entry in stats)
        {
            string type = entry.Key;
            int amount = entry.Value;

            // GoSharp on the target ToneBar
            if (type.Equals("oSharp"))  // Offense
            {
                enemyToneBar.GoSharp(amount);
                continue;
            }
            if (type.Equals("dSharp"))  // Defense
            {
                playerToneBar.GoSharp(amount);
                continue;
            }

            // GoFlat on the target ToneBar
            if (type.Equals("oFlat"))  // Offense
            {
                enemyToneBar.GoFlat(amount);
                continue;
            }
            if (type.Equals("dFlat"))  // Defense
            {
                playerToneBar.GoFlat(amount);
                continue;
            }
        }
    }
}
