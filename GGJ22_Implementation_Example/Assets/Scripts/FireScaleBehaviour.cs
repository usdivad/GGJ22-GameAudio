using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScaleBehaviour : MonoBehaviour
{

    float m_CurrScale = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            m_CurrScale = 2f;
        }

        if (m_CurrScale > 1f)
        {
            m_CurrScale -= 0.1f;
        }
        else
        {
            m_CurrScale = 1f;
        }

        transform.localScale = new Vector3(m_CurrScale, m_CurrScale, m_CurrScale);
    }
}
