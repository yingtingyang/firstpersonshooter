using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class identifier : MonoBehaviour {
    Image crosshair;
    public GUIText gameover;
    public GUIText win;
    
    public AudioSource gunfire;
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
            if(nfo.transform.CompareTag("people")== true)
            {
                crosshair.color = Color.yellow;
                if (Input.GetMouseButtonDown(0))
                {
                   GetComponent<AudioSource>().play();
                   GetComponent<gameover>();
                
                }
           }
            if (nfo.transform.CompareTag("spy")==true)
            {
                crosshair.color = Color.yellow;
                if (Input.GetMouseButtonDown(0)) {
                    GetComponent<AudioSource>().play();
                    Destroy(nfo.transform.gameObject);
                    GetComponent<win>();
                }     
            }
        }
	
	}
}
