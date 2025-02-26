﻿
using System;
using Centrifuge.Distance.Data;
using Centrifuge.Distance.Game;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LevelEditorTools;

// Makes it so that medal times and points are not sorted in increasing magnitude when level is saved.
namespace Mod.EditorAnnihilator.Harmony
{
    [HarmonyPatch(typeof(SaveTool), "SortMedalRequirements")]
    internal static class SaveTool__SortMedalRequirements
    {
        //__instance is the class you are patching, so you can call functions on it.
        //If patching a function with paramaters, you can just add those paramaters as paramaters inside Postfix.
        //If the function you're patching has a return type, you can modify the result value with the parameter 'ref [type of return value] __result'
        [HarmonyPrefix]
        internal static bool Prefix()
        {
            return false;
        }
    }
}