using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAround : MonoBehaviour
{
    public Transform rotationPoint;
    [SerializeField] private float angularAcc = 8f;
    [SerializeField] private float maxAngularSpeed = 50f;
    [Range(1f,2f),SerializeField] private float extraAcc = 1.2f;
    private float angularSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMotion = Input.GetAxis("Horizontal");
        if (horizontalMotion != 0f)
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
        if (angularSpeed < maxAngularSpeed)
        {
            angularSpeed += direction * angularAcc * Time.deltaTime * extraAcc;
        }
        transform.RotateAround(rotationPoint.position, Vector3.up, angularSpeed * Time.deltaTime);
    }

    void deaccelerate()
    {
        if (angularSpeed > 0f)
        {
            angularSpeed -= angularAcc * Time.deltaTime;
        }
        else
        {
            angularSpeed += angularAcc * Time.deltaTime;
        }
        transform.RotateAround(rotationPoint.position, Vector3.up, angularSpeed * Time.deltaTime);
    }
}
