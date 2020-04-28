using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_NoteHit : MonoBehaviour
{
    void Note(InputAction.CallbackContext context)
    {
        Debug.Log("Player hit: " + context);
    }
}
