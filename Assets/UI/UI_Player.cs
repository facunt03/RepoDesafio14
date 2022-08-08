using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Player : MonoBehaviour
{
    public int score;
    public Text TXTscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TXTscore.text = "Monedas Recolectadas: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Monedas") 
        {
            score++;
            Destroy(other.gameObject);
        }
    }

}   
