using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardScript : MonoBehaviour {
    public ManagerScript managerscript;
    public int attack;
    public int hp;
	// Use this for initialization
	void Start () {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void TaskOnClick()
    {
        Debug.Log("You Have Clicked Me!");
    }
}
