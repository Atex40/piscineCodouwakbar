using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject CameraFPS;
    public GameObject CameraTPS;
    public GameObject CameraTOP;
    public GameObject currentcamera;

    public static CameraController Instance { get; private set; }

    public int ActualCamera = 0;

    void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        if (ActualCamera== 0)
        {
            CameraFPS.SetActive(true);
            CameraTPS.SetActive(false);
            CameraTOP.SetActive(false);
            currentcamera = CameraFPS;

        }
        if (ActualCamera == 1)
        {
            CameraFPS.SetActive(false);
            CameraTPS.SetActive(true);
            CameraTOP.SetActive(false);
            currentcamera = CameraTPS;
        }
        if (ActualCamera == 2)
        {
            CameraFPS.SetActive(false);
            CameraTPS.SetActive(false);
            CameraTOP.SetActive(true);
            currentcamera = CameraTOP;
        }
    }
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
                currentcamera = CameraTPS;
                return;
            }
            if (ActualCamera == 1)
            {
                CameraTPS.SetActive(false);
                CameraTOP.SetActive(true);
                ActualCamera += 1;
                currentcamera = CameraTOP;
                return;
            }
            if (ActualCamera == 2)
            {
                CameraTOP.SetActive(false);
                CameraFPS.SetActive(true);
                ActualCamera = 0 ;
                currentcamera = CameraFPS;
                return;
            }
        }
    }
        
}
