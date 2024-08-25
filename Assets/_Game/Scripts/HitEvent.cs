using System;
using UnityEngine;

public class HitEvent : MonoBehaviour
{
    public event Action Hited;

    public void Hit()
    {
        Hited?.Invoke();
    }
}
