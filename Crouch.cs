using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite newSprite; // ����� ������, ������� ����� ����������
    private Animator animator;
    private SpriteRenderer spriteRenderer; // ������ �� ��������� SpriteRenderer
    public BoxCollider2D boxCollider;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // �������� ��������� SpriteRenderer
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) // ���� ������ ������� Space
        {
            animator.SetBool("IsChrouching", true);
            boxCollider.size = new Vector2(1, 0.1f);
        }
        if (Input.GetKeyUp(KeyCode.Z)) // ���� ������ ������� Space
        {
            animator.SetBool("IsChrouching", false);
            boxCollider.size = new Vector2(1f, 6f);
            
        }
    }

    
}
