using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightBattleScript : MonoBehaviour {

    Animator anim;
    int attackHash = Animator.StringToHash("attackHash");
    int idleHash = Animator.StringToHash("idleHash");
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger(attackHash);
        }
        else
        {
            anim.SetTrigger(idleHash);
        }
      
	}
}
