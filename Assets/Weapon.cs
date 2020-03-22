using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject owner;
    public int damage;
    public int capacity;
    public float cooldown;
    public float reloadTime;

    private float shotCooldown;
    private float reloadCooldown;
    private int magazine;

    public Transform bullet;

    // Start is called before the first frame update
    void Start()
    {
        shotCooldown = cooldown;
        magazine = capacity;
    }

    // Update is called once per frame
    void Update()
    {
        shotCooldown -= Time.deltaTime;
        reloadCooldown -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse1) && shotCooldown <= 0.0 && magazine>0 && reloadCooldown <= 0.0)
        {
            shotCooldown = cooldown;
            magazine -= 1;
            Debug.Log("Shot!");
            Instantiate(bullet, owner.transform.position + new Vector3(2, 0, 2), Quaternion.identity);

        }
        if (Input.GetKey(KeyCode.R))
        {
            reloadCooldown = reloadTime;
            magazine = capacity;
        }
        
    }
}
