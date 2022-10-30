using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchHatBlowing : MonoBehaviour
{

    public string animtionParamater;
    Animator anim;
    AudioSource audioSrc;
    AudioClip audioClp;

    private void Start()
    {
        anim = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
        audioClp = audioSrc.clip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger(animtionParamater);
        }
    }

    public void playTumbleweed()
    {
        audioSrc.PlayOneShot(audioClp);
    }
}
