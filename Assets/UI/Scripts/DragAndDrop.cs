using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    public GameObject Generator;
    public GameObject position;
    private GameObject newGenerator;
    private Placement generatorPlacement;

    private float DragModifier = .6f;
    private float BuildYPos = -31;
   // public GameObject Background;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("Begin");
    }

    public void OnDrag(PointerEventData eventData)
    {
            Vector3 delta = new Vector3(eventData.delta.x * DragModifier, BuildYPos, eventData.delta.y * DragModifier);
            //Debug.Log("Dragging");
            BuildYPos = 0;
            newGenerator.transform.position += delta;
            
            

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("Stopped");

            generatorPlacement = newGenerator.GetComponent<Placement>();
            generatorPlacement.placed = true;
            BuildYPos = -31;
            Cursor.visible = true;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Click");
            newGenerator = Instantiate(Generator, eventData.delta , rectTransform.rotation);
            newGenerator.transform.rotation = Quaternion.identity;
            Cursor.visible = false;
    }
}
