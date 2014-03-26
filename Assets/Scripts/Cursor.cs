using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	//référence vers l'objet pixel
	public InteractivePixel pixel;

	// Use this for initialization
	void Start ()
	{
		//stocker la position de départ du curseur
	}
	
	// Update is called once per frame
	void Update () {

		//position du pixel

		//si on appuie sur "E" le curseur va sur le pixel
		   // les modifications de couleur s'appliquent

		//si on réappuie sur "E" le curseur retourne à sa position de départ
		   // les modifications de couleur ne s'appliquent pas
	}
}
