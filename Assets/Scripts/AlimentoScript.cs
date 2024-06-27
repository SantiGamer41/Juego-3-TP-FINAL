using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlimentoScript : MonoBehaviour
{
    public float fallingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallingSpeed * Time.deltaTime, 0, Space.World);
    }
}
