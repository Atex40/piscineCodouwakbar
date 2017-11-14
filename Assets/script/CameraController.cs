using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject CameraFPS;
    public GameObject CameraTPS;
    public GameObject CameraTOP;

    public int ActualCamera = 0;

	
	// Update is called once per frame
	void Update () {
        CameraChanger();
	}

    void CameraChanger ()
    {
        if (Input.GetKeyDown("c"))
        {
            if(ActualCamera == 0)
            {
                CameraFPS.SetActive(false);
                CameraTPS.SetActive(true);
                ActualCamera += 1;
                return;
            }
            if (ActualCamera == 1)
            {
                CameraTPS.SetActive(false);
                CameraTOP.SetActive(true);
                ActualCamera += 1;
                return;
            }
            if (ActualCamera == 2)
            {
                CameraTOP.SetActive(false);
                CameraFPS.SetActive(true);
                ActualCamera = 0 ;
                return;
            }
        }
    }
        
}
