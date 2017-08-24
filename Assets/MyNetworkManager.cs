using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

    public override void OnStartHost () {
        Debug.Log(GetCurrentDateTime() + ": Host started");
    }

    public void MyStartHost () {
        Debug.Log(GetCurrentDateTime() + ": Starting host");
        StartHost();
    }

    public override void OnStartClient (NetworkClient myClient) {
        Debug.Log(GetCurrentDateTime() + ": Client start requested");
    }

    public override void OnClientConnect (NetworkConnection conn) {
        Debug.Log(GetCurrentDateTime() + ": Client is connected to IP " + conn.address);
    }

    private string GetCurrentDateTime () {
        DateTime now = DateTime.Now;
        string nowFormatted = now.ToString("yyyy-MM-dd HH:mm:ss");

        return nowFormatted;
    }
}
