using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    static LevelController Instance;
    private void Awake()
    {
        Instance = this;
    }
    [SerializeField] List<Sprite> objects = new List<Sprite>();
    static public List<Sprite> Objects() => Instance.objects;
    
    static public List<ImageGenerator> scoringConditions = new List<ImageGenerator>();
}
