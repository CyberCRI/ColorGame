using UnityEngine;
using System.Collections;

public class InteractivePixel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		renderer.material.color = Color.green;
	}

	private void addBlue(float delta) {
		Color ancienneCouleur = renderer.material.color;
		
		//couleur avant
		Debug.Log("avant "+ancienneCouleur);
		
		float nouveauBleu = ancienneCouleur.b + delta;
		
		if(nouveauBleu > 1f){
			nouveauBleu = 1f;
		}
		
		if(nouveauBleu < 0f){
			nouveauBleu = 0f;
		}
		
		renderer.material.color = new Color(ancienneCouleur.r,
		                                    ancienneCouleur.g,
		                                    nouveauBleu);
		//couleur après
		Debug.Log("après "+renderer.material.color);
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyUp("b"))
		{
			addBlue(0.1f);
		}
		
		if(Input.GetKeyUp("n"))
		{
			addBlue (-0.1f);
		}

	}
}
