using UnityEngine;
using UnityEngine.U2D.Animation;

public class LankyScript : MonoBehaviour
{


    public float rotateSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
       //Fetch the SpriteRenderer from the GameObject
        SpriteResolver m_spriteResolver = GetComponent<SpriteResolver>();
        Rigidbody2D m_rigidBody2D = GetComponent<Rigidbody2D>();
        string CurrentAnimationGroup = m_spriteResolver.GetCategory();
        if (CurrentAnimationGroup != "LankyIdle")
        {
            m_spriteResolver.SetCategoryAndLabel("LankyIdle", "LankyIdle");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}
