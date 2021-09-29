using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)           //unity calls automatically 
    {                                                                 //collision has data of how 2 objects collided and angle
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)                                                    //check if valid ball object. if null then it wasn't ball that collided
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);                                //when ball collides with scoring zone, trigger event (score). set functions in unity
        }                                                               
    }
}
