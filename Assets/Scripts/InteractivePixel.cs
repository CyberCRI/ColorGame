using UnityEngine;
using System.Collections;

public class InteractivePixel : MonoBehaviour {

	float _mDelta = 0.1f;

	public InteractivePixel top;
	public InteractivePixel bottom;
	public InteractivePixel left;
	public InteractivePixel right;

	// Use this for initialization
	void Start () {
		renderer.material.color = Color.black;
	}

	private float computeAddColor(float ancienneCouleur, float delta)
	{
		float nouvelleCouleur = ancienneCouleur + delta;
		
		if(nouvelleCouleur > 1f){
			nouvelleCouleur = 1f;
		}
		
		if(nouvelleCouleur < 0f){
			nouvelleCouleur = 0f;
		}

		return nouvelleCouleur;
	}
	
	private void addRed(float delta) {
		Color ancienneCouleur = renderer.material.color;		
		renderer.material.color = new Color(computeAddColor(ancienneCouleur.r, delta),
		                                    ancienneCouleur.g,
		                                    ancienneCouleur.b);
	}
	private void addGreen(float delta) {
		Color ancienneCouleur = renderer.material.color;		
		renderer.material.color = new Color(ancienneCouleur.r,
		                                    computeAddColor(ancienneCouleur.g, delta),
		                                    ancienneCouleur.b);
	}
	private void addBlue(float delta) {
		Color ancienneCouleur = renderer.material.color;		
		renderer.material.color = new Color(ancienneCouleur.r,
		                                    ancienneCouleur.g,
		                                    computeAddColor(ancienneCouleur.b, delta));
	}
	
	public void increaseRed()
	{
		addRed(_mDelta);
	}
	
	public void decreaseRed()
	{
		addRed(-_mDelta);
	}
	
	public void increaseGreen()
	{
		addGreen(_mDelta);
	}
	
	public void decreaseGreen()
	{
		addGreen(-_mDelta);
	}
	
	public void increaseBlue()
	{
		addBlue(_mDelta);
	}
	
	public void decreaseBlue()
	{
		addBlue(-_mDelta);
	}

	/*
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("t"))
		{
			increaseRed();
		}
		
		if(Input.GetKeyUp("y"))
		{
			decreaseRed();
		}
		
		if(Input.GetKeyUp("g"))
		{
			increaseGreen();
		}
		
		if(Input.GetKeyUp("h"))
		{
			decreaseGreen();
		}
		
	    if(Input.GetKeyUp("b"))
		{
			increaseBlue();
		}
		
		if(Input.GetKeyUp("n"))
		{
			decreaseBlue();
		}
	}
	*/
}
