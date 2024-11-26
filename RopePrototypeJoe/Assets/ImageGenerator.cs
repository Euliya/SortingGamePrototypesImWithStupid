using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ImageGenerator : MonoBehaviour
{
    Image image;
    List<Sprite> objects;

    //keep it a float for now but change it to text later so I can read it
    public int type;
    //red,green,blue
    // Start is called before the first frame update
    void Awake()
    {
        objects = LevelController.Objects();
        LevelController.scoringConditions.Add(this);

        image= GetComponent<Image>();
        SetImages();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //doing the same thing with collectables maybe use a derivitive class design structure later
    public void SetImages()
    {
        int index = Random.Range(0, objects.Count);
        image.sprite = objects[index];
        type = index;
        image.color= Color.white;
    }
    public void highLight()
    {
        image.color = Color.red;
    }
}
