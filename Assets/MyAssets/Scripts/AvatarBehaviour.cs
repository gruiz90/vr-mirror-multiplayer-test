using UnityEngine;
using Mirror;
using System.Collections.Generic;

/*
	Documentation: https://mirror-networking.com/docs/Guides/NetworkBehaviour.html
	API Reference: https://mirror-networking.com/docs/api/Mirror.NetworkBehaviour.html
*/

public class AvatarBehaviour : NetworkBehaviour
{
    public override void OnStartLocalPlayer()
    {
        GameObject camera = GameObject.FindWithTag("MainCamera");
        camera.SetActive(false);
        /*transform.parent = camera.transform;
        transform.localPosition = Vector3.zero;*/
    }
}
