using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    static private CameraManager _inst;
    static public CameraManager Instance { get { return _inst; } }
    [SerializeField] private GameObject ObjectToFollow;
    [SerializeField] private GameObject _camera;
    public float Offset = -10;
    private Vector3 _position = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        _position = ObjectToFollow.transform.position;
        _position.z = Offset; 
        _camera.transform.position = Vector3.Lerp(_camera.transform.position, _position, 0.4f);
    }

    public void SetFollowObj(GameObject obj)
    {
        ObjectToFollow = obj;
    }
}
