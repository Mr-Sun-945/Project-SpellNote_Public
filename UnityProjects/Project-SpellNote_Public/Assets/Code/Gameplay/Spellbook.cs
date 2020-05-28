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
    //public GameObject spellFeedbackPrefab;
    private float lastCastTime = 0;

    private Vector3 spellFeedbackPos;
    //private float feedbackOffset = 0.25f;
    //private float feedbackYPos = -2.8f;
    
    // private sprite vars
    private Sprite castingFeedbackSuccess;
    private Sprite castingFeedbackFail;
    
    
    void Start()
    {
        // Load in sprites for castingFeedback
        castingFeedbackSuccess = Resources.Load("CastSuccess", typeof(Sprite)) as Sprite;
        castingFeedbackFail = Resources.Load("CastFail", typeof(Sprite)) as Sprite;
    }

    void FixedUpdate()
    {
        // TODO: Some sprite management nonsense
    }
    //public void GiveSpell(int id)
    //{
    //    Spell spellToAdd = spellDatabase.GetSpell(id);
    //    characterSpells.Add(spellToAdd);
    //    Debug.Log("Added item: " + spellToAdd.title);
    //}

    public IEnumerator Fade(SpriteRenderer spriteRenderer)
    {
        for (float alpha=1f; alpha > -0.02f; alpha -= 0.1f)
        {
            Color c = spriteRenderer.color;
            c.a = alpha;
            spriteRenderer.color = c;
            yield return null;
        }
        playerToneBar.castingFeedbackSprite = null;
    }

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
            // Check for playable measure
            bool playable = note.IsMeasurePlayable();
            // Return early if the current measure is unplayable
            if (playable == false)
            {
                playerToneBar.castingFeedbackSprite = castingFeedbackFail;
                StartCoroutine("Fade", playerToneBar.castingFeedback.GetComponent<SpriteRenderer>());

                Debug.Log("Cast failed due to unplayable measure");
                return;
            }

            // Check for note success
            bool success = note.CheckHitSuccess();
            // Return early if the spell wasn't cast accurately enough
            if (success == false)
            {
                playerToneBar.castingFeedbackSprite = castingFeedbackFail;
                StartCoroutine("Fade", playerToneBar.castingFeedback.GetComponent<SpriteRenderer>());

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
        // Update castingFeedbackSprite to let the player know they've cast successfully
        playerToneBar.castingFeedbackSprite = castingFeedbackSuccess;
        StartCoroutine("Fade", playerToneBar.castingFeedback.GetComponent<SpriteRenderer>());

        spell.StatsToEffect(playerToneBar, enemyToneBar);
        return;
    }
}
