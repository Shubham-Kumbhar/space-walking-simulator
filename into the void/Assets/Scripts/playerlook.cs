using UnityEngine;

public class playerlook : MonoBehaviour
{

    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}
