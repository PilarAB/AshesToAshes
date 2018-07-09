using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;

public class ARHitTest : MonoBehaviour {
	public Camera ARCamera; //the Virtual Camera used for AR

	public GameObject ArrowF; //prefab Forward
	public GameObject ArrowB; //prefab Back
	public GameObject ArrowL; //prefab Left
	public GameObject ArrowR; //prefab Right
	public GameObject Robot;
	public GameObject InfoPost;
	public GameObject Panera;
	public GameObject Discount;
	public GameObject Dont;
    public GameObject extra;


	private List<GameObject> spawnedObjects = new List<GameObject>(); //array used to keep track of spawned objects

	/// <summary>
	/// Function that is called on 
	/// NOTE: HIT TESTS DON'T WORK IN ARKIT REMOTE
	/// </summary>
	/// SPAWN 1-------------------------------------------------------------------------------------------
	public void SpawnHitObject1() {
		ARPoint point = new ARPoint { 
			x = 0.5f, //do a hit test at the center of the screen
			y = 0.5f
		};

		// prioritize result types
		ARHitTestResultType[] resultTypes = {
			//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
			//ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
		}; 

		foreach (ARHitTestResultType resultType in resultTypes) {
			if (HitTestWithResultType1 (point, resultType)) {
				return;
			}
		}
	}

	bool HitTestWithResultType1 (ARPoint point, ARHitTestResultType resultTypes) {
		List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultTypes);
		if (hitResults.Count > 0) {
			foreach (var hitResult in hitResults) {
				//TODO: get the position and rotations to spawn the hat. Done:
				Vector3 pos = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
				Quaternion rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
				spawnedObjects.Add( Instantiate (ArrowF, pos, rotation) ); // in order to use for shuffling
				return true;
			}
		}
		return false;
	}

	//_________________________________________________________________________________________________________________


	/// SPAWN 1-------------------------------------------------------------------------------------------
	public void SpawnHitObject2() {
		ARPoint point = new ARPoint { 
			x = 0.5f, //do a hit test at the center of the screen
			y = 0.5f
		};

		// prioritize result types
		ARHitTestResultType[] resultTypes = {
			//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
			//ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
		}; 

		foreach (ARHitTestResultType resultType in resultTypes) {
			if (HitTestWithResultType2 (point, resultType)) {
				return;
			}
		}
	}

	bool HitTestWithResultType2 (ARPoint point, ARHitTestResultType resultTypes) {
		List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultTypes);
		if (hitResults.Count > 0) {
			foreach (var hitResult in hitResults) {
				//TODO: get the position and rotations to spawn the hat. Done:
				Vector3 pos = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
				Quaternion rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
				spawnedObjects.Add( Instantiate (ArrowB, pos, rotation) ); // in order to use for shuffling
				return true;
			}
		}
		return false;
	}

	//_________________________________________________________________________________________________________________

	/// SPAWN 3-------------------------------------------------------------------------------------------
	public void SpawnHitObject3() {
		ARPoint point = new ARPoint { 
			x = 0.5f, //do a hit test at the center of the screen
			y = 0.5f
		};

		// prioritize result types
		ARHitTestResultType[] resultTypes = {
			//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
			//ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
		}; 

		foreach (ARHitTestResultType resultType in resultTypes) {
			if (HitTestWithResultType3 (point, resultType)) {
				return;
			}
		}
	}

	bool HitTestWithResultType3 (ARPoint point, ARHitTestResultType resultTypes) {
		List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultTypes);
		if (hitResults.Count > 0) {
			foreach (var hitResult in hitResults) {
				//TODO: get the position and rotations to spawn the hat. Done:
				Vector3 pos = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
				Quaternion rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
				spawnedObjects.Add( Instantiate (ArrowL, pos, rotation) ); // in order to use for shuffling
				return true;
			}
		}
		return false;
	}

	/// SPAWN FW-ARROW-------------------------------------------------------------------------------------------
	public void SpawnHitObject4() {
		ARPoint point = new ARPoint { 
			x = 0.5f, //do a hit test at the center of the screen
			y = 0.5f
		};

		// prioritize result types
		ARHitTestResultType[] resultTypes = {
			//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
			//ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
		}; 

		foreach (ARHitTestResultType resultType in resultTypes) {
			if (HitTestWithResultType4 (point, resultType)) {
				return;
			}
		}
	}

	bool HitTestWithResultType4 (ARPoint point, ARHitTestResultType resultTypes) {
		List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultTypes);
		if (hitResults.Count > 0) {
			foreach (var hitResult in hitResults) {
				//TODO: get the position and rotations to spawn the hat. Done:
				Vector3 pos = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
				Quaternion rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
				spawnedObjects.Add( Instantiate (ArrowR, pos, rotation) ); // in order to use for shuffling
				return true;
			}
		}
		return false;
	}
	/// SPAWN ROBOT-------------------------------------------------------------------------------------------
	public void SpawnHitObjectRobot() {
		ARPoint point = new ARPoint { 
			x = 0.5f, //do a hit test at the center of the screen
			y = 0.5f
		};

		// prioritize result types
		ARHitTestResultType[] resultTypes = {
			//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
			//ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
		}; 

		foreach (ARHitTestResultType resultType in resultTypes) {
			if (HitTestWithResultTypeRobot (point, resultType)) {
				return;
			}
		}
	}

	bool HitTestWithResultTypeRobot (ARPoint point, ARHitTestResultType resultTypes) {
		List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultTypes);
		if (hitResults.Count > 0) {
			foreach (var hitResult in hitResults) {
				//TODO: get the position and rotations to spawn the hat. Done:
				Vector3 pos = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
				Quaternion rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
				spawnedObjects.Add( Instantiate (Robot, pos, rotation) ); // in order to use for shuffling
				return true;
			}
		}
		return false;
	}
	/// SPAWN INFO Post-------------------------------------------------------------------------------------------
	public void SpawnHitObjectinfo() {
			ARPoint point = new ARPoint { 
				x = 0.5f, //do a hit test at the center of the screen
				y = 0.5f
			};

			// prioritize result types
			ARHitTestResultType[] resultTypes = {
				//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
				//ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
				ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
			}; 

			foreach (ARHitTestResultType resultType in resultTypes) {
				if (HitTestWithResultTypeinfo (point, resultType)) {
					return;
				}
			}
		}

		bool HitTestWithResultTypeinfo (ARPoint point, ARHitTestResultType resultTypes) {
			List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultTypes);
			if (hitResults.Count > 0) {
				foreach (var hitResult in hitResults) {
					//TODO: get the position and rotations to spawn the hat. Done:
					Vector3 pos = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
					Quaternion rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
				spawnedObjects.Add( Instantiate (InfoPost, pos, rotation) ); // in order to use for shuffling
					return true;
				}
			}
			return false;
		}

	/// SPAWN PANERA-------------------------------------------------------------------------------------------
	public void SpawnHitObjectPan() {
		ARPoint point = new ARPoint { 
			x = 0.5f, //do a hit test at the center of the screen
			y = 0.5f
		};

		// prioritize result types
		ARHitTestResultType[] resultTypes = {
			//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
			//ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
		}; 

		foreach (ARHitTestResultType resultType in resultTypes) {
			if (HitTestWithResultTypePan (point, resultType)) {
				return;
			}
		}
	}

	bool HitTestWithResultTypePan (ARPoint point, ARHitTestResultType resultTypes) {
		List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultTypes);
		if (hitResults.Count > 0) {
			foreach (var hitResult in hitResults) {
				//TODO: get the position and rotations to spawn the hat. Done:
				Vector3 pos = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
				Quaternion rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
				spawnedObjects.Add( Instantiate (Panera, pos, rotation) ); // in order to use for shuffling
				return true;
			}
		}
		return false;
	}
	/// SPAWN Warning-------------------------------------------------------------------------------------------
	public void SpawnHitObjectDont() {
		ARPoint point = new ARPoint { 
			x = 0.5f, //do a hit test at the center of the screen
			y = 0.5f
		};

		// prioritize result types
		ARHitTestResultType[] resultTypes = {
			//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
			//ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
		}; 

		foreach (ARHitTestResultType resultType in resultTypes) {
			if (HitTestWithResultTypeDont (point, resultType)) {
				return;
			}
		}
	}

	bool HitTestWithResultTypeDont (ARPoint point, ARHitTestResultType resultTypes) {
		List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultTypes);
		if (hitResults.Count > 0) {
			foreach (var hitResult in hitResults) {
				//TODO: get the position and rotations to spawn the hat. Done:
				Vector3 pos = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
				Quaternion rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
				spawnedObjects.Add( Instantiate (Dont, pos, rotation) ); // in order to use for shuffling
				return true;
			}
		}
		return false;
	}
	/// SPAWN 20OFF-------------------------------------------------------------------------------------------
	public void SpawnHitObject20() {
		ARPoint point = new ARPoint { 
			x = 0.5f, //do a hit test at the center of the screen
			y = 0.5f
		};

		// prioritize result types
		ARHitTestResultType[] resultTypes = {
			//ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
			//ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
			ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
		}; 

		foreach (ARHitTestResultType resultType in resultTypes) {
			if (HitTestWithResultType20 (point, resultType)) {
				return;
			}
		}
	}

	bool HitTestWithResultType20 (ARPoint point, ARHitTestResultType resultTypes) {
		List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, resultTypes);
		if (hitResults.Count > 0) {
			foreach (var hitResult in hitResults) {
				//TODO: get the position and rotations to spawn the hat. Done:
				Vector3 pos = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
				Quaternion rotation = UnityARMatrixOps.GetRotation (hitResult.worldTransform);
				spawnedObjects.Add( Instantiate (Discount, pos, rotation) ); // in order to use for shuffling
				return true;
			}
		}
		return false;
	}

    /// SPAWN Extra-------------------------------------------------------------------------------------------
    public void SpawnHitObjectextra()
    {
        ARPoint point = new ARPoint
        {
            x = 0.5f, //do a hit test at the center of the screen
            y = 0.5f
        };

        // prioritize result types
        ARHitTestResultType[] resultTypes = {
            //ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent, // if you want to use bounded planes
            //ARHitTestResultType.ARHitTestResultTypeExistingPlane, // if you want to use infinite planes 
            ARHitTestResultType.ARHitTestResultTypeFeaturePoint // if you want to hit test on feature points
        };

        foreach (ARHitTestResultType resultType in resultTypes)
        {
            if (HitTestWithResultTypeextra(point, resultType))
            {
                return;
            }
        }
    }

    bool HitTestWithResultTypeextra(ARPoint point, ARHitTestResultType resultTypes)
    {
        List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface().HitTest(point, resultTypes);
        if (hitResults.Count > 0)
        {
            foreach (var hitResult in hitResults)
            {
                //TODO: get the position and rotations to spawn the hat. Done:
                Vector3 pos = UnityARMatrixOps.GetPosition(hitResult.worldTransform);
                Quaternion rotation = UnityARMatrixOps.GetRotation(hitResult.worldTransform);
                spawnedObjects.Add(Instantiate(extra, pos, rotation)); // in order to use for shuffling
                return true;
            }
        }
        return false;
    }
	//_________________________________________________________________________________________________________________
	//_________________________________________________________________________________________________________________
	//_________________________________________________________________________________________________________________




	// Fixed Update is called once per frame
	void FixedUpdate () {
		if (Input.GetMouseButtonDown(0)) { //this works with touch as well as with a mouse
			RemoveObject (Input.mousePosition);
		}
	}

	public void RemoveObject(Vector2 point) {
		//TODO: Raycast from the screen point into the virtual world and see if we hit anything: Done
		//if we do, then check to see if it is part of the spawnedObjects array
		//if so, then delete the object we raycast 
		RaycastHit hit;
		if (Physics.Raycast (ARCamera.ScreenPointToRay (point), out hit)) {
			GameObject item = hit.collider.transform.parent.gameObject; //parent is what is stored in our area;
			//ADD HERE WHAT IT WANT TO DO WITH OBJECT
			if (spawnedObjects.Remove (item)) { //make sure to remove the hat from the array for consistancy
				Destroy (item); 
			}
		}
	}

}
			

			//float posY = item.transform.position.y; //get positon
			//posY += 0.1f; //lift it 0.1
			//add 0.1 to position of Y 
		//if (spawnedObjects.Remove (item) ) { //make sure to remove the hat from the array for consistancy
		//Destroy (item);

	

		
		
	/// <summary>
	/// NOTE: A Function To Be Called When the Shuffle Button is pressed
	/// </summary>



