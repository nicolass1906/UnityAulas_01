using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidade = 10;
    
    public TMP_Text pontuacaoEsquerda;
    public TMP_Text pontuacaoDireita;
    int pontosEsquerda = 0;
    int pontosDireita = 0;

    // Start is called before the first frame update
    void Start()
    {
            
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        /* float x1 = Random.Range(0,2);
        if(x1 == 0)
        {
            x1 = -1;
         
        }else
        {
            x1 = 1;
        }*/

        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector2(velocidade*x,velocidade*y);

        pontuacaoDireita.SetText(pontosDireita.ToString());
        pontuacaoEsquerda.SetText(pontosEsquerda.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision Batida)
    {
        if ((Batida.gameObject.name == "BEsquerda"))
        {
            transform.position = new Vector3(2, 0, 9);
            pontosDireita++;
            Start();
        }

        else if((Batida.gameObject.name == "BDireita"))
        {
            transform.position = new Vector3(2, 0, 9);
            pontosEsquerda++;
            Start();
        }
    }
}
