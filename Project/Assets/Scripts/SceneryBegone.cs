using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryBegone : MonoBehaviour
{
    [SerializeField] GameObject selectedScenery;
    [SerializeField] float scenerySpeed;
    [SerializeField] CameraControl CC;
    [SerializeField] float step;
    // Start is called before the first frame update
    private void Update()
    {
        step = scenerySpeed * Time.deltaTime;
        if (CC.camPos >= 3 || CC.camPos <= -3)
        {
            Debug.Log("rize");
            selectedScenery.SetActive(true);
        }
        else
        {
            Debug.Log("fall");
            selectedScenery.SetActive(false);
        }
    }
}
