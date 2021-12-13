using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {    
    void OnCollisionEnter(Collision col) {{
    	Debug.Log("Collision Detected It Works");
    	SceneManager.LoadScene("Level 2");
    	}
    }
}