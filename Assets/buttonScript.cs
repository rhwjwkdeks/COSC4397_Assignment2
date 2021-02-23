using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{
    public GameObject Sword;
    public GameObject Penny;
    public GameObject Zombie;
    private Button swordButton;
    private Button pennyButton;
    private Button zombieButton;
    public bool ss;
    public bool pp;
    public bool zz;

    // Start is called before the first frame update
    void Start()
    {
        Sword = GameObject.Find("Heavy_Full_Metal_Sword");
        Penny = GameObject.Find("Penny");
        Zombie = GameObject.Find("Zombie@Z_Run_InPlace");

        

        swordButton = GameObject.Find("swordButton").GetComponent<Button>();
        pennyButton = GameObject.Find("pennyButton").GetComponent<Button>();
        zombieButton = GameObject.Find("zombieButton").GetComponent<Button>();

        swordButton.GetComponentInChildren<Text>().text = "Sword";
        pennyButton.GetComponentInChildren<Text>().text = "Penny";
        zombieButton.GetComponentInChildren<Text>().text = "Zombie";

        Sword.SetActive(false);
        Penny.SetActive(false);
        Zombie.SetActive(true);

        ss = false;
        pp = false;
        zz = true;

    }

    // Update is called once per frame
    void Update()
    {
        swordButton.onClick.AddListener(swordTaskOnClick);
        pennyButton.onClick.AddListener(pennyTaskOnClick);
        zombieButton.onClick.AddListener(zombieTaskOnClick);
    }

    void swordTaskOnClick()
    {
        Sword.SetActive(true);
        Penny.SetActive(false);
        Zombie.SetActive(false);

        ss = true;
        pp = false;
        zz = false;
    }

    void pennyTaskOnClick()
    {
        Sword.SetActive(false);
        Penny.SetActive(true);
        Zombie.SetActive(false);

        ss = false;
        pp = true;
        zz = false;
    }

    void zombieTaskOnClick()
    {
        Sword.SetActive(false);
        Penny.SetActive(false);
        Zombie.SetActive(true);

        ss = false;
        pp = false;
        zz = true;
    }
}
