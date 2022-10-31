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
        Debug.Log(audioClp);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger(animtionParamater);
            playTumbleweed2();
        }
    }

    public void playTumbleweed2()
    {
        audioSrc.PlayOneShot(audioClp);
    }
}
