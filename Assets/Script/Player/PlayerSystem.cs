using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement mov;
    
    private Rigidbody2D _rb;
    static private PlayerSystem _inst;
    static public PlayerSystem Instance { get { return _inst; } }
    void Start()
    {
        _rb.GetComponent<Rigidbody2D>();
        mov.MovHandler += NewPos;
        mov.RotationHandler += NewAngle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NewPos(Vector2 posToMov)
    {
        _rb.MovePosition(_rb.position + posToMov * 5 * Time.deltaTime);
    }

    private void NewAngle(Quaternion rotation)
    {
        transform.rotation = rotation;
    }
}
