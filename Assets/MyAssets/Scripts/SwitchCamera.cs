using UnityEngine;
using Mirror;

public class SwitchCamera : NetworkBehaviour
{
    public NetworkIdentity NI;
    void Awake()
    {
        if (!NI.hasAuthority)
        {
            GetComponent<Camera>().enabled = false;
            GetComponent<AudioListener>().enabled = false;
        }
    }
}