using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsAndTools : MonoBehaviour
{
    private bool switchWeapon;
    private bool torchOn;

    [SerializeField]
    public GameObject weapon1, weapon2, weapon3, weapon4;
    [SerializeField]
    public GameObject wp1_icon, wp2_icon, wp3_icon, wp4_icon;
    [SerializeField]
    public GameObject torch;

    // Start is called before the first frame update
    void Start()
    {
      weapon1.SetActive(true);
      weapon2.SetActive(false);
      weapon3.SetActive(false);
      weapon4.SetActive(false);
      wp1_icon.SetActive(true);
      wp2_icon.SetActive(false);
      wp3_icon.SetActive(false);
      wp4_icon.SetActive(false);
      torchOn = false;
      torch.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButtonDown(0) && !Input.GetMouseButtonDown(1) && !Input.GetMouseButton(0) && !Input.GetMouseButton(1)) {
            if (Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("TogglePrimarySecondary")) {
                switchWeapon = !switchWeapon;
                weapon1.SetActive(!switchWeapon);
                wp1_icon.SetActive(!switchWeapon);
                weapon2.SetActive(switchWeapon);
                wp2_icon.SetActive(switchWeapon);
                weapon3.SetActive(false);
                wp3_icon.SetActive(false);
                weapon4.SetActive(false);
                wp4_icon.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Extra")) {
                weapon1.SetActive(false);
                weapon2.SetActive(false);
                weapon3.SetActive(true);
                wp3_icon.SetActive(true);
                weapon4.SetActive(false);
                wp1_icon.SetActive(false);
                wp2_icon.SetActive(false);
                wp4_icon.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.K) || Input.GetButtonDown("LeftTrigger")) {
                weapon1.SetActive(false);
                weapon2.SetActive(false);
                weapon3.SetActive(false);
                wp1_icon.SetActive(false);
                wp2_icon.SetActive(false);
                wp3_icon.SetActive(false);
                weapon4.SetActive(true);
                wp4_icon.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.T) || Input.GetButtonDown("Torch")) {
                torchOn = !torchOn;
                torch.SetActive(torchOn);
            }
        }
    }
}
