using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private void Update()
    {
        transform.RotateAround(Vector3.up, _speed * Time.deltaTime);
    }
}
