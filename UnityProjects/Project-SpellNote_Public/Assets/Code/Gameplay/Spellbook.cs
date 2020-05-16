using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spellbook : MonoBehaviour
{
    public List<Spell> characterSpells = new List<Spell>();
    public SpellDatabase spellDatabase;
    public ToneBar playerToneBar;
    public ToneBar enemyToneBar;

    //private void Start()
    //{
    //    foreach(Spell spell in spellDatabase.spells)
    //    {
    //        characterSpells.Add(spell);
    //    }
    //}

    //public void GiveSpell(int id)
    //{
    //    Spell spellToAdd = spellDatabase.GetSpell(id);
    //    characterSpells.Add(spellToAdd);
    //    Debug.Log("Added item: " + spellToAdd.title);
    //}

    public void CastSpell(int id)
    {
        Spell spell = spellDatabase.GetSpell(id);
        spell.StatsToEffect(playerToneBar, enemyToneBar);
    }
}
