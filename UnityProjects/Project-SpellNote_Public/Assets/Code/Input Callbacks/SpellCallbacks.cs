using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellCallbacks : MonoBehaviour
{
    private Spellbook spellbook;

    void Start()
    {
        spellbook = gameObject.GetComponent<Spellbook>();
    }

    public void OnOSharp2(InputValue value)
    {
        spellbook.CastSpell(0);
    }

    public void OnDSharp2(InputValue value)
    {
        spellbook.CastSpell(1);
    }

    public void OnOFlat2(InputValue value)
    {
        spellbook.CastSpell(2);
    }

    public void OnDFlat2(InputValue value)
    {
        spellbook.CastSpell(3);
    }

    public void OnOSharp1dSharp1(InputValue value)
    {
        spellbook.CastSpell(4);
    }

    public void OnOSharp1dFlat1(InputValue value)
    {
        spellbook.CastSpell(5);
    }

    public void OnOFlat1dFlat1(InputValue value)
    {
        spellbook.CastSpell(6);
    }

    public void OnOFlat1dSharp1(InputValue value)
    {
        spellbook.CastSpell(7);
    }
}
