using UnityEngine;
using System.Collections;

public class Controler : MonoBehaviour {

    public GameObject Bar;
    public GameObject Dot;

    public float speed = 5;
    public int score = 1;


	// Use this for initialization
	void Start () {
        Bar.transform.rotation.Set(0,0,90,0);
	}
	
	// Update is called once per frame
	void Update () {
	    Bar.transform.Rotate(Vector3.forward, speed * Time.deltaTime);
	}
}
