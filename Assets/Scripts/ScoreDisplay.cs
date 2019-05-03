using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] Text myFinalScoreText;
    // Start is called before the first frame update
    void Start()
    {
        myFinalScoreText.text = PlayerPrefs.GetFloat("playerScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
