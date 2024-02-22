using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [SerializeField] int Count = 0;
    [SerializeField] TMP_Text Text;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore()
    {
        Count++;
        Text.SetText(Count.ToString());
    }
}
