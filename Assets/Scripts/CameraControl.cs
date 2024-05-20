using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ThirdCam, FirstCam;
    public bool CamMode = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            CamMode = !CamMode;
            StartCoroutine(CamChange());
        }
    }

    IEnumerator CamChange()
    {
        yield return new WaitForSeconds(0.5f);

        if (!CamMode)
        {
            ThirdCam.SetActive(true);
            FirstCam.SetActive(false);
        }
        else
        {
            ThirdCam.SetActive(false);
            FirstCam.SetActive(true);
        }
    }
}
