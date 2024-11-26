using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableGenerator : MonoBehaviour
{
    [SerializeField] GameObject CollectablePrefab;
    [SerializeField] float interval=3f;
    public Transform topPoint;
    public Transform bottomPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Generate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Generate()
    {
        while (true)
        {
            GameObject collectable = Instantiate(CollectablePrefab);
            collectable.transform.position = new Vector2(Random.Range(topPoint.position.x,bottomPoint.position.x),Random.Range(topPoint.position.y,bottomPoint.position.y));
            yield return new WaitForSeconds(interval);
        }
        
    }
}
