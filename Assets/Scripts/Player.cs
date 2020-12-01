using UnityEngine;

public class Player : MonoBehaviour
{
    // public (widoczny w Inspectorze, widoczny dla innych skryptow (klas)
    // private (niewidoczny w Inspectorze, niewidoczny dla innych skryptow
    // [SerializeField] private (widoczny w Inspectorze, niewidoczny dla innych skryptow)
    // [HideInInspector] public (niewidoczny w Inspectorze, widoczny dla innych skryptow)
    [SerializeField] private float movementSpeed = 8f;
    [SerializeField] private float horizontalStep = 10f;
    [SerializeField] private int linesCount = 3;
    private int line = 0;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        // old: 1 unit per frame
        // 1 unit per second
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftArrow) && line > (-linesCount / 2))
        {
            line -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && line < (linesCount / 2))
        {
            line += 1;
        }

        transform.position = new Vector3(line * horizontalStep, transform.position.y, transform.position.z);
    }
}
