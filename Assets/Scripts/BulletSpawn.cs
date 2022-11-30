using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletSpawn : MonoBehaviour
{
    
    [SerializeField]private float _bulletSpeed = 5f;
    [SerializeField] private float _bulletLifeTime = 30f;
    private Rigidbody _rigidbody;
    private void Awake()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
        _rigidbody.velocity = this.transform.forward * _bulletSpeed;
        StartCoroutine(DisableBullet());
    }
    private void OnTriggerEnter(Collider other)
    {
        HitTarget(other);
    }
    private void HitTarget(Collider other)
    {
        Destroy(other.gameObject);
        Debug.Log("HIT!");
        Destroy(this.gameObject);
    }
    

    private IEnumerator DisableBullet()
    {
        yield return new WaitForSeconds(_bulletLifeTime);
        Destroy(this.gameObject);
    }

  
    
}
