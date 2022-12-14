using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public NetworkManager NetworkManager;

    private void Start()
    {
        NetworkManager = GameObject.Find("NetworkManager").GetComponent<NetworkManager>();
    }

    public void OnClick()
    {
        NetworkManager.SendMessage("draw");
    }

}
