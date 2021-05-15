using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEndScore : MonoBehaviour
{
    public Text finalScore;

    void Start()
    {
        finalScore.text = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>().text;
    }
}
