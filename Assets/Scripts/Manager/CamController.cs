using UnityEngine;

public class CamController : MonoBehaviour
{
    private Player target;

    private void LateUpdate()
    {
        target = GameManager.Instance.Player;
        if (target != null)
        {
            Vector3 camPos = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
            transform.position = camPos;
        }
    }
}
