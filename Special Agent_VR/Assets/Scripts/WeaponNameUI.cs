using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponNameUI : MonoBehaviour
{
    private TextMeshPro textBox;
    [SerializeField]
    public GameObject weapon1, weapon2, weapon3, weapon4;
    private GameObject[] weapons;

    // Start is called before the first frame update
    void Start()
    {
        textBox = gameObject.GetComponent<TextMeshPro>();
        weapons = new GameObject[] {weapon1, weapon2, weapon3, weapon4};
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < weapons.Length; i++) {
            if (weapons[i].activeSelf) {
                textBox.SetText(weapons[i].tag);
                break;
            }
        }
    }
}
