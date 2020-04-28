using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMeasureTest : MonoBehaviour
{
    public Texture2D measureTexture;
    private Sprite mySprite;
    private SpriteRenderer sr;

    void Awake()
    {
        sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(measureTexture.width);
        mySprite = Sprite.Create(measureTexture, 
                                 new Rect(0.0f, 0.0f, measureTexture.width, measureTexture.height),
                                 new Vector2(0.0f, 0.5f), 100.0f);
        sr.sprite = mySprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
