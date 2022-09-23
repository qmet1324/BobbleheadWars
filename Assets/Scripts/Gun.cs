using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform launchPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab) as GameObject;
        bullet.transform.position = launchPosition.position;
        bullet.GetComponent<Rigidbody>().velocity = transform.parent.forward * 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(!IsInvoking("FireBullet"))
            {
                InvokeRepeating("FireBullet", 0f, 0.1f);
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            CancelInvoke("FireBullet");
        }
    }
}
