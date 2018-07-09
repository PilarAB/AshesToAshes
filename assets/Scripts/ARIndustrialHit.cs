using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;

public class ARIndustrialHit : MonoBehaviour {

    public Camera ARCamera; //the Virtual Camera used for AR


    // Array to add all prefabs
    public GameObject[] PrefabThings; 

    //List, array used to keep track of spawned objects
    private List<GameObject> spawnedObjects = new List<GameObject>(); 


    public void SpawnHitObject(int index)
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
            if (HitTestWithResultType(point, resultType, index))
            {
                return;
            }
        }
    }

    bool HitTestWithResultType(ARPoint point, ARHitTestResultType resultTypes, int index)
    {
        List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface().HitTest(point, resultTypes);
        if (hitResults.Count > 0)
        {
            foreach (var hitResult in hitResults)
            {
                //TODO: get the position and rotations to spawn the object. Done:
                Vector3 pos = UnityARMatrixOps.GetPosition(hitResult.worldTransform);
                Quaternion rotation = UnityARMatrixOps.GetRotation(hitResult.worldTransform);
                // int of the index of the array of prefab. Which object you will spawn
                spawnedObjects.Add(Instantiate(PrefabThings[index], pos, rotation)); 
                //Debug.Log("Spawned object number " + index.ToString());
                return true;
            }
        }
        //debug the object recived
        Debug.Log("Recived= " + index); 
        return false;
    }


    /// <summary>
    /// Function that is called on 
    /// NOTE: HIT TESTS DON'T WORK IN ARKIT REMOTE
    /// </summary>


    // Fixed Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        { //this works with touch as well as with a mouse
            RemoveObject(Input.mousePosition);
        }
    }

    public void RemoveObject(Vector2 point)
    {
        //TODO: Raycast from the screen point into the virtual world and see if we hit anything: Done
        //if we do, then check to see if it is part of the spawnedObjects array
        //if so, then delete the object we raycast 
        RaycastHit hit;
        if (Physics.Raycast(ARCamera.ScreenPointToRay(point), out hit))
        {
            GameObject item = hit.collider.transform.parent.gameObject; //parent is what is stored in our area;
                                                                        //ADD HERE WHAT IT WANT TO DO WITH OBJECT
            if (spawnedObjects.Remove(item))
            { //make sure to remove the hat from the array for consistancy
                Destroy(item);
            }
        }
    }

}
