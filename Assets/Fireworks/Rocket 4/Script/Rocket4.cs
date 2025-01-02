using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket4 : MonoBehaviour
{

    public Rigidbody rig;
    public ConstantForce cf;
    public Transform IsKinematic;

    public AudioSource releaseAudioSource;

    IEnumerator Start()

    {
        releaseAudioSource.Play();

        yield return new WaitForSeconds(2);

        //Game object will turn off
        GameObject.Find("MeshRenderer4").SetActive(false);

        rig.isKinematic = true;
        cf.enabled = false;


    }
}