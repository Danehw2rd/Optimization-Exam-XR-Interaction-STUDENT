using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score;
    [SerializeField]
    Text textScore1, textScore2;

    public void UpdateScore()
    {
        score++;
        textScore2.text = "Score: " + score;
        textScore1.text = "Score: " + score;
    }

}
