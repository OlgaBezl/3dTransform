using UnityEngine;
using DG.Tweening;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private Vector3 _target;

    private void Start()
    {
        transform.DORotate(_target, _duration).SetLoops(-1, LoopType.Restart);
    }
}
