using System;
using UnityEngine;
using TMPro;
public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void OnEnable()
    {
        EventHub.Onscore += RefreshScoreUI;
    }

    private void OnDisable()
    {
        EventHub.Onscore -= RefreshScoreUI;
    }

    private void RefreshScoreUI(float score)
    {
        _scoreText.text = ScoreManager.instance.CurrentScore.ToString("0");
    }

    private void Start()
    {
        EventHub.Onscore += RefreshScoreUI;
    }


}
