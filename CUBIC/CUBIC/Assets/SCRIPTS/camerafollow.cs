using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offSet;
    void Update()
    {
        transform.position = player.position + offSet;
    }
}
