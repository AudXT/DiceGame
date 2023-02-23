using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class DiceScript : MonoBehaviour
{
    public Sprite[] faces;

    bool roll = false;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = faces[0]; // set the sprite to sprite1
    }

    // Update is called once per frame
    void Update()
    {
        if (roll)
        {
            ChangeFace();
        }
    }

    public void OnRoll()
    {
        ChangeFace();
    }

    void ChangeFace()
    {
        var roll = Random.Range(0, 3);
        Debug.Log("Face rolled " + roll);
        spriteRenderer.sprite = faces[roll];
    }

    IEnumerable rollWait()
    {
        yield return new WaitForSecondsRealtime(1);
    }
}
