using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class MaximizeEditorWindowShortcutKey
    {
        [Shortcut( "Kogane/Maximize Editor Window", KeyCode.UpArrow, ShortcutModifiers.Action )]
        private static void Maximize()
        {
            var focusedWindow = EditorWindow.focusedWindow;
            if ( focusedWindow == null ) return;
            focusedWindow.maximized = true;
        }

        [Shortcut( "Kogane/Minimize Editor Window", KeyCode.DownArrow, ShortcutModifiers.Action )]
        private static void Minimize()
        {
            var focusedWindow = EditorWindow.focusedWindow;
            if ( focusedWindow == null ) return;
            focusedWindow.maximized = false;
        }
    }
}