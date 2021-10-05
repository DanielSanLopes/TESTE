using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baseUIControler : MonoBehaviour
{

    public TopDownCharacterController playerScript;

    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = playerScript.coins.ToString();
        
    }
}
