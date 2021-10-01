using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private Arrow arrow2;

    public UnityEvent arrowCoincidedEvent;
    public UnityEvent arrowNotCoincidedEvent;


    public void checkMatch()
    {
        if (arrow1.collidedObject.GetComponent<Cell>().ID == arrow2.collidedObject.GetComponent<Cell>().ID)
            arrowCoincidedEvent?.Invoke();
        else arrowNotCoincidedEvent?.Invoke();
    }
}
