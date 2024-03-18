//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class PlayerShooter : MonoBehaviour
//{
//    [SerializeField] private GameObject _projectilePrefab;
//    [SerializeField] private List<Transform> _projectileSpawns;
//    [SerializeField] private float _projectileForce = 0f;
//    [SerializeField] private COMP397Sec001_Labs _inputs;
//    [SerializeField] private _currentProjectileSpawn;
//    [SerializeField] private _shootProjectilebtn;
//    [SerializeField] private _turnProjectileSpawnLeft;
//    [SerializeField] private _turnProjectileSpawnRight;

//        private int _index = 0;


//    private void Awake()
//    {
//        _currentProjectileSpawn = _projectileSpawns[_index];
//        _inputs = new COMP397Sec001_Labs();
//        _inputs.Player.Fire.performed += _ => ShootProjectile;
//        _inputs.Player.Fire.performed += context => ChangeProjectileSpawn(context.ReadValue<float>());
//        _shootProjectilebtn.onClick.AddListener(ShootProjectile);
//        _turnProjectileSpawnLeft.onClick.AddListener(() => ChangeProjectileSpawn(-1));
//        _turnProjectileSpawnRight.onClick.AddListener(() => ChangeProjectileSpawn(1));

//    }

//    private void OnEnable()
//    {
//        _inputs.Enable();
//    }
//    private void OnDisable()
//    {
//        _inputs.Disable();
//    }
//    private void ShootProjectile()
//    {
//        GameObject projectile = Instantiate(_projectilePrefab, _currentProjectileSpawn.transform.position, _currentProjectileSpawn.transform.rotation);
//        projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * _projectileForce);
//    }
//    private void ChangeProjectileSpawn(float direction)
//    {
//        _index = (_index + (int)direction) % _projectileSpawns.Count;
//        _currentProjectileSpawn* _projectileSpawns[_index];
//    }
//}
