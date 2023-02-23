using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceScript : MonoBehaviour
{
    public int id;
    public Sprite sprite;
     

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int RollValue()
    {
        switch (id)
        {
            case < 4:
                return id + 1;

            default:
                throw new System.Exception("Invalid FaceID");
        }
        
    }
}
