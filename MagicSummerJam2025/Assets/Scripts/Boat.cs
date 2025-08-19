using UnityEngine;
using Unity.Collections;


public class Boat : MonoBehaviour
{

    
    private void FixedUpdate()
    {
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * 5f *  Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * 100f * Time.deltaTime);

        }
       else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * -100f * Time.deltaTime);
        }
       


     
    }
}
