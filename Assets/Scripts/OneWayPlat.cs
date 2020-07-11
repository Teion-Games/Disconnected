using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*

	waitTime -> tempo que o player deve deixar downarrow segurado para cair da plataforma
	saveWT -> variável para não perder o waitTime na interação
 */
public class OneWayPlat : MonoBehaviour {

	private PlatformEffector2D effector;
	[Tooltip("Tempo que o player deve segurar downarrow para cair da plataforma")]
	[Range(0.1f, 0.8f)][SerializeField] private float waitTime;
	float saveWT;
	PlayerInput inputScript;
	[SerializeField] 
	private LayerMask others, othersWithPlayer;

	void Start(){
		inputScript = FindObjectOfType<PlayerInput>();
		effector = GetComponent<PlatformEffector2D>();
		saveWT = waitTime;
	}

	void Update(){
		if(!inputScript.fallTrig){
			waitTime = saveWT;
		}

		if(inputScript.fallTrig){
			if(waitTime<=0){
				effector.colliderMask = others;
				waitTime = saveWT;
			} else {
				waitTime -= Time.deltaTime;
			}
		}

		if(inputScript.jumpTrig){
			effector.colliderMask = othersWithPlayer;
		}
	}
}
