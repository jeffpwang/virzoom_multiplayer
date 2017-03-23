using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusManager : MonoBehaviour {
    public GameObject bike;
    public bool bikeMode;
    public static OculusManager Instance;

    void Awake()
    {
        if (!bikeMode)
        {
            bike.SetActive(false);
        }
        if (Instance == null)
            Instance = this;
    }

    void OnDestroy()
    {
        if (Instance == this)
            Instance = null;
    }
}
