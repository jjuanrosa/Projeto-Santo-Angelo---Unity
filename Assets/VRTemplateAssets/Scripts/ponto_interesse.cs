using UnityEngine;

public class ponto_interesse : MonoBehaviour
{
    public GameObject pontodeInteresse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        print("entrou na colisão");
        pontodeInteresse.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        print("saiu da colisão");
        pontodeInteresse.SetActive(false);
    }
}
