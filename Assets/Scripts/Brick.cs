using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hits = 2;
    public int points = 5;
    public Vector3 rotator;
    public Material hitMaterial;

    Material _orgMaterial;
    Renderer _renderer;

    void Start()
    {
        //transform.Rotate(rotator * (transform.position.x + transform.position.y)* 0.1f);
        _renderer = GetComponent<Renderer>();
        _orgMaterial = _renderer.sharedMaterial;
    }

    void Update()
    {
        //transform.Rotate(rotator * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        hits--;

        //score
        if (hits < -0)
        {
            // Destroy() is a predefined variable that you can access to this game object to destory the object
            Destroy(gameObject);
        }

        _renderer.sharedMaterial = hitMaterial;
        Invoke("RestoreMaterials", 0.05f);

    }

    void RestoreMaterials()
    {
        _renderer.sharedMaterial = _orgMaterial;
    }

}
