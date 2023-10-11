using UnityEngine;

public class TowerRotator : MonoBehaviour
{
    [SerializeField] private float _angleMultiplier;

    private const string NameAxis = "Mouse X";

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float horizontalInput = Input.GetAxisRaw(NameAxis);
            float angle = -horizontalInput * _angleMultiplier * Time.deltaTime;
            transform.Rotate(Vector3.up, angle);
        }
    }
}
