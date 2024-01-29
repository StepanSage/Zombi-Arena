using UnityEngine;

namespace Scripts.Logica.Enemy 
{
    public class Move : MonoBehaviour
    {
        [SerializeField] private float speed = 5;

        private PlayerController _player;
        private Rigidbody2D _rb;
        private Vector2 _movement;

        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _player = FindObjectOfType<PlayerController>();

        }
        void Update()
        {
            MoveLogica();
        }

        protected  void MoveLogica()
        {
            Vector3 direction = _player.transform.position - transform.position;
            direction.Normalize();
            _movement = direction;
        }


        private void FixedUpdate() => MoveChar(_movement);         
        private void MoveChar(Vector2 direction) => _rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime)); 

    }
}

