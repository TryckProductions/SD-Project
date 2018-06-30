using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IBscr : MonoBehaviour {

    public string OneLiner;
    public List<string> MultiLiner;

    public bool isOneLiner;
    public bool isDia;

    Text diaText;
    // Use this for initialization
	void Start () {
        diaText = GameObject.Find("DiaText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if(isDia == true)
        {
            DialogueInteraction();
        }

    }

    public void DialogueInteraction()
    {
        if(isOneLiner == true)
        {
            diaText.text = OneLiner;
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                diaText.text = "";
                isDia = false;
            }
            else if(isOneLiner == false)
            {
                
            }
        }
    }
}
