using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spriteanimator : MonoBehaviour
{
    [SerializeField] Sprite[] mySprites; public SpriteRenderer mySpriteRenderer; 
    [SerializeField] float framesPerSecond = 12f; 
    private float secondsPerFrame; 
    private int currentFrame;
    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>(); 
        secondsPerFrame = 1/framesPerSecond; 
        Invoke("NextFrame", secondsPerFrame);
    }

    void NextFrame() 
    { 
        currentFrame = (currentFrame + 1) % mySprites.Length; 
        mySpriteRenderer.sprite = mySprites[currentFrame]; 
        Invoke("NextFrame", secondsPerFrame); 
    }
}
