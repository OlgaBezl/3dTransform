using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration = 1f;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("������", _duration)).
                 Append(_text.DOText(" � ����� �����", _duration).SetRelative()).
                 Append(_text.DOText("������� ���������� �����", _duration, true));
    }
}
