using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGunInteractable : XRGrabInteractable
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _bulletSpawnPoint;
    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);
        SpawnBullet();
        Debug.Log("Feuer");
    }
    private void SpawnBullet()
    {
        Instantiate(_bulletPrefab, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);
    }
    
    #region Tips and Tricks zu OnSelectedEntered/Exited
    //protected override void OnSelectEntered(XRBaseInteractor interactor)
    //{
    //    base.OnSelectEntered(interactor);
    //    //Wenn gegriffen wird, passiert etwas, nicht bevor es gegriffen wird (das wäre OnSelectEntered)
    //}

    //protected override void OnSelectExited(SelectExitEventArgs args)
    //{
    //    base.OnSelectExited(args);
    //    //Wenn losgelassen wird, passiert etwas, nicht bevor es losgelassen wird (das wäre OnSelectExited)
    //}
    #endregion
}
