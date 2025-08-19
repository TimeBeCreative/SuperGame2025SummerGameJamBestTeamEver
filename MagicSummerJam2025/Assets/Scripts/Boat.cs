using UnityEngine;
using Unity.Collections;


public class Boat : MonoBehaviour
{

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    
    private void FixedUpdate()
    {
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * 5f *  Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * 100f * Time.deltaTime);

        }
       else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * -100f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            _animator.SetBool("IsJumping", true);
        }
        else
        {
            _animator.SetBool("IsJumping", false);

            Vector3 pos = transform.position;
            pos.y = Mathf.Lerp(pos.y, -0.45f, Time.deltaTime * 2f);
            transform.position = pos;

            Quaternion targetRotation = Quaternion.Euler(0f, transform.eulerAngles.y, 0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2f);

        }
     


     
    }
}
