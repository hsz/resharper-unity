using UnityEngine;

public class NotAvailableDueToNoNonAllocTest : MonoBehaviour
{
    public void Method()
    {
        Physics2D.OverlapBox(Vector2.down, Vector2.down, 0f);
    }
}
