using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.position.y < 0){
            //GrabPickups.nivel = 0;
            Pickup.nivel = 0;
			DontDestroy.instance.GetComponent<AudioSource>().Pause();
			SceneManager.LoadScene("Gameover");
        }
/*		
		In PlayerController.cs, in Update(), add an if-statement checking for a spacebar press:
if (Input.GetKeyDown(KeyCode.Space)) {
	
	https://cs50.harvard.edu/x/2022/new/#how-to-copy-files-from-cs50-ide-to-your-cs50-codespace
	https://cs50.stackexchange.com/questions/22455/chmoding-in-ide-caused-out-of-disc-space
	*/
    }
}
