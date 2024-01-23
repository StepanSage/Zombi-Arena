using UnityEngine;

namespace Scripts.Logica.Spawn 
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private bool _isSoloEnemySpawner = false;
        [SerializeField] private GameObject _prefabEnemySolo = null;

        [Header("Timers")]
        [SerializeField] private float _timeSpawn;
        [SerializeField] private float _maxTimeSpawns;
        [SerializeField] private float _minSpawnTime;

        [Space(5), Header("SettingSpawn")]
        [SerializeField] private GameObject[] _objectPrefab;

        [Space(5), Header("Subtraction")]
        [SerializeField] private float _timeSubtraction;

        private Score _score;

        public bool isSpawning { get; private set; }

        private void Start()
        {
            _score = FindObjectOfType<Score>();
            
        }

        private void Update()
        {
            if(_isSoloEnemySpawner == false)
            {
                VariantSpawn();
            }
            else
            {
                SoloSpawn();
            }
           
        }

        private void SoloSpawn()
        {
            if (_score._currentScore > 50)
            {
                isSpawning = Spawning(_prefabEnemySolo);

            }
        }

        private void VariantSpawn()
        {
            if (_score._currentScore <= 10)
            {
                isSpawning = Spawning(_objectPrefab[0]);

            }
            else if (_score._currentScore > 10 && _score._currentScore <= 30)
            {
                int number = RandomProsent();

                if (number <= 4)
                {
                    isSpawning = Spawning(_objectPrefab[1]);
                }
                else
                {
                    isSpawning = Spawning(_objectPrefab[0]);
                }
            }
            else if (_score._currentScore > 30 )
            {
                int number = RandomProsent();

                if (number <= 3)
                {
                    isSpawning = Spawning(_objectPrefab[1]);
                }
                else if (number > 3 && number <= 6)
                {
                    isSpawning = Spawning(_objectPrefab[0]);
                }
                else if (number > 6)
                {
                    isSpawning = Spawning(_objectPrefab[2]);
                }
            }

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

        private int RandomProsent()
        {
            return Random.Range(1, 10);
        }
    }
}


