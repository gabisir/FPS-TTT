using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int bullet_speed;
    public GameObject bulletPrefab; // Prefab for the bullet object
    public Transform gunBarrel; // The position where the bullet will be instantiated from
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Create a bullet instance at the gun barrel position
            GameObject bullet = Instantiate(bulletPrefab, gunBarrel.position, gunBarrel.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bullet_speed);
            Destroy(bullet, 1);
            // Add any additional logic for the bullet behavior or shooting effects here
        }
    }
}