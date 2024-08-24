using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> targets;
    
    private float spawnRate = 1.0f;
    public TextMeshProUGUI scoretext;
    private int score; 
    void Start()
    {
        StartCoroutine(spawnTarget());
        updateScore(0);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnTarget()
    {
        while (true)
        {
            yield return new  WaitForSeconds(spawnRate); 
            int index = Random.Range (0, targets.Count);
            Instantiate(targets[index]);
          
        }
    }
    public void updateScore (int scoretoadd) {
        score += scoretoadd;
        scoretext.text = "Score :  " + score;

    }
}
