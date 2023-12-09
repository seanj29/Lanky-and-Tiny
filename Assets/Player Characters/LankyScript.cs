using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.U2D.Animation;

public class LankyScript : MonoBehaviour
{
    SpriteResolver m_spriteResolver;
    Rigidbody2D m_rigidBody2D;
    public Vector2 movementForce;
    public InputAction move;
    public InputAction jump;
    // Start is called before the first frame update
    void Start()
    {
        move.Enable();
        jump.Enable();
       //Fetch the SpriteRenderer from the GameObject
        m_spriteResolver = GetComponent<SpriteResolver>();
        m_rigidBody2D = GetComponent<Rigidbody2D>();
        

        string CurrentAnimationGroup = m_spriteResolver.GetCategory();
        if (CurrentAnimationGroup != "LankyIdle")
        {
            m_spriteResolver.SetCategoryAndLabel("LankyIdle", "LankyIdle");
        }


    }

    // Update is called once per frame
    void Update()
    {
        movementForce = move.ReadValue<Vector2>();
        
        if (move.ReadValue<Vector2>() != Vector2.zero){
        m_rigidBody2D.AddForce(movementForce);
        Debug.Log(move.ReadValue<Vector2>());
        }
    }
    
}
