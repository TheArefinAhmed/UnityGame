using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject ballPrefab;
    public GameObject location;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ballPrefab, location.transform.position, location.transform.rotation);

            int rand = Random.Range(0, 3);

            //print("I'm from rand "+rand);

            switch (rand)
            {
                case 0:
                    PlayerPrefs.SetInt("currentNumber", 1);
                    break;
                case 1:
                    PlayerPrefs.SetInt("currentNumber", 2);
                    break;
                case 2:
                    PlayerPrefs.SetInt("currentNumber", 3);
                    break;
            }

        }
    }

}
