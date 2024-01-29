using Scripts.Logica.Enemy;
using UnityEngine;

public class MoveSlime : Move
{
    [SerializeField] private Transform[] _pointMove;
    [SerializeField] private string _nameTagNavigation;

    private GameObject[] TransformObject;
    [SerializeField] private bool _isEndPoinMove = false;
    [SerializeField] private int _index = 0;
    

    private void Start()
    {
        Init();
    }

    public void Init() 
    {
         TransformObject = GameObject.FindGameObjectsWithTag(_nameTagNavigation);
        _pointMove = new Transform[TransformObject.Length];

        Sort();

        for (int i = 0; i < TransformObject.Length; i++)
        {
            _pointMove[i] = TransformObject[i].transform;
           
        }
    }

    private void Sort()
    {
        for (int i = 0; i < TransformObject.Length; i++)
        {
            for (int j = 0; j < TransformObject.Length - 1; j++)
            {
                if (int.Parse(TransformObject[j].name) > int.Parse(TransformObject[j + 1].name))
                {
                    var temp = TransformObject[j];
                    TransformObject[j] = TransformObject[j + 1];
                    TransformObject[j + 1] = temp;
                }
            }
        }
    }

    void Update()
    {   
        if(transform.position != _pointMove[_index].position && _isEndPoinMove == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, _pointMove[_index].position, 0.01f);
        }
        else if (_index == _pointMove.Length-1)
        {
            _isEndPoinMove = true;
            MoveLogica();

        }
        else
        {
            _index++;
        }
    }
}
