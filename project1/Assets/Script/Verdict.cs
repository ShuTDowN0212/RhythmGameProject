using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Verdict : MonoBehaviour { //노트에 붙이는거

    public GameObject Note;

    public AudioSource Perfect;
    public AudioSource Great;
    public AudioSource Miss;

    public static bool EndVerdict=false;


    private void Awake()
    {
        
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "PerfectCollider") {
            Singletons.perfect++;
            Combo.comboperfect();
            VerdictEffect.VerdictNum = 3;
            Destroy(Note);
        }

        if (other.gameObject.tag == "GreatCollider" && other.gameObject.tag == "PerfectCollider")
        {
            Singletons.great++;
            Combo.combogreat();
            VerdictEffect.VerdictNum = 2;
            Destroy(Note);
        }
        
        if (other.gameObject.tag == "MissLine")
        {
            Singletons.miss++;
            Combo.combomiss();
            VerdictEffect.VerdictNum = 1;
            Destroy(Note);
        }
        EndVerdict = true;
    }
}
