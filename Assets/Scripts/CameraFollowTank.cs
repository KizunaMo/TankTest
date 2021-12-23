using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTank : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] Vector3 offsetPos = new Vector3(0.0f, 6.0f, -12.0f);
    [SerializeField] Vector3 offsetRot = new Vector3(3.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("TankPlayer(Clone)");
        this.transform.forward = player.transform.forward;
        this.transform.Rotate(offsetRot);
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;
        this.transform.position = player.transform.position + offsetPos;

    }
}
