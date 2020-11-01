using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool loose = false;
    public float speed = 60.0f;

    private float minX = -10.0f;
    private float maxX = 9.0f;
    private string enemyTag = "EnemyObject";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!Player.loose)
        {
            Vector3 dir = Vector3.zero;
            dir.x = Input.acceleration.x;
            //dir.z = Input.acceleration.x;
            if (dir.sqrMagnitude > 1)
                dir.Normalize();

            dir *= Time.deltaTime;

            Vector3 position = transform.position += (dir * speed);
            position.x = Mathf.Clamp(position.x, minX, maxX);
            transform.position = position;
        }        
    }    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == enemyTag)
        {
            loose = true;
        }
    }
}
