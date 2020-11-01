using UnityEngine;
using UnityEngine.UI;

public class ScopeCounter : MonoBehaviour
{
    public GameObject scopeText;
    // Start is called before the first frame update
    void Start()
    {
        scopeText.GetComponent<Text>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        scopeText.GetComponent<Text>().text = Player.scope.ToString();
    }
}
