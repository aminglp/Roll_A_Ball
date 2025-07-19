using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private float _score;
    public float CurrentScore => _score;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddScore(float score)
    {
        _score += score;
        EventHub.RaiseScore(score);
    }
}