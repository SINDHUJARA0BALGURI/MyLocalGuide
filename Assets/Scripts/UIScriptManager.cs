using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScriptManager : MonoBehaviour
{
    public Text lat, lon;



    

    // Update is called once per frame
    void Update()
    {
        lat.text = "LAT: "+GPSLocation.latitude.ToString();
        lon.text = "LONG: "+GPSLocation.longitude.ToString();
    }
}
