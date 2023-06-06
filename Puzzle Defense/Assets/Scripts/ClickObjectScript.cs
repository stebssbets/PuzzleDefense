using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickObjectScript : MonoBehaviour
{
    [SerializeField] GameObject Wall;

    private void Update()
    {
        HandleMouseUp();
    }

    private void HandleMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Wall == CheckIfClickableObjectHasBeenClicked(out RaycastHit raycastHit))
            {
                Wall.transform.GetComponent<MeshRenderer>().material = Wall.GetComponent<WallScript>().highlightMaterial;
                Wall.GetComponent<WallScript>().isHighlighted = true;
            }
            
        }
    }

    GameObject CheckIfClickableObjectHasBeenClicked(out RaycastHit raycastHit)
    {
        GameObject nonClickableTarget = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out raycastHit))
        {
            if (raycastHit.transform.gameObject.name == "Wall")
            {
                return raycastHit.transform.gameObject;
            }
            else return nonClickableTarget;
        }
        else return nonClickableTarget;
    }

}
