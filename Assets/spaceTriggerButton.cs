using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class spaceTriggerButton : MonoBehaviour
{
    bool selected = false;
    UnityEngine.UI.Button myButt;
    // Start is called before the first frame update
    void Start()
    {
        myButt = this.GetComponent<UnityEngine.UI.Button>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !selected)
        {
            EventSystem.current.SetSelectedGameObject(this.gameObject);
            selected = true;
        }
        if (!Input.GetKey(KeyCode.Space) && selected)
        {
            myButt.onClick.Invoke();
        }

    }
}
