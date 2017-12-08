using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneScript : MonoBehaviour {
    public ManagerScript managerScript;
    public bool owner;
    public int xPos, yPos;
    public Light lit;
 	// Use this for initialization

	void Start () {
        lit = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (managerScript.cardScript != null && (managerScript.cardScript.owner == this.owner)) {
            int cardX = managerScript.cardScript.xPos;
            int cardY = managerScript.cardScript.yPos;
            if (Mathf.Abs(xPos + yPos - cardX - cardY) == 1)
            {
                lit.intensity = 1.29f;
            }
            else lit.intensity = 0.0f;
        }

    }


    private void OnMouseDown() {
        if (managerScript.cardScript != null && (managerScript.cardScript.owner == this.owner) && (lit.intensity > 0.0f)) {
            managerScript.cardScript.gameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -0.05f);
            managerScript.cardScript.xPos = xPos;
            managerScript.cardScript.yPos = yPos;
        }
    }
}
