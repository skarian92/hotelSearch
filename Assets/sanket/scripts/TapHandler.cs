using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapHandler : MonoBehaviour {

    private PlacementHandler placementHandler;
    public GameObject hotelObject;
	// Use this for initialization
	void Start () {
        placementHandler = GetComponent<PlacementHandler>();
	}
	
	
    public void placeSelectedHotel(){
            Debug.Log("CLICKED");
            placementHandler.mode = PlacementHandler.Mode.NotPlaced;
            placementHandler.objectToPlace = hotelObject;
    }
    

}
