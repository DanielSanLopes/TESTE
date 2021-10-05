using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopControler : MonoBehaviour
{
    public TopDownCharacterController playerScript;
    public SpriteRenderer player;
    public GameObject birthHat;
    public GameObject shinobiHat;
    

    public GameObject bHat;
    public GameObject sHat;
    public Image body;
    public Color actColor;

    public Button[] buttons;
    public Button[] buttonsS;

    public GameObject sellPanel;
    public GameObject bSellHat;
    public GameObject sSellHat;
    public Image Sbody;

    public int selected;

    Color shinobiSkin = new Color(32, 32, 32, 255);
    Color cuteSkin = new Color(255, 66, 66, 255);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnActive()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
            updateSellShowing();


        if (playerScript.coins < 200) {
            buttons[0].interactable = false;
            buttons[1].interactable = false;
            buttons[2].interactable = false;
            buttons[3].interactable = false;
        } else if (playerScript.coins >= 200 && playerScript.coins < 300) {
            buttons[0].interactable = false;
            buttons[1].interactable = false;
            buttons[2].interactable = true;
            buttons[3].interactable = false;
        } else if (playerScript.coins >= 300 && playerScript.coins < 400) {
            buttons[0].interactable = false;
            buttons[1].interactable = false;
            buttons[2].interactable = true;
            buttons[3].interactable = true;
        } else if (playerScript.coins >= 400 && playerScript.coins < 500) {
            buttons[0].interactable = false;
            buttons[1].interactable = true;
            buttons[2].interactable = true;
            buttons[3].interactable = true;
        } else if (playerScript.coins >= 500) {
            buttons[0].interactable = true;
            buttons[1].interactable = true;
            buttons[2].interactable = true;
            buttons[3].interactable = true;

        }
    }

    public void ChangeShowing(int item)
    {
        selected = item;
        switch (item)
        {
            case 1:
                    body.color = new Color (0.16f, 0.16f, 0.16f, 1);
                
                break; 
            case 2 : 
                    body.color = new Color(1, 0.45f, 0.45f, 1);
                    break;
            case 3 : {
                    if (bHat.activeInHierarchy)
                    {
                        bHat.SetActive(false);
                    } else {
                        sHat.SetActive(false);
                        bHat.SetActive(true);
                    }
                        
                    break; }
            case 4: {
                    if (sHat.activeInHierarchy)
                    {
                        sHat.SetActive(false);
                    } else {
                        bHat.SetActive(false);
                        sHat.SetActive(true);
                    }
                        
                    break; }
            default:
                    bHat.SetActive(false);
                    sHat.SetActive(false);
                break;

                
                
        }
    }


    public void ButtonBuy() {
        if (buttons[selected - 1].gameObject.activeInHierarchy) {
            buttons[selected - 1].gameObject.SetActive(false);
            Buy(selected);
        }
    }

    public void Buy(int item) {
        switch (item) {
            case 1: {
                    player.color = new Color(0.16f, 0.16f, 0.16f, 1);
                   // buttons[item - 1].gameObject.SetActive(false);
                    playerScript.coins -= Mathf.RoundToInt(Mathf.Lerp(0, 500, 4));
                    Sbody.color = player.color;
                    break;
                }
            case 2: {
                    player.color = new Color(1, 0.45f, 0.45f, 1);
                    //buttons[item - 1].gameObject.SetActive(false);
                    playerScript.coins -= Mathf.RoundToInt(Mathf.Lerp (0, 400, 4));
                    Sbody.color = player.color;
                    break;
                }
            case 3: {
                    birthHat.SetActive(true);
                    shinobiHat.SetActive(false);

                    // buttons[item - 1].gameObject.SetActive(false);
                    playerScript.coins -= Mathf.RoundToInt(Mathf.Lerp(0, 200, 4));

                    bSellHat.SetActive(true);
                    break;
                }
            case 4: {
                    shinobiHat.SetActive(true);
                    birthHat.SetActive(false);

                    //buttons[item - 1].gameObject.SetActive(false);
                    playerScript.coins -= Mathf.RoundToInt(Mathf.Lerp(0, 300, 4));

                    sSellHat.SetActive(true);
                    break;
                }
        }

    }


    public void updateSellShowing() {

        for (int i = 0; i < 4; i++) {
            if (buttons[i].gameObject.activeInHierarchy)
                buttonsS[i].gameObject.SetActive(false);
            else
                buttonsS[i].gameObject.SetActive(true);
        }

    }

    public void updateSellShowing(int item) {
        selected = item;
        switch (item) {
            case 1:
                Sbody.color = new Color(1, 1, 1, 1);

                break;
            case 2:
                Sbody.color = new Color(1, 1, 1, 1);
                break;
            case 3: {
                    if (bSellHat.activeInHierarchy) {
                        bSellHat.SetActive(false);
                    } else {
                        bSellHat.SetActive(true);
                    }

                    break;
                }
            case 4: {
                    if (sSellHat.activeInHierarchy) {
                        sSellHat.SetActive(false);
                    } else {
                        sSellHat.SetActive(true);
                    }

                    break;
                }
            default:
                bHat.SetActive(true);
                sHat.SetActive(true);
                break;



        }
    }



    public void ButtonSell() {
        if (buttonsS[selected - 1].gameObject.activeInHierarchy) {
            buttonsS[selected - 1].gameObject.SetActive(false);
            Sell(selected);
        }
    }

    public void Sell(int item) {
        switch (item) {
            case 1: {
                    player.color = new Color(1, 1, 1, 1);
                    // buttons[item - 1].gameObject.SetActive(false);
                    playerScript.coins += Mathf.RoundToInt(Mathf.Lerp(0, 300, 4));
                    buttonsS[item - 1].gameObject.SetActive(false);
                    break;
                }
            case 2: {
                    player.color = new Color(1, 1, 1, 1);
                    //buttons[item - 1].gameObject.SetActive(false);
                    buttonsS[item - 1].gameObject.SetActive(false);
                    playerScript.coins += Mathf.RoundToInt(Mathf.Lerp(0, 200, 4));
                    break;
                }
            case 3: {
                    birthHat.SetActive(false);
                    //shinobiHat.SetActive(false);

                    // buttons[item - 1].gameObject.SetActive(false);
                    buttonsS[item - 1].gameObject.SetActive(false);
                    playerScript.coins += Mathf.RoundToInt(Mathf.Lerp(0, 100, 4));
                    break;
                }
            case 4: {
                    shinobiHat.SetActive(false);
                    //birthHat.SetActive(false);

                    //buttons[item - 1].gameObject.SetActive(false);
                    buttonsS[item - 1].gameObject.SetActive(false);
                    playerScript.coins += Mathf.RoundToInt(Mathf.Lerp(0, 100, 4));
                    break;
                }
        }
    }
}
