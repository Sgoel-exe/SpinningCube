using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float angularAcc = 8f;
    [SerializeField] private float maxAngularSpeed = 50f;
    private float angularSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMotion = Input.GetAxis("Horizontal");
        if(horizontalMotion != 0f)
        {
            Accelerate(horizontalMotion);
        }
        else
        {
            deaccelerate();
        }

    }

    void Accelerate(float direction)
    {
        if(angularSpeed < maxAngularSpeed)
        {
            angularSpeed += direction * angularAcc * Time.deltaTime;
        }
        transform.Rotate(Vector3.down, angularSpeed * Time.deltaTime);
    }

    void deaccelerate()
    {
        if(angularSpeed > 0f)
        {
            angularSpeed -= angularAcc * Time.deltaTime;
        }
        else
        {
            angularSpeed += angularAcc * Time.deltaTime;
        }
        transform.Rotate(Vector3.down, angularSpeed * Time.deltaTime);
    }
}
