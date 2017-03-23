using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveManager : MonoBehaviour {
    public GameObject head;
    public GameObject leftHand;
    public GameObject rightHand;

    public bool bikeMode;

    public static ViveManager Instance;

    void Awake()
    {
        if (bikeMode)
        {
            head.SetActive(false);
            leftHand.SetActive(false);
            rightHand.SetActive(false);
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
