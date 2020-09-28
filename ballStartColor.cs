using UnityEngine;

public class ballStartColor : MonoBehaviour
{
    //public SpriteRenderer cannonColorChanger; 
    public SpriteRenderer playerSprite;

    public void startColorChange()
    {
        playerSprite.GetComponent<SpriteRenderer>();
        int ran;

        ran = PlayerPrefs.GetInt("currentNumberfromCannon");
        switch (ran)
        {
            case 1:
                playerSprite.color = new Color(255f / 255f, 0f/255f, 128f/255f);
                break;
            case 2:
                playerSprite.material.color = new Color(140f/255f , 19f / 255f , 251f/255f);
                break;
            case 3:
                playerSprite.color = new Color(246f / 255f, 223f / 225f, 14f / 223f);
                break;
        }
    }
    void Start()
    {
    }
    private void Update()
    {
        startColorChange(); 
        //switch(ran):

    }
}
