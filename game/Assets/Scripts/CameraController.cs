using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    COMP397Sec001_Labs _inputs;
    // Start is called before the first frame update
    [SerializeField] private int _index = 0;
    [SerializeField] private CinemachineVirtualCamera _currentCamera;

    [SerializeField] private List<CinemachineVirtualCamera> _virtualCameras =
        new List<CinemachineVirtualCamera>();

    void Awake()
    {
        InitCameraPriorities();
        _inputs = new COMP397Sec001_Labs();
        _inputs.Player.Camera.performed += context => MoveCamera(context.ReadValue<float>());
    }
    void InitCameraPriorities()
    {
        foreach (var vCamera in _virtualCameras)
        {
            vCamera.Priority = 0;
        }
        _currentCamera = _virtualCameras[0];
        _currentCamera.Priority = 10;

    }
    void OnEnable() => _inputs.Enable();
    void OnDisable() => _inputs.Disable();

    void MoveCamera(float value)
    {
        Debug.Log($"Camera change value {value}");
        _index += (int)value;
        if (_index < 0) _index = _virtualCameras.Count - 1;
        if (_index > _virtualCameras.Count - 1) _index = 0;
        ChangeCamera();
    }
    void ChangeCamera()
    {
        _currentCamera.Priority = 0;
        _currentCamera = _virtualCameras[_index];
        _currentCamera.Priority = 10;
    }
}
    


