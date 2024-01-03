using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class InputSystem : MonoBehaviour
{
    private Vector3 _mousePos;
    private Vector3 _mousePosOld;
    private Vector2 _movment;
    private Vector2 _movmentOld;

    void Awake()
    {
        
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        _mousePos.Normalize();

        _movment.x = Input.GetAxisRaw("Horizontal");
        _movment.y = Input.GetAxisRaw("Vertical");

        if(_mousePos != _mousePosOld)
        {
            _mousePosOld = _mousePos;
            float rot_z = Mathf.Atan2(_mousePos.y, _mousePos.x) * Mathf.Rad2Deg;
            PlayerSystem.Instance.mov.RotationHandler.Invoke(Quaternion.Euler(0f, 0f, rot_z - 90));
        }
        if(_movment != _movmentOld)
        {
            _movmentOld = _movment;
            
            PlayerSystem.Instance.mov.MovHandler.Invoke(_movment);
        }
        

    }
}
