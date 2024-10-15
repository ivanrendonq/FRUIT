using UnityEngine;
using Utils.SingletonPattern;

namespace UI
{
    public class CursorController : SingletonMonoBehaviour<CursorController>
    {
        public Texture2D normalImage;
        public Texture2D selectImage;

        private void Start()
        {
            ChangeCursor(CursorType.Normal);
        }

        public void ChangeCursor(CursorType cursorType)
        {
            Texture2D choosedCursor = normalImage;

            switch (cursorType)
            {
                case CursorType.Normal:
                    choosedCursor = normalImage;
                    break;
                case CursorType.Select:
                    choosedCursor = selectImage;
                    break;
            }

            Cursor.SetCursor(choosedCursor, Vector2.zero, CursorMode.Auto);
        }


    }

    public enum CursorType
    {
        Normal,
        Select
    }
}
