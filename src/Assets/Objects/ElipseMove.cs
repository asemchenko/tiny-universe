using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElipseMove : MonoBehaviour
{
    private int way = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float r2 = this.transform.position.x * this.transform.position.x + this.transform.position.y * this.transform.position.y;
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float a2 = (r2 * (x*x/r2 + 9*y*y/ r2) ) /9;
        Vector3 position = transform.position;
        x += (float)0.05 * way;
        if (x*x>a2*9)
        {
            if (way < 0 && x < 0||way>0&&x>0)
            {
                way *= -1;
                y *= -1;
            }
        }
        position.x+= (float)0.05*way;
        position.y = y;
        if (y<0)
        {
            position.y = Mathf.Sqrt(a2 - position.x * position.x/9) * -1;
        }
        else
        {
            position.y = Mathf.Sqrt(a2 - position.x * position.x / 9);
        }
        this.transform.position = position;
    }
}
