using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public GameObject particles;
    public string level;  //level to load

    // Use this for initialization
    void Start () {
        particles.SetActive(false);
	}
	
    //on collision do this
	void OnCollisionEnter(Collision other)
    {
        gameObject.transform.position = gameObject.transform.position - new Vector3(0f, 0.01f, 0f);
        particles.SetActive(true); //start the particle effects
        StartCoroutine(Wait()); //wait 5 seconds before loading scene
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(level); //load the scene chosen
    }
}
