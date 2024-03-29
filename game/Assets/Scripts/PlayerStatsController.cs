using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatsController : MonoBehaviour, IObserver
{
    // Start is called before the first frame update

    [SerializeField] private Subject _playerSubject;

    [SerializeField] private int _playerHealth = 3;
    void Awake()
    {
        _playerSubject = GameObject.FindGameObjectWithTag("Player").
            GetComponent<Subject>();

    }

    void OnEnable()
    {
        _playerSubject.AddObserver(this);
    }
    void OnDisable()
    {
        _playerSubject.RemoveObserver(this);
    }
    public void OnNotify(PlayerEnums playerEnums)
    {
        
        switch (playerEnums)
        {
            case PlayerEnums.Died:
                PlayerDied();
                break;
            default:
                break;
        }
        
    }
    private void PlayerDied()
    {
        _playerHealth -= 1;
        if (_playerHealth <= 0)
        {
            Debug.Log("player truly died");
            SceneManager.LoadScene("GameOver");
        }
    }
}
