using UnityEngine;

namespace Scripts.Logica.Spawn 
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private float _timeSpawn;
        [SerializeField] private float _maxTimeSpawns;
        [SerializeField] private float _minSpawnTime;

        [Space(5), Header("SettingSpawn")]
        [SerializeField] private GameObject _objectPrefab;

        [Space(5), Header("Subtraction")]
        [SerializeField] private float _timeSubtraction;

        public bool isSpawning { get; private set; }


        private void Update()
        {
            isSpawning = Spawning(_objectPrefab);
            Debug.Log(isSpawning);
        }

        private bool Spawning(GameObject Prefab)
        {
            if (_timeSpawn < 0)
            {
                var prefab = Instantiate(Prefab, transform.position, Quaternion.identity);

                _timeSpawn = _maxTimeSpawns;

                if (_maxTimeSpawns > _minSpawnTime)
                {
                    _maxTimeSpawns -= _timeSubtraction;
                }

                return true;
            }
            else
            {
                _timeSpawn -= Time.deltaTime;
            }


            return false;
        }
    }
}


