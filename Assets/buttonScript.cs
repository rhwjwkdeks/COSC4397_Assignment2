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

    // Start is called before the first frame update
    void Start()
    {
        Sword = GameObject.Find("Heavy_Full_Metal_Sword");
        Penny = GameObject.Find("Penny");
        Zombie = GameObject.Find("Zombie@Z_Run_InPlace");

        Sword.SetActive(false);
        Penny.SetActive(false);
        Zombie.SetActive(true);

        swordButton = GameObject.Find("swordButton").GetComponent<Button>();
        pennyButton = GameObject.Find("pennyButton").GetComponent<Button>();
        zombieButton = GameObject.Find("zombieButton").GetComponent<Button>();

        swordButton.GetComponentInChildren<Text>().text = "Sword";
        pennyButton.GetComponentInChildren<Text>().text = "Penny";
        zombieButton.GetComponentInChildren<Text>().text = "Zombie";

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
    }

    void pennyTaskOnClick()
    {
        Sword.SetActive(false);
        Penny.SetActive(true);
        Zombie.SetActive(false);
        Penny.transform.localScale = new Vector3(100, 3, 100);
    }

    void zombieTaskOnClick()
    {
        Sword.SetActive(false);
        Penny.SetActive(false);
        Zombie.SetActive(true);
    }
}
