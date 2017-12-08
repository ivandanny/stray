using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public ManagerScript managerScript;
    public int attack;
    public int hp;
    public bool owner;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        managerScript.cardScript = this;
    }
}
