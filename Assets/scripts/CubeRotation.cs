using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float angularAcc = 8f;
    [SerializeField] private float maxAngularSpeed = 50f;
    [Range(1f, 2f), SerializeField] private float extraAcc = 1.2f;
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

    /**
    * <summary>
    * Accelerates the rotation of the object around the rotation point.
    * </summary>
    * <param name="direction">The direction of the acceleration. Positive is clockwise, negative is counterclockwise.</param>
    */
    void Accelerate(float direction)
    {
        if(angularSpeed < maxAngularSpeed)
        {
            angularSpeed += direction * angularAcc * Time.deltaTime * extraAcc;
        }
        transform.Rotate(Vector3.down, angularSpeed * Time.deltaTime);
    }

    /**
    * <summary>
    * Deaccelerates the rotation of the object around the rotation point.
    * </summary>
    */
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
