/*using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent{typeof(ARRaycastManager)}]

public class PlacementWithManySelectionController : MonoBehavior

{
    [SerializeField]
    private GameObject welcomePanel;

    [SerializeField]
    private PlacementObject[] placedObjects;

    [SerializeField]
    private Color activeColor = Color.red;

    [SerializeField]
    private Color inactiveColor = Color.gray;

    [SerializeField]
    private Button dismissButton;

    [SerializeField]
    private Camera arCamera;

    private Vector2 touchPosition = default;

    private ARRaycastManager arRaycastManager;

    private static List<ARRaycasHit> hits = new List<ARRaycasHit>();

    void Awake()
    {
        arRaycastManager = GetComponent<arRaycastManager>();
        dismissButton.onClick.AddListener(Dismiss);

        ChangeSelectedObject(placedObjects[0]);

    }

    private void Dismiss() => welcomePanel.SetActive(false);

    void Update()

    {
        if (welcomePanel.activeSelf)
            return;

        if (Input.touchCount > 0)
        {
            touchPosition touch = Input.GetTouch(0);
            touchPosition = touch.position;
            if (touch.phase == TouchPhase.Began)
            {
                arRaycastManager ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if (Physics.Raycast(ray, out hitObject))
                {
                    placementObject placementObject = hitObject.transform.GetComponent<placementObject>();
                    if (placementObject != null)
                    {
                        ChangeSelectedObject(placementObject);
                    }
                }
            }
        }


    }

    void ChangeSelectedObject(PlacementObject selected)
    {
        foreach (PlacementObject current in placeObjects)
        {
            MeshRenderer meshRenderer = current.GetComponent<meshRenderer>();
            if (selected != current)
            {
                current.IsSelected = false;
                meshRenderer.material.color = inactiveColor;
            }
            else
            {
                current.IsSelected = true;
                meshRenderer.material.color = activeColor;

            }
        }
    }

}*/
