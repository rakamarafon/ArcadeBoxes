using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

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
        while (!Player.loose)
        {
            //ot -12 do 11
            Instantiate(enemy, new Vector3(Random.Range(-12f, 11f), 3.6f, 86f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
