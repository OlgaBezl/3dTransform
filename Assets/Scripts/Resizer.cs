using UnityEngine;

public class Resizer : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private void Update()
    {
        float scaleFactor = _speed * Time.deltaTime;
        transform.localScale += Vector3.one * scaleFactor;
    }
}
