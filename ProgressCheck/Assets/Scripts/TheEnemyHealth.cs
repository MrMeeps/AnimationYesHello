using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnemyHealth : MonoBehaviour
{
    public int potatosFeeeed = 11;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MrBulletMan" )
        {
            potatosFeeeed--;
            if(potatosFeeeed < 1)
            {
                Destroy(gameObject);
            }

        }
    }
}
