using UnityEngine;

namespace WinuXGames.SplitFramework.Utility
{
    public static class Vector2Extension
    {
        public static Vector3 ToMovementVector3(this Vector2 vector2) => new Vector3(vector2.x, 0f, vector2.y);

        public static Vector2 LengthDirDeg(float distance, float direction) => LengthDir(distance, direction * Mathf.Deg2Rad);

        public static Vector2 LengthDir(float distance, float direction) => new Vector2(Mathf.Cos(direction) * distance, -Mathf.Sin(direction) * distance);
    }
}