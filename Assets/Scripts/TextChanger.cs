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

        sequence.Append(_text.DOText("Замена", _duration)).
                 Append(_text.DOText(" и новый текст", _duration).SetRelative()).
                 Append(_text.DOText("Повтоно замененный текст", _duration, true));
    }
}
