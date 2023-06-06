using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public Material highlightMaterial;
    public bool isHighlighted = false;
    private float movementIncrement = 1f;

    private void Update()
    {
        if (isHighlighted)
        {
            Handle_W_Key();
            Handle_A_Key();
            Handle_S_Key();
            Handle_D_Key();
        }
    }

    private void Handle_W_Key()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            Vector3 currentPosition = gameObject.transform.position;
            Vector3 newPosition;

            float currentZposition = currentPosition.z;
            float newZPosition = currentZposition += movementIncrement;

            newPosition.x = currentPosition.x;
            newPosition.y = currentPosition.y;
            newPosition.z = newZPosition;

            gameObject.transform.position = newPosition;
        }
    }

    private void Handle_A_Key()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Vector3 currentPosition = gameObject.transform.position;
            Vector3 newPosition;

            float currentXposition = currentPosition.x;
            float newXPosition = currentXposition -= movementIncrement;

            newPosition.x = newXPosition;
            newPosition.y = currentPosition.y;
            newPosition.z = currentPosition.z;

            gameObject.transform.position = newPosition;
        }
    }

    private void Handle_S_Key()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            Vector3 currentPosition = gameObject.transform.position;
            Vector3 newPosition;

            float currentZposition = currentPosition.z;
            float newZPosition = currentZposition -= movementIncrement;

            newPosition.x = currentPosition.x;
            newPosition.y = currentPosition.y;
            newPosition.z = newZPosition;

            gameObject.transform.position = newPosition;
        }
    }

    private void Handle_D_Key()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            Vector3 currentPosition = gameObject.transform.position;
            Vector3 newPosition;

            float currentXposition = currentPosition.x;
            float newXPosition = currentXposition += movementIncrement;

            newPosition.x = newXPosition;
            newPosition.y = currentPosition.y;
            newPosition.z = currentPosition.z;

            gameObject.transform.position = newPosition;
        }
    }
}
