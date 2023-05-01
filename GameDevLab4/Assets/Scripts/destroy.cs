using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject jewel;

    SpriteRenderer m_SpriteRenderer;

    void Awake(){
        m_SpriteRenderer = jewel.GetComponent<SpriteRenderer>();
    }

    public void OnCollisionEnter2D(Collision2D collision){
        Destroy(this.gameObject);
        m_SpriteRenderer.color = new Color(1f,1f,1f,1f); 
    }

    
}
