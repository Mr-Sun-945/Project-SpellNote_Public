using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spellbook : MonoBehaviour
{
    public List<Spell> characterSpells = new List<Spell>();
    public SpellDatabase spellDatabase;
    public ToneBar playerToneBar;
    public ToneBar enemyToneBar;
    public Note note;  // This is also required if requireMetronome == true
    public bool requireMetronome = false;
    
    
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
        // If using a metronome, check for accuracy. If inaccurate, don't cast the spell.
        if (requireMetronome == true)
        {
            double beatsPassed = note.GetBeatsPassed();
            bool success = note.CheckHitSuccess(beatsPassed);
            // Return early if the spell wasn't cast accurately enough
            if (success == false)
            {
                Debug.Log("Cast failed!");
                return;
            }
        }

        Spell spell = spellDatabase.GetSpell(id);
        spell.StatsToEffect(playerToneBar, enemyToneBar);
        return;
    }
}
