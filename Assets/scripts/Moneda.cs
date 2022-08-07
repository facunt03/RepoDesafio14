using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int monedas;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
     void OnTriggerEnter(Collider other)
    {

        if (other.transform.gameObject.tag == "Monedas")
        {
            Destroy(other.gameObject);
            monedas++;
            Debug.Log(monedas);
        }
    }
}
