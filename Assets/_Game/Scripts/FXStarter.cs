using UnityEngine;

public class FXStarter : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    public void Play()
    {
        _particleSystem.Play();
    }
}
