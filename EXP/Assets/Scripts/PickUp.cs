using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    //[SerializeField] GameObject goItemButton;
    GameObject goEffectPickUp;
    public GameObject goEffectPickUp1;
    public GameObject goEffectPickUp2;
    public GameObject goEffectPickUp3;
    public GameObject goEffectPickUp4;
    int matIndex;
    Renderer rend;
    Material matCurrent;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;

    public AudioSource audioSource;
    public AudioClip pickUpClip;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("PlayerCollider").GetComponent<Inventory>();
        rend = GetComponent<MeshRenderer>();
        ChooseMat();
    }
    void ChooseMat()
    {
        matIndex = Random.Range(1, 5);
        switch (matIndex)
        {
            case 1:
                matCurrent = mat1;
                goEffectPickUp = goEffectPickUp1;
                break;
            case 2:
                matCurrent = mat2;
                goEffectPickUp = goEffectPickUp2;
                break;
            case 3:
                matCurrent = mat3;
                goEffectPickUp = goEffectPickUp3;
                break;
            case 4:
                matCurrent = mat4;
                goEffectPickUp = goEffectPickUp4;
                break;
        }
        rend.material = matCurrent;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerCollider"))
        {
            inventory.num += 1;
            inventory.UpdateNum();
            Instantiate(goEffectPickUp, transform.position, Quaternion.identity);
            PlayPickUp();
            Destroy(gameObject);
            
        }
    }
    public void PlayPickUp()
    {
        audioSource.PlayOneShot(pickUpClip, Random.Range(0.1f, 0.5f));
    }
}
