using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public TextMeshProUGUI Score;
    float score;

    public List<ImageGenerator> scoringConditions;
    int itemsCount=0;

    void Start()
    {
        score = 0;
        LevelGenerator();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collectables contact = collision.GetComponent<Collectables>();
        int check = listChecker(contact);
        if (check != -1)
        {
            //i handled it wrong
            score++;itemsCount--;
            scoringConditions[check].highLight();
            scoringConditions[check].type = -1;
            if(itemsCount == 0)LevelGenerator();
        }
        else 
        {
            score--; 
            print("Dont submit the incorrect shapes"); 
        } 
        Destroy(collision.gameObject);
        Score.text = "Score: " + score;
    }

    int listChecker(Collectables contact)
    {
        for (int i = 0; i < scoringConditions.Count; i++)
        {
            if (contact.type == scoringConditions[i].type)return i;
        }
        return -1;
    }
    
    void LevelGenerator()
    {
        print("new Level");
        for (int i=0;i< LevelController.scoringConditions.Count;i++)
        {
            LevelController.scoringConditions[i].SetImages();
        }
        scoringConditions = LevelController.scoringConditions; 
        itemsCount = scoringConditions.Count;
        print(itemsCount);
    }

}
