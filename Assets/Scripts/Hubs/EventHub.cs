using System;
using UnityEngine;

public static class EventHub
{
    public static event Action<float> Onscore;

    public static void RaiseScore(float score)
    {
        Onscore?.Invoke(score);
    }
}
