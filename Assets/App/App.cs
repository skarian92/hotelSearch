using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour {
	//private Recognizer recognizer;
	private PlacementHandler placementHandler;
	//private EntityMap entityMap;
	//private UIElements uiElements;
	public GameObject testMesh;
	public bool mock = false;

	private string recognizedId;
	private GameObject currentMesh;
	// Use this for initialization
	void Start () {
		//recognizer = GetComponent<Recognizer> ();
		placementHandler = GetComponent<PlacementHandler> ();
		//entityMap = GetComponent<EntityMap> ();
		//recognizer.TextRecognized += new Recognizer.TextRecognizedHandler(handleRecognized);
		//uiElements = GetComponent<UIElements> ();
		placementHandler.Placed += new PlacementHandler.PlacedHandler(handlePlaced);
		if (mock) {
			testMesh = loadMesh("AB/1234");
			testMesh.transform.position = new Vector3 (0.0f, 0.0f, 3.0f);
			handlePlaced (testMesh);
			//placementHandler.ObjectToPlace = testMesh;
		}
	}

	private void handleRecognized(string id) {
		Debug.Log ("recognized: " + id);
		recognizedId = id;
		currentMesh = loadMesh (recognizedId);
		//if (placementHandler.ObjectToPlace != null) {
			// there is already an object placed
		//	currentMesh.SetActive (true);
		//	if (oldMesh != null) {
				//currentMesh.transform.position = oldMesh.transform.position;
		//	}
		//}
		//placementHandler.ObjectToPlace = currentMesh;
	}

	private  void handlePlaced(GameObject go) {
		go.SetActive (true);
		//uiElements.showOverview ();
		Debug.Log ("placed");
	}

	private GameObject loadMesh(string id) {
        //if (entityMap.currentId != null) {
        //	entityMap.getCurrentEntity().mesh.SetActive (false);
        //}
        //entityMap.currentId = id;
        //return entityMap.getCurrentEntity().mesh;
        return null;
	}

    // Update is called once per frame
	void Update () {
		
	}
}
