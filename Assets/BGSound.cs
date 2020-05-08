using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSound : MonoBehaviour
{
    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }

}
