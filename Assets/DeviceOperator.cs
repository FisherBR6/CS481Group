using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeviceOperator : MonoBehaviour
{
    public Camera playerCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                hit.collider.GetComponent<Renderer>().material.color = Random.ColorHSV();
            }
        }
    }
}
