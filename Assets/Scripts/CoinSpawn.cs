using System.Collections;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;

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
            Instantiate(coin, new Vector3(Random.Range(-12f, 11f), 3.5f, 86f), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
