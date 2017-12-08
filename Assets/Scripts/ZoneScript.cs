using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneScript : MonoBehaviour {
    public ManagerScript managerScript;
    public bool owner;
 	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnMouseDown() {
        if (managerScript.cardScript != null && (managerScript.cardScript.owner == this.owner))
        {
            managerScript.cardScript.gameObject.transform.position = this.transform.position;
        }
    }
}
