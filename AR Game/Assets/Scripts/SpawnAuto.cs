using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent (typeof(ARPlaneManager))]

public class SpawnAuto : MonoBehaviour
{
    [SerializeField]
    private GameObject placedPrefab;

    private GameObject placedObject;

    [SerializeField]
    private ARPlaneManager ARPlaneManager;

    void Awake () 
    {
        //dismissButton.onClick.AddListener(Dismiss);
        ARPlaneManager = GetComponent<ARPlaneManager>();
        ARPlaneManager.planesChanged += PlaneChanged;
    }

    private void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        if(args.added != null && placedObject == null) 
        {
            ARPlane ARPlane = args.added[0];
            placedObject = Instantiate(placedPrefab, ARPlane.transform.position, Quaternion.identity);
        }
    }
}
