using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMBIARRA : MonoBehaviour
{
    public shopKeeper shopKeeper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SETFALSE() {
        shopKeeper.Canvas.SetActive(false);
    }
}
