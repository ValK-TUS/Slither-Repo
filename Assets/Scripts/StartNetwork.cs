using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class StartNetwork : MonoBehaviour
{
    // Start both
    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
    }

    // Start the client
    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
    }

    // Start the server
    public void StartServer()
    {
        NetworkManager.Singleton.StartServer();
    }
}
