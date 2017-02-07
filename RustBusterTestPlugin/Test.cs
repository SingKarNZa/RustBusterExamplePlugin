using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RustBuster2016.API;
using UnityEngine;

namespace RustBusterTestPlugin
{
    public class Test : RustBusterPlugin
    {
        public TestGUI test;
        private static GameObject Load;

        public override string Name
        {
            get { return "TestPlugin"; }
        }

        public override string Author
        {
            get { return "DreTaX"; }
        }

        public override Version Version
        {
            get { return new Version("1.0"); }
        }

        public override void DeInitialize()
        {
            // DeInitialize gets called on disconnect, be sure to cleanup the user's client.
            UnityEngine.Object.Destroy(Load);
        }

        public override void Initialize()
        {
            Load = new GameObject();
            test = Load.AddComponent<TestGUI>();
            UnityEngine.Object.DontDestroyOnLoad(Load);
            UnityEngine.Debug.Log("Loaded!");
        }
    }
}
