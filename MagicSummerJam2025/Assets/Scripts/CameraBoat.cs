using UnityEngine;

public class CameraBoat : MonoBehaviour
{
    public Transform Boat;
    public Vector3 offset;
    public float speed = 4f;

    private void FixedUpdate()
    {
       Vector3 targetPosition = Boat.position + offset;

       transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime); 

       Vector3 direction = Boat.position - transform.position;
       Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 3f * Time.deltaTime);
    }
}
