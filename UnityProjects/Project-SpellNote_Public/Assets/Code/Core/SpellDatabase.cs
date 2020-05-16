using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellDatabase : MonoBehaviour
{
    public List<Spell> spells = new List<Spell>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Spell GetSpell(int spellId)
    {
        return spells.Find(spell => spell.id == spellId);
    }

    public Spell GetSpell(string spellName)
    {
        return spells.Find(spell => spell.title == spellName);
    }

    void BuildDatabase()
    {
        spells = new List<Spell>() {
            // Sharp 2's
            new Spell(0, "Offensive Sharp 2", "Make your enemy sharp!",
                    new Dictionary<string,int>
                    {
                        {"oSharp", 2},
                    }),

            new Spell(1, "Defensive Sharp 2", "Keep yourself sharp!",
                    new Dictionary<string,int>
                    {
                        {"dSharp", 2},
                    }),

            // Flat 2's
            new Spell(2, "Offensive Flat 2", "Make your enemy flat!",
                    new Dictionary<string,int>
                    {
                        {"oFlat", 2},
                    }),

            new Spell(3, "Defensive Flat 2", "Keep yourself flat!",
                    new Dictionary<string,int>
                    {
                        {"dFlat", 2},
                    }),

            // #/x's
            new Spell(4, "Offensive Sharp, Defensive Sharp", "Keep it sharp.",
                    new Dictionary<string,int>
                    {
                        {"oSharp", 1},
                        {"dSharp", 1},
                    }),

            new Spell(5, "Offensive Sharp, Defensive Flat", "Keep it balanced.",
                    new Dictionary<string,int>
                    {
                        {"oSharp", 1},
                        {"dFlat", 1},
                    }),

            // b/x's
            new Spell(6, "Offensive Flat, Defensive Flat", "Keep it flat.",
                    new Dictionary<string,int>
                    {
                        {"oFlat", 1},
                        {"dFlat", 1},
                    }),

            new Spell(7, "Offensive Flat, Defensive Sharp", "Keep it balanced.",
                    new Dictionary<string,int>
                    {
                        {"oFlat", 1},
                        {"dSharp", 1},
                    })
        };
    }
}
