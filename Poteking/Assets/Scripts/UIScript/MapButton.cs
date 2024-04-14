using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButton : MonoBehaviour
{
    public GameObject mapUI;
    private bool isOnMap = false; 
    // Start is called before the first frame update
    void Start()
    {
        mapUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) //V누르면 맵 종료
        {
            mapUI.SetActive(false);
        }
    }
    public void OnMapActiveClick()
    {
        isOnMap = !isOnMap;
        mapUI.SetActive(isOnMap);
    }
}
