using UnityEngine;
using UnityEngine.InputSystem;

public class Mouselook : MonoBehaviour
{
    [Tooltip("How far in degrees can you move the camera up")]
    public float TopClamp = 70.0f;

    [Tooltip("How far in degrees can you move the camera down")]
    public float BottomClamp = -30.0f;


    public float Sensitivity = 1.0f;

    private static float ClampAngle(float lfAngle, float lfMin, float lfMax)
    {
        if (lfAngle < -360f) lfAngle += 360f;
        if (lfAngle > 360f) lfAngle -= 360f;
        return Mathf.Clamp(lfAngle, lfMin, lfMax);
    }

    Vector2 rotation = Vector2.zero;


    private void Update()
    {
        rotation.y += Input.GetAxis("Mouse X") * Sensitivity;
        rotation.x += -Input.GetAxis("Mouse Y") * Sensitivity;
        rotation.y = ClampAngle(rotation.y, float.MinValue, float.MaxValue);
        rotation.x = ClampAngle(rotation.x, float.MinValue, float.MaxValue);

        transform.eulerAngles = (Vector2)rotation;
    }  
}
