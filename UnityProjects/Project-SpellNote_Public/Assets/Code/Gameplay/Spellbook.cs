using System;
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
    public GameObject spellFeedbackPrefab;
    private float lastCastTime = 0;

    private Vector3 spellFeedbackPos;
    private float feedbackOffset = 0.25f;
    private float feedbackYPos = -2.8f;
    
    
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
        // Stop casting from happening in quick succession
        float castTime = Time.time;
        if (castTime - lastCastTime < 0.2f)
        {
            Debug.Log("Casting on cooldown!");
            return;
        }
        else
        {
            lastCastTime = castTime;
        }

        // If using a metronome, verify that the note falls on a playable measure and is accurate
        if (requireMetronome == true)
        {
            double beatsPassed = note.GetBeatsPassed();

            // NOTE: Starts unplayable, alternating each measure.
            // Return if the user if casting inside of an unplayable measure
            double quantizedBeat = beatsPassed - (Math.Floor((beatsPassed - 1) / 8) * 8);
            if (quantizedBeat < 4.5 || 8.5 < quantizedBeat) // NOTE: unplayable is 1-4, playable is 5-8
            {
                Debug.Log("Cast failed due to unplayable measure");
                return;
            }

            // Check for note success
            bool success = note.CheckHitSuccess(beatsPassed);
            // Return early if the spell wasn't cast accurately enough
            if (success == false)
            {
                Debug.Log("Cast failed!");
                return;
            }
        }

        Spell spell = spellDatabase.GetSpell(id);
/*
        Vector3 toneBarPos = playerToneBar.transform.position;
        // Check if the toneBar is player 1 or 2 and getting to position for the spellFeedback
        if (toneBarPos.x > 0)
        {
            spellFeedbackPos = new Vector3(toneBarPos.x - feedbackOffset, feedbackYPos, toneBarPos.z);
        }
        else
        {
            spellFeedbackPos = new Vector3(toneBarPos.x + feedbackOffset, feedbackYPos, toneBarPos.z);
        }
        // Assigning the position to the spellFeedbadck GameBoject
        GameObject spellFeedback = Instantiate(spellFeedbackPrefab, spellFeedbackPos, Quaternion.identity);
        // Putting the sprite form the Resources folder onto the GameObject
        SpriteRenderer spellFeedbackRenderer = spellFeedback.GetComponent<SpriteRenderer>();
*/        
        if (id == 0 || id == 1)
        {
            playerToneBar.castingFeedbackSprite = Resources.Load("castingFeedback", typeof(Sprite)) as Sprite;
        }
        else
        {
            playerToneBar.castingFeedbackSprite = Resources.Load("castingFeedback2", typeof(Sprite)) as Sprite;
        }

        spell.StatsToEffect(playerToneBar, enemyToneBar);
        return;
    }
}
