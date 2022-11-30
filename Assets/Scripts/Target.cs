using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
    [SerializeField] private float LifeTime = 20f;

    private Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        rigidbody.velocity = this.transform.forward * Speed;
        StartCoroutine(DisableTarget());
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


    private IEnumerator DisableTarget()
    {
        yield return new WaitForSeconds(LifeTime);
        Destroy(this.gameObject);
    }


}
