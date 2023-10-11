using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;

    public void Break()
    {
        PlatformSegment[] platformSegments = GetComponentsInChildren<PlatformSegment>();

        foreach (var platformSegment in platformSegments)
        {
            platformSegment.Bounce(_explosionForce, transform.position, _explosionRadius);
        }
    }
}
