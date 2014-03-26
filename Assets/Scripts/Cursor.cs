using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	//référence vers l'objet pixel
	public InteractivePixel interactivePixel;
	private InteractivePixel currentPixel;
	public Vector3 initialPosition;

	// Use this for initialization
	void Start ()
	{
		//stocker la position de départ du curseur
		initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		//si on appuie sur "E" le curseur va sur le pixel
		// les modifications de couleur s'appliquent
		//si on réappuie sur "E" le curseur retourne à sa position de départ
		// les modifications de couleur ne s'appliquent pas
		if (Input.GetKeyUp("e"))
		{
			if(currentPixel != null)
			{
				currentPixel = null;
				transform.position = initialPosition;
			}
			else
			{
				currentPixel = interactivePixel;
				transform.position = currentPixel.gameObject.transform.position;
			}
		}
		
		if(currentPixel != null)
		{
			if (Input.GetKeyUp("t"))
			{
				currentPixel.increaseRed();
			}
			if (Input.GetKeyUp("y"))
			{
				currentPixel.increaseGreen();
			}
			if (Input.GetKeyUp("g"))
			{
				currentPixel.increaseBlue();
			}
			if (Input.GetKeyUp("h"))
			{
				currentPixel.decreaseRed();
			}
			if (Input.GetKeyUp("b"))
			{
				currentPixel.decreaseGreen();
			}
			if (Input.GetKeyUp("n"))
			{
				currentPixel.decreaseBlue();
			}
		}
	}
}
