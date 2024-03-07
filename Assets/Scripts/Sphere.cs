using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveSpeed = 1f;

    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 sphereSpeed = new Vector3();
        if(Input.GetKey(KeyCode.LeftArrow)){
            sphereSpeed.x -=moveSpeed;
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            sphereSpeed.x +=moveSpeed;
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            sphereSpeed.z +=moveSpeed;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            sphereSpeed.z -=moveSpeed;
        }
        if(Input.GetKey(KeyCode.Space)){
            sphereSpeed.y +=moveSpeed*3;
        }
        rigidbody.velocity = Vector3.Lerp(rigidbody.velocity, sphereSpeed, 2f * Time.deltaTime);
    }
}
