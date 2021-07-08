using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPickup : MonoBehaviour
{
    GameObject goWeapon;
    GameObject goPlayerWeapon;
    public GameObject goWeaponForPickUp;
    public TutorialVar var;
    bool wasActivated;

    public AudioSource audioSource;
    public AudioClip swordClip;
    void Awake()
    {
        goWeapon = GameObject.FindGameObjectWithTag("WeaponUI");
        goPlayerWeapon = GameObject.FindGameObjectWithTag("PlayerWeapon");
        wasActivated = false;
    }
    private void Start()
    {
        goWeapon.SetActive(false);
        goPlayerWeapon.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerCollider"))
        {
            if (wasActivated == false)
            {
                goWeapon.SetActive(true);
                goPlayerWeapon.SetActive(true);
                goWeaponForPickUp.SetActive(false);
                var.Step(2);
                PlaySword();
                wasActivated = true;
            }
        }
    }
    public void PlaySword()
    {
        audioSource.PlayOneShot(swordClip, 0.35f);
    }
}