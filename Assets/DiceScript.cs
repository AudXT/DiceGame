using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class DiceScript : MonoBehaviour
{
    public Sprite[] faceSprites;
    public LogicScript logic;
    public FaceScript[] faces;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            faces[i] = GameObject.FindGameObjectWithTag("Face").GetComponent<FaceScript>();
            faces[i].id = i;
            faces[i].sprite = faceSprites[i];
        }

        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = faces[0].sprite; // set the sprite to sprite1


        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnRoll()
    {
        ChangeFace();
        logic.UseRoll();
    }

    void ChangeFace()
    {
        var roll = Random.Range(0, 3);
        Debug.Log("Face rolled " + roll);
        spriteRenderer.sprite = faces[roll].sprite;

        logic.AddScore(faces[roll].RollValue());
    }
}
