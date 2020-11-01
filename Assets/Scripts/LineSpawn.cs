using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSpawn : MonoBehaviour
{
    public GameObject line;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            Instantiate(line, new Vector3(-0.44f, 1.28f, 86.3f), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
