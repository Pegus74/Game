using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite newSprite; // Новый спрайт, который нужно установить
    private Animator animator;
    private SpriteRenderer spriteRenderer; // Ссылка на компонент SpriteRenderer
    public BoxCollider2D boxCollider;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Получаем компонент SpriteRenderer
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) // Если нажата клавиша Space
        {
            animator.SetBool("IsChrouching", true);
            boxCollider.size = new Vector2(1, 0.1f);
        }
        if (Input.GetKeyUp(KeyCode.Z)) // Если нажата клавиша Space
        {
            animator.SetBool("IsChrouching", false);
            boxCollider.size = new Vector2(1f, 6f);
            
        }
    }

    
}
