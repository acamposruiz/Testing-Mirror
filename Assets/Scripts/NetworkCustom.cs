using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
using System;

public class NetworkCustom : NetworkManager
{
    void Update()
    {
    }
    public override void OnServerConnect(NetworkConnection conn)
    {
     
        Debug.Log($"OnServerConnect Called, connectionId: {conn.connectionId}");
 
        base.OnServerConnect(conn);
    }
    public override void OnClientConnect(NetworkConnection conn)
    {
     
        Debug.Log($"OnClientConnect Called, connectionId: {conn.connectionId}");
 
        base.OnClientConnect(conn);
    }
}
