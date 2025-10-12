using UnityEngine;

public class SpawnerBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = transform.forward * bulletSpeed;
            }
        }
    }
}