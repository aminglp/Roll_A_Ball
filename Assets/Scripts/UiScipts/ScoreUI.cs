using System;
using UnityEngine;
using TMPro;
public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private float _score;
    private void OnEnable()
    {
        _scoreText.text = "Score:";
        EventHub.Onscore += RefreshScoreUI;
    }

    private void OnDisable()
    {
        EventHub.Onscore -= RefreshScoreUI;
    }

    private void RefreshScoreUI(float score)
    {
        _score = ScoreManager.instance.CurrentScore;//get property
        _scoreText.text = $"Score: {_score}";
    }

    private void Start()
    {
        EventHub.Onscore += RefreshScoreUI;
    }


}
