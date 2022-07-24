using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRage.Plugins;
using HarmonyLib;
using Sandbox.Game.Entities;
using System.Reflection;

namespace Disable_Export_Model
{
    public class Main : IPlugin
    {
        public void Init(object gameInstance)
        {
            new Harmony("DisableExportModel").PatchAll(Assembly.GetExecutingAssembly());
        }

        public void Update()
        {

        }

        public void Dispose()
        {

        }
    }

    [HarmonyPatch(typeof(MyCubeBuilder), "HandleExportInput")]
    public class HandleExportInputPatch
    {
        public static bool Prefix(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}
