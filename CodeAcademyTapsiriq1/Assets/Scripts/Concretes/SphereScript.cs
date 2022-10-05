using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public string _playerName = "Sphere";
    public int _health = 100;
    public float _speed = 15000f;
    public Vector3 _location = new Vector3(0, 0, 0);

    [SerializeField] GameObject Cube;
    [SerializeField] CubeScript _cubeScript;
    void Start()
    {
        _cubeScript = Cube.GetComponent<CubeScript>();
        _cubeScript.gameObject.GetComponent<Renderer>().material.color = Color.green;
        ShowDataCube();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDataCube(){
        // _sphereScript = sphereScript;
         Debug.Log($"Cube Name: {_cubeScript._playerName}\n" + 
                  $"Cube Health: {_cubeScript._health}\n" + 
                  $"Cube Location: {_cubeScript._location}\n"+ 
                  $"Cube Speed: {_cubeScript._speed}\n");
    }

}
