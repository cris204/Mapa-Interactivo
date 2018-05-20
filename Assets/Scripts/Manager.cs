using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {



    private static Manager instance;

    public static Manager Instance
    {
        get
        {
            return instance;
        }
    }

    public bool[] Selecionado;
    public Animator[] anims;

    // Use this for initialization
    void Awake () {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

	}
	
    public void Volver()
    {
        for (int i = 0; i < anims.Length; i++)
        {
            anims[i].SetBool("Entrar", false);
        }
    }

}
