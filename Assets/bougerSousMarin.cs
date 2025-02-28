using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bougerSousMarin : MonoBehaviour
{
    
    private Rigidbody _rb;
    Vector2 directionMouvement;
    [SerializeField] private float vitesseDeplacement;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnMonterDescendre(InputValue directionBase)
    {
        directionMouvement = directionBase.Get<Vector2>() * vitesseDeplacement;
        directionInput = new Vector3(directionAvecVitesse.x, 0f, directionAvecVitesse.y);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 directionSurPlane = new Vector3(directionMouvement.x, 0, directionMouvement.y);
        _rb.AddForce(directionSurPlane, ForceMode.VelocityChange);
    }
}
