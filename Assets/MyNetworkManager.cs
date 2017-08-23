using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

    public override void OnStartHost () {
        Debug.Log("Host started at " + GetCurrentDateTime());
    }

    public void MyStartHost () {
        Debug.Log("Starting host at " + GetCurrentDateTime());
        StartHost();
    }

    private string GetCurrentDateTime () {
        DateTime now = DateTime.Now;
        string nowFormatted = now.ToString("yyyy-MM-dd HH:mm:ss");

        return nowFormatted;
    }
}
