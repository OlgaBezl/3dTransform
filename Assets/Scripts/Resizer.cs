using DG.Tweening;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private Vector3 _target;

    private void Start()
    {
        transform.DOScale(_target, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
