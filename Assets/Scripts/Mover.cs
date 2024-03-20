using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration = 5f;
    [SerializeField] private Vector3 _target;

    private void Start()
    {
        transform.DOMove(_target, _duration);
    }
}
