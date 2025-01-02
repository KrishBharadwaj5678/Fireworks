using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FireworkPlacer : MonoBehaviour
{
    [SerializeField] private List<GameObject> fireworkModels; // Assign firework prefabs in the Inspector
    [SerializeField] private ARPlaneManager planeManager; // Attach the ARPlaneManager component
    [SerializeField] private ARRaycastManager raycastManager; // Attach the ARRaycastManager component

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            if (raycastManager.Raycast(touch.position, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes))
            {
                Pose hitPose = hits[0].pose;
                PlaceFirework(hitPose.position);
            }
        }
    }

    private void PlaceFirework(Vector3 position)
    {
        if (fireworkModels.Count == 0)
        {
            Debug.LogWarning("No firework models assigned in the Inspector.");
            return;
        }

        int randomIndex = Random.Range(0, fireworkModels.Count);
        GameObject selectedFirework = fireworkModels[randomIndex];
        Instantiate(selectedFirework, position, Quaternion.identity);
    }
}
