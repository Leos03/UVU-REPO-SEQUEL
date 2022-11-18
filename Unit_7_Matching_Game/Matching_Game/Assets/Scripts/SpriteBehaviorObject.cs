using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class SpriteBehaviorObject : MonoBehaviour
{
    private SpriteRenderer rendererObj;

    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>(); 
    }
}
