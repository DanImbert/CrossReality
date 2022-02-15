using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


public class RaycastExample : MonoBehaviour
{

    [SerializeField] private ARRaycastManager aRRaycastManager;

    [SerializeField] private Text uiText;
    [SerializeField] List<GameObject> spawnables;
    GameObject Spawnable;
    // Start is called before the first frame update  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CastRay();
    }

    public void CastRay()
    {
        Ray ray = new Ray(transform.localPosition, transform.forward);
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if (aRRaycastManager.Raycast(ray, hits, UnityEngine.XR.ARSubsystems.TrackableType.AllTypes))
        {

            uiText.text = hits[0].sessionRelativeDistance.ToString();
        }

        else
        {
            uiText.text = "Nothing hit";
        }
    }

    public void OnSpawnButtonPress()
    {

    }
}
