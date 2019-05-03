using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField] float score = 0;
    [SerializeField] Text myText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = score + Time.deltaTime;
        myText.text = score.ToString();
    }

    public void GameOver()
    {
        PlayerPrefs.SetFloat("playerScore", score);
        SceneManager.LoadScene("Lose Scene");
    }
}
