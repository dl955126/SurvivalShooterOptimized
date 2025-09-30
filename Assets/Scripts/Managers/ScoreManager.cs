using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    [SerializeField] UnityEvent<int> UpdateScore;

    void Awake ()
    {
        score = 0;
    }


    void Update ()
    {
        UpdateScore?.Invoke(score);
    }
}
