using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _pausePanel;
    private CharacterController _playerController;
    private COMP397Sec001_Labs _inputs;
    void awake()
    {
        _playerController = _player.GetComponent<CharacterController>();
        _inputs = new COMP397Sec001_Labs();
        _inputs.Player.Pause.performed += context =>
        PauseGame();
        _inputs.Enable();

    }
    public void PauseGame()
    {
        _playerController.enabled = false;
        _pausePanel.SetActive(true);

    }
    public void UnPauseGame()
    {
        _playerController.enabled = true;
        _pausePanel.SetActive(false);
    }
}
