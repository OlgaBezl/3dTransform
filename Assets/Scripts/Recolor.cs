using DG.Tweening;
using UnityEngine;

public class Recolor : MonoBehaviour
{
    [SerializeField] private float _duration = 5f;
    [SerializeField] private Color _targetColor;
    [SerializeField] private Material _material;

    private void Start()
    {
        _material.DOColor(_targetColor, _duration);
    }
}
