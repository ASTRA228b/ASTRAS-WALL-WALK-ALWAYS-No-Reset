using UnityEngine;

namespace ASTRAS_WALL_WALK_ALWAYS.Core
{
    public class CreditUI : MonoBehaviour
    {
        GUIStyle? style;

        void Start()
        {
            style = GUI.skin.label;
            style.fontSize = 14;
            style.normal.textColor = Color.white;
        }

        void OnGUI() 
        {
            
            GUI.Label(new Rect(10, 10, 400, 20), "CREDS LIST", style);
            GUI.Label(new Rect(10, 30, 400, 20), "Made by ASTRA", style);
            GUI.Label(new Rect(10, 50, 400, 20), "Thanks to iis menu temp for notfilib", style);
        }
    }
}