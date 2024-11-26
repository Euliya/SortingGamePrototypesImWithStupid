using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Collectables : MonoBehaviour
{
    List<Sprite> colors;
    public SpriteRenderer spriteRenderer;
    float speed = 1f;

    public int type;
    // Start is called before the first frame update
    void Start()
    {
        colors = LevelController.Objects();
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetImages();
    }

    // Update is called once per frame
    void Update()
    {
        moving();
    }

    void SetImages()
    {
        //def need a bag randomizer
        int index = Random.Range(0, colors.Count);
        spriteRenderer.sprite = colors[index];
        type = index;
    }

    void moving()
    {
        transform.position += speed * Vector3.right * Time.deltaTime;
    }
}
