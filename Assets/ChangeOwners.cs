using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOwners : Photon.MonoBehaviour {
    public VRTK.VRTK_InteractableObject toss;

	// Use this for initialization
	void Start () {
        toss.InteractableObjectGrabbed += Toss_InteractableObjectGrabbed;
	}
	
	private void Toss_InteractableObjectGrabbed(object sender, VRTK.InteractableObjectEventArgs e)
    {
        toss.GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.player.ID);
    }

}
