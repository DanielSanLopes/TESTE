using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopKeeper : MonoBehaviour
{

    public Transform player;
    public SpriteRenderer Splayer;
    public GameObject interaction;
    public GameObject Canvas;

    public GameObject buy;
    public GameObject sell;

    private Transform esteT;
    
    // Start is called before the first frame update
    void Start()
    {
        esteT = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(esteT.position, player.position) < 1.5f && Splayer.sortingLayerName == "Layer 1") {
            interaction.SetActive(true);
        } else
            interaction.SetActive(false);

        if (Input.GetKey(KeyCode.E) && interaction.activeInHierarchy) {
            Canvas.SetActive(true);
        }

        if (Input.GetKey(KeyCode.E) && Canvas.activeInHierarchy) {
            buy.SetActive(false);
            sell.SetActive(false);
        }
            


    }

    
}
