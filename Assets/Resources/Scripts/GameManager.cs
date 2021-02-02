using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class GameManager : MonoBehaviour
{
    public void OnTrackingFound()
    {
        if (transform.childCount > 0)
        {
            SetChildrenActive(true);
        }
    }
    
    public void OnTrackingLost()
    {
        if (transform.childCount > 0)
        {
            SetChildrenActive(false);
        }
    }

    private void SetChildrenActive(bool activeState)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i++).gameObject.SetActive(activeState);
        }
    }
}
