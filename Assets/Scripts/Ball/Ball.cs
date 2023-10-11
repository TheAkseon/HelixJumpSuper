using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out PlatformSegment platformSegment))
        {
            if(platformSegment.IsBounce == false)
            {
                platformSegment.gameObject.GetComponentInParent<Platform>().Break();
            }
        }
    }
}
