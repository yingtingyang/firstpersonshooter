using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class identifier : MonoBehaviour {
    Image crosshair;

	// Use this for initialization
	void Start () {
        crosshair = GameObject.Find("crosshair").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        crosshair.color = Color.red;
        RaycastHit nfo;
        if (Physics.Raycast(transform.position,transform.forward,out nfo) == true)
        {
            if(nfo.tranform.CompareTag("Enemy")== true)
            {
                crosshair.color = Color.yellow;
                if (Input.GetMouseButtonDown(0))
                {
                    nfo.transform.GetComponent<addparticle>().countscore();
                }
            }
        }
	
	}
}
