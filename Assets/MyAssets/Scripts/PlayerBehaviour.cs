using UnityEngine;
using Mirror;
using System.Collections.Generic;

public class PlayerBehaviour : NetworkBehaviour
{
    private GameObject mainCamera;
    public Camera playerCamera;

    private void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }
    public override void OnStartLocalPlayer()
    {
        if (mainCamera != null) {
            mainCamera.SetActive(false); 
        } 

        if (hasAuthority)
        {
            playerCamera.gameObject.SetActive(true);
        }
    }

    public override void OnStopClient()
    {
        base.OnStopClient();

        if (hasAuthority)
        {
            playerCamera.gameObject.SetActive(false);
        }

        if (mainCamera != null)
        {
            mainCamera.SetActive(true);
        }
    }
}
