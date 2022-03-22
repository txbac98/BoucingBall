using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform tfTarget;

    private void Update()
    {
        this.transform.position = this.tfTarget.position - Vector3.forward * 10;
        //this.transform.position = Vector3.Lerp(this.transform.position, this.tfTarget.position - Vector3.forward*10, Time.deltaTime);
    }
}
