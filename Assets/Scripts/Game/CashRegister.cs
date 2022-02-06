using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CashRegister : MonoBehaviour, IDropHandler
{
	public Canvas canvas;
	public GameObject cashBox;
	private Collider2D collider;
	// collider

	void Start()
    {
		collider = GetComponent<Collider2D>(); 
    }

	public void OnDrop(PointerEventData eventData)
	{
		if (eventData.pointerDrag != null && !eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot && collider.bounds.Contains(eventData.position))
		{
			//collider.OverlapPoint(eventData.pointerDrag.position
			// GiveAmount.givenNumber += DragDrop.moneyNumber;
			canvas.GetComponent<LevelManagement>().UpdateGiven(DragDrop.moneyNumber);
			eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
			eventData.pointerDrag.GetComponent<RectTransform>().gameObject.tag = "cashReg";
			eventData.pointerDrag.GetComponent<RectTransform>().gameObject.transform.SetParent(cashBox.gameObject.transform);
		}
	} 
}
