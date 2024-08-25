using UnityEngine;

public class SceneAnimation : MonoBehaviour
{
    [SerializeField] private HitEvent _hitEvent;
    [SerializeField] private FXStarter _FXStarter;

    private void OnEnable()
    {
        _hitEvent.Hited += _FXStarter.Play;
    }

    private void OnDisable()
    {
        _hitEvent.Hited -= _FXStarter.Play;
    }
}
