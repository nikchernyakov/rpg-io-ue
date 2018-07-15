using UnityEngine;

public static class MouseUtils {
    
    public static float GetMouseAndTargetAngle(Vector3 targetPosition)
    {
        var lookPos = GetMousePosition() - targetPosition;
        return Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
    }

    public static Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.transform.position.z));
    }
}
