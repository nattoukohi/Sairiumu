using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ChangeMaterial : MonoBehaviour {
    //private SteamVR_TrackedObject trackedObj;
    public Material[] _material;
    private int i;
    public GameObject buki;

    public SteamVR_Input_Sources hand;
    public SteamVR_Action_Boolean grabAction;
    public SteamVR_Action_Boolean grabAction2;

    // Use this for initialization
    void Start () {
        i = 0;
	}
	
	// Update is called once per frame
	void Update () {
        var trackedObject = GetComponent<Valve.VR.SteamVR_TrackedObject>();

        if (grabAction.GetStateDown(hand))
        {
            i++;
            if (i >= _material.Length)
            {
                i = 0;
            }
            this.GetComponent<Renderer>().material = _material[i];

        }

        if (SteamVR_Input._default.inActions.Teleport.GetStateDown(SteamVR_Input_Sources.Any))
            
        {
            buki.transform.localScale = new Vector3(1, 15, 1);
        }
    }


}
