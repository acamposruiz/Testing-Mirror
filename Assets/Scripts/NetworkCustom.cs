using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
using System;

public class NetworkCustom : NetworkManager
{
    public int position;
    GameObject Cube;

    public override void OnServerAddPlayer(NetworkConnection conn)
    {
     
        Debug.Log($"OnServerAddPlayer Called, connectionId: {conn.connectionId}");
    }

    void Update()
    {
    }
    public override void OnServerConnect(NetworkConnection conn)
    {
     
        Debug.Log($"OnServerConnect Called, connectionId: {conn.connectionId}");
        Debug.Log($"clientOwnedObjects.Count -----> {conn.clientOwnedObjects.Count}");
 
        base.OnServerConnect(conn);

        /* GameObject Cube = (GameObject)Instantiate(Resources.Load("Cube"));
        Cube.transform.position = new Vector3(position, 0.0F, 0.0F); */
    }
    public override void OnClientConnect(NetworkConnection conn)
    {
     
        Debug.Log($"OnClientConnect Called, connectionId: {conn.connectionId}");

        Cube = Instantiate(spawnPrefabs.Find(prefab => prefab.name == "Cube"));
         Cube.transform.position = new Vector3(position, 0.0F, 0.0F);
        NetworkServer.Spawn(Cube);
 
        base.OnClientConnect(conn);
    }
}
