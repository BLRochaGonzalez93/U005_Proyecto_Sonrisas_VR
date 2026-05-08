using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShootWeapon : MonoBehaviour
{
    [SerializeField] GameObject tomato;

    [SerializeField] GameObject weapon;
    public float fireSpeed = 20f;

    void Start()
    {
       
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabblable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grabblable.activated.AddListener(FireTomato);
    }

    void Update()
    {

    }

    public void FireTomato(ActivateEventArgs arg)
    {
        GameObject spawnTomato = Instantiate(tomato);
        spawnTomato.transform.position = weapon.transform.position;
        spawnTomato.GetComponent<Rigidbody>().linearVelocity = weapon.transform.forward * fireSpeed;
        Destroy(spawnTomato, 5f);
    }

}
