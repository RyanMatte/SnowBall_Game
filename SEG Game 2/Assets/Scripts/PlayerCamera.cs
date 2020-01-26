
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float yaw = 0.0f;
    public float pitch = 0.0f;
    void Update()
    {
        transform.position = player.position + offset;
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
