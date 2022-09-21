using UnityEngine;

public class moveobject : MonoBehaviour
{public float speed = 1;

    // code for moving a object
    void Update()
    {
       float xDirection = Input.GetAxis("Horizontal");
       float zDirection = Input.GetAxis("Vertical");

       Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

       transform.position += moveDirection * speed;
    }
}
