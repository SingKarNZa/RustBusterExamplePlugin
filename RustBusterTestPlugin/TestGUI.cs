using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RustBusterTestPlugin
{
    public class TestGUI : MonoBehaviour
    {
        
        public void OnGUI()
        {
            // Make a background box
            GUI.Box(new Rect(10, 10, 100, 90), "Test Menu");

            // Make the first button. If it is pressed, Rust.Notice.Popup will be executed
            if (GUI.Button(new Rect(20, 40, 80, 20), "Test"))
            {
                Rust.Notice.Popup("", "Test");
            }
        }
    }
}
