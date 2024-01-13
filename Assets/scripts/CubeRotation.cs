using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float angularAcc = 5f;
    [SerializeField] private float maxAngularSpeed = 40f;
    private float angularSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMotion = Input.GetAxis("Horizontal");
        if(horizontalMotion > 0f)
        {
            angularSpeed += horizontalMotion * angularAcc * Time.deltaTime;
            transform.Rotate(Vector3.down, horizontalMotion * angularSpeed * Time.deltaTime);
        }
        else if(horizontalMotion < 0f)
        {
            angularSpeed += horizontalMotion * angularAcc * Time.deltaTime;
            transform.Rotate(Vector3.up, -horizontalMotion * angularSpeed * Time.deltaTime);
        }
        else
        {
            angularSpeed = 0f;
        }

    }
}
