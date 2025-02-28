using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bougerSousMarin : MonoBehaviour
{
[SerializeField] private float _vitesse = 5f;



    
    private Rigidbody _rb;
    private Vector3 directionInput;
    private Vector2 directionMouvement;
    [SerializeField] private float vitesseDeplacement;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnHautBas(InputValue directionBase)
    {
        directionMouvement = directionBase.Get<Vector2>() * vitesseDeplacement;
        directionMouvement = new Vector3(directionMouvement.x, 0f, directionMouvement.y);
    }

    void OnAvance(InputValue directionBase)
    {
        Vector2 input = directionBase.Get<Vector2>();
        directionInput.z = input.y * _vitesse;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 directionSurPlane = new Vector3(directionMouvement.x, 0, directionMouvement.y);
        _rb.AddForce(directionMouvement, ForceMode.VelocityChange);
    }
}
