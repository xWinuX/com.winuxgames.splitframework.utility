using UnityEngine;

namespace WinuXGames.SplitFramework.Utility
{
    public static class Vector3Extension
    {
        public static Vector2 ToMovementVector2(this Vector3 vector3) => new Vector2(vector3.x, vector3.z);
    }
}