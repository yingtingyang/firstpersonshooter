using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class identifier : MonoBehaviour {
    Image crosshair;
    public Text gameover;
    public Text win;
    public AudioSource gunfire;
	
    // Use this for initialization
	void Start () {
        crosshair = GameObject.Find("crosshair").GetComponent<Image>();
        gunfire = GetComponent<AudioSource>();
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
                   gunfire.Play();
                    gameover.enabled = true;
                    Debug.Log("work");
                
                }
           }
            if (nfo.transform.CompareTag("spy")==true)
            {
                crosshair.color = Color.yellow;
                if (Input.GetMouseButtonDown(0)) {
                    gunfire.Play();
                    Destroy(nfo.transform.gameObject);
                    win.enabled = true;
                    Debug.Log("work");
                }     
            }
        }
	
	}
}
