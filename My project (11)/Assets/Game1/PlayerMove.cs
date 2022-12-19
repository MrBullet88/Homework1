using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _playerSpeed;
   

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_playerSpeed * Time.deltaTime * -1, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_playerSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, _playerSpeed * Time.deltaTime * -1, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, _playerSpeed * Time.deltaTime, 0);
        }
    }
}
