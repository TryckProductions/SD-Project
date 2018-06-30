using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "IB")
        {
            if(Input.GetKeyDown(KeyCode.F))  //"IB" Means Interactable
            {
                other.GetComponent<IBscr>().isDia = true;
            }
        }
    }
}
