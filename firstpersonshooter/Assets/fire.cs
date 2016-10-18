using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fire : MonoBehaviour
{


    public int theDamage;
    public ParticleSystem muzzle;
    public ParticleSystem trail;
    public AudioClip gunfire;
    public AudioSource src;
    public float waitTime;
    public Text txt;
    public bool canwin;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Win());
        canwin = true;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        if (Input.GetMouseButtonDown(0))
        {
            muzzle.Emit(Random.Range(0, 60));
            trail.Emit(1);
            src.PlayOneShot(gunfire);
            if (Physics.Raycast(ray, out hit, 100))
            {
                canwin = true;

            }
        }
    }
    IEnumerator Win()
    {

        yield return new WaitForSeconds(10);
        if (canwin)
            txt.gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        if (canwin)
            Application.LoadLevel(Application.loadedLevel);
    }
}