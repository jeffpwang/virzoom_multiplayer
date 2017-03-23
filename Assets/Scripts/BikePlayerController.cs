using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BikePlayerController : MonoBehaviour {

    //public Text countText;
    //public AudioClip collectAudio;
    //public AudioClip flyingAudio;
    //public ParticleSystem pSystem;
    //private int count;
    public Rigidbody rb;

    // flying variables
    public float MaxHeight = 100f;
    public float Force = 30f;

    void Start ()
    {
        //count = 0;
        //SetScoreText();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        bool rightPressed = VZPlayer.Controller.RightButton.Pressed();
        bool rightHeld = VZPlayer.Controller.RightButton.Down;
        bool rightUp = VZPlayer.Controller.RightButton.Released();

        //if (rightPressed && rb.velocity.magnitude > 1)
        //{
        //    AudioSource.PlayClipAtPoint(flyingAudio, transform.position);
        //}

        if (rightHeld && rb.velocity.magnitude > 1)
        {
            LiftProcess();
            //pSystem.Play();
        }

        if (rightUp || transform.InverseTransformDirection(rb.velocity).y < 6)
        {

            //pSystem.Stop();
        }
    }

    private void LiftProcess()
    {
        Debug.Log("lifting...");
        var upForce = 1 - Mathf.Clamp(rb.transform.position.y / MaxHeight, 0, 1);
        upForce = Mathf.Lerp(0f, Force, upForce) * rb.mass;
        rb.AddRelativeForce(Vector3.up * upForce);
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Collectible"))
    //    {
    //        other.gameObject.SetActive(false);
    //        count = count + 1;
    //        SetScoreText();
    //        AudioSource.PlayClipAtPoint(collectAudio, transform.position);
    //    }
    //}

    //void SetScoreText()
    //{
    //    countText.text = "Score: " + count.ToString();
    //}
}
