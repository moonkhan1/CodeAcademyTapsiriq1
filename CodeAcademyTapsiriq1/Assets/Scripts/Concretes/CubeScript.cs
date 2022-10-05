using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public string _playerName = "Cube";
    public int _health = 54;
    public float _speed = 5000f;
    public Vector3 _location = new Vector3(5, 3, 5);

    [SerializeField] GameObject Sphere;
    [SerializeField] SphereScript _sphereScript;
    void Start()
    {
        // Sphere = GameObject.FindObjectOfType<SphereScript1>().gameObject;

        _sphereScript = Sphere.GetComponent<SphereScript>();
        _sphereScript.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        ShowDataSphere();

    }

    public void ShowDataSphere(){
        // _sphereScript = sphereScript;
        Debug.Log($"Sphere Name: {_sphereScript._playerName}\n" + 
                  $"Sphere Health: {_sphereScript._health}\n"+ 
                  $"Sphere Location: {_sphereScript._location}\n"+ 
                  $"Sphere Location: {_sphereScript._speed}\n");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
