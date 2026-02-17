using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.Mono;
using HarmonyLib;
using System;
using System.Reflection;
using UnityEngine;

namespace BitchlandLetsHaveSexHereChatBepInEx
{
    [BepInPlugin("com.wolfitdm.BitchlandLetsHaveSexHereChatBepInEx", "BitchlandLetsHaveSexHereChatBepInEx Plugin", "1.0.0.0")]
    public class BitchlandLetsHaveSexHereChatBepInEx : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;

        private static ConfigEntry<bool> configEnableMe;
        private static ConfigEntry<bool> configMaxRelationShipIfYouHaveSex;
        private static ConfigEntry<bool> configAddChatOptionToXoxa;
        private static ConfigEntry<bool> configAddChatOptionToArmyBuildWorkers;
        private static ConfigEntry<bool> configAddChatOptionToTheClinicDoctorMaylenne;
        private static ConfigEntry<bool> configAddChatOptionToWar;
        private static ConfigEntry<bool> configAddChatOptionToHadley;
        private static ConfigEntry<bool> configAddChatOptionToBeth;
        private static ConfigEntry<bool> configAddChatOptionToPrisioner;
        private static ConfigEntry<bool> configAddChatOptionToPaintShopPerson;
        private static ConfigEntry<bool> configAddChatOptionToMisProst;
        private static ConfigEntry<bool> configAddChatOptionToStripClubWorkers;
        private static ConfigEntry<bool> configAddChatOptionToSia;
        private static ConfigEntry<bool> configAddChatOptionToGuards;
        private static ConfigEntry<bool> configAddChatOptionToSarah;
        private static ConfigEntry<bool> configAddChatOptionToZea;
        private static ConfigEntry<bool> configAddChatOptionToSephie;
        private static ConfigEntry<bool> configAddChatOptionToFollower;
        private static ConfigEntry<bool> configAddChatOptionToLeashedPersons;

        public BitchlandLetsHaveSexHereChatBepInEx()
        {
        }

        public static Type MyGetType(string originalClassName)
        {
            return Type.GetType(originalClassName + ",Assembly-CSharp");
        }

        public static Type MyGetTypeUnityEngine(string originalClassName)
        {
            return Type.GetType(originalClassName + ",UnityEngine");
        }

        private static string pluginKey = "General.Toggles";

		public static bool enableMe = false;
        public static bool maxRelationShipIfYouHaveSex = false;
        public static bool addChatOptionToXoxa = false;
        public static bool addChatOptionToArmyBuildWorkers = false;
        public static bool addChatOptionToTheClinicDoctorMaylenne = false;
        public static bool addChatOptionToWar = false;
        public static bool addChatOptionToHadley = false;
        public static bool addChatOptionToBeth = false;
        public static bool addChatOptionToPrisioner = false;
        public static bool addChatOptionToPaintShopPerson = false;
        public static bool addChatOptionToMisProst = false;
        public static bool addChatOptionToStripClubWorkers = false;
        public static bool addChatOptionToSia = false;
        public static bool addChatOptionToGuards = false;
        public static bool addChatOptionToZea = false;
        public static bool addChatOptionToSephie = false;
        public static bool addChatOptionToFollower = false;
        public static bool addChatOptionToLeashedPersons = false;
        public static bool addChatOptionToSarah = false;


        private void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;

            configEnableMe = Config.Bind(pluginKey,
                                              "EnableMe",
                                              true,
                                             "Whether or not you want enable this mod (default true also yes, you want it, and false = no)");

            configMaxRelationShipIfYouHaveSex = Config.Bind(pluginKey,
                               "MaxRelationShipIfYouHaveSex",
                               true,
                              "Whether or not you want max relationship if you have sex (default true also yes, you want it, and false = no)");

            configAddChatOptionToXoxa = Config.Bind(pluginKey,
                                  "AddChatOptionToXoxa",
                                  false,
                                 "Whether or not you want add chat option to xoxa (if true it removes the default chat from xoxa) (default false also yes, you dont want it, and true = yes)");

            configAddChatOptionToArmyBuildWorkers = Config.Bind(pluginKey,
                      "AddChatOptionToArmyBuildWorkers",
                      true,
                     "Whether or not you want add chat option to ArmyBuildWorkers (default true also yes, you want it, and false = no)");

            configAddChatOptionToTheClinicDoctorMaylenne = Config.Bind(pluginKey,
                      "AddChatOptionToTheClinicDoctorMaylenne",
                      true,
                     "Whether or not you want add chat option to TheClinicDoctorMaylenne (default true also yes, you want it, and false = no)");

            configAddChatOptionToWar = Config.Bind(pluginKey,
                      "AddChatOptionToWar",
                      true,
                     "Whether or not you want add chat option to War (default true also yes, you want it, and false = no)");

            configAddChatOptionToHadley = Config.Bind(pluginKey,
                      "AddChatOptionToHadley",
                      true,
                     "Whether or not you want add chat option to Hadley (default true also yes, you want it, and false = no)");

            configAddChatOptionToBeth = Config.Bind(pluginKey,
                      "AddChatOptionToBeth",
                      true,
                     "Whether or not you want add chat option to Beth (default true also yes, you want it, and false = no)");

            configAddChatOptionToPrisioner = Config.Bind(pluginKey,
                      "AddChatOptionToPrisioner",
                      true,
                      "Whether or not you want add chat option to Prisioner (default true also yes, you want it, and false = no)");

            configAddChatOptionToPaintShopPerson = Config.Bind(pluginKey,
                      "AddChatOptionToPaintShopPerson",
                      true,
                     "Whether or not you want add chat option to PaintShopPerson (default true also yes, you want it, and false = no)");

            configAddChatOptionToMisProst = Config.Bind(pluginKey,
                      "AddChatOptionToMisProst",
                      true,
                     "Whether or not you want add chat option to MisProst (default true also yes, you want it, and false = no)");

            configAddChatOptionToStripClubWorkers = Config.Bind(pluginKey,
                     "AddChatOptionToStripClubWorkers",
                     true,
                    "Whether or not you want add chat option to StripClubWorkers (default true also yes, you want it, and false = no)");

            configAddChatOptionToSia = Config.Bind(pluginKey,
                     "AddChatOptionToSia",
                     true,
                    "Whether or not you want add chat option to Sia (default true also yes, you want it, and false = no)");

            configAddChatOptionToGuards = Config.Bind(pluginKey,
                     "AddChatOptionToGuards",
                     true,
                    "Whether or not you want add chat option to Guards (default true also yes, you want it, and false = no)");

            configAddChatOptionToSarah = Config.Bind(pluginKey,
                    "AddChatOptionToSarah",
                    true,
                    "Whether or not you want add chat option to Sarah (default true also yes, you want it, and false = no)");

            configAddChatOptionToZea = Config.Bind(pluginKey,
                    "AddChatOptionToZea",
                    true,
                    "Whether or not you want add chat option to Zea (default true also yes, you want it, and false = no)");

            configAddChatOptionToSephie = Config.Bind(pluginKey,
                    "AddChatOptionToSephie",
                    true,
                    "Whether or not you want add chat option to Sephie (default true also yes, you want it, and false = no)");

            configAddChatOptionToFollower = Config.Bind(pluginKey,
                    "AddChatOptionToFollower",
                    true,
                    "Whether or not you want add chat option to Follower (default true also yes, you want it, and false = no)");

            configAddChatOptionToLeashedPersons = Config.Bind(pluginKey,
                    "AddChatOptionToLeashedPersons",
                    true,
                    "Whether or not you want add chat option to LeashedPersons (default true also yes, you want it, and false = no)");

            enableMe = configEnableMe.Value;
            maxRelationShipIfYouHaveSex = configMaxRelationShipIfYouHaveSex.Value;
            addChatOptionToXoxa = configAddChatOptionToXoxa.Value;
            addChatOptionToArmyBuildWorkers = configAddChatOptionToArmyBuildWorkers.Value;
            addChatOptionToTheClinicDoctorMaylenne = configAddChatOptionToTheClinicDoctorMaylenne.Value;
            addChatOptionToWar = configAddChatOptionToWar.Value;
            addChatOptionToHadley = configAddChatOptionToHadley.Value;
            addChatOptionToBeth = configAddChatOptionToBeth.Value;
            addChatOptionToPrisioner = configAddChatOptionToPrisioner.Value;
            addChatOptionToPaintShopPerson = configAddChatOptionToPaintShopPerson.Value;
            addChatOptionToMisProst = configAddChatOptionToMisProst.Value;
            addChatOptionToStripClubWorkers = configAddChatOptionToStripClubWorkers.Value;
            addChatOptionToSia = configAddChatOptionToSia.Value;
            addChatOptionToGuards = configAddChatOptionToGuards.Value;
            addChatOptionToZea = configAddChatOptionToZea.Value;
            addChatOptionToSephie = configAddChatOptionToSephie.Value;
            addChatOptionToFollower = configAddChatOptionToFollower.Value;
            addChatOptionToLeashedPersons = configAddChatOptionToLeashedPersons .Value;
            addChatOptionToSarah = configAddChatOptionToSarah.Value;

            PatchAllHarmonyMethods();

            Logger.LogInfo($"Plugin BitchlandMoreWeaponSlotsBepInEx BepInEx is loaded!");
        }
		
		public static void PatchAllHarmonyMethods()
        {
			if (!enableMe)
            {
                return;
            }
			
            try
            {
                if (enableMe)
                {
                    try
                    {
                        if (addChatOptionToXoxa)
                            PatchHarmonyMethodUnity(typeof(Mis_Xoxa), "Chat_Xoxa", "Chat_Xoxa", true, false);
                    }
                    catch { }
                    //try
                    //{
                    //    PatchHarmonyMethodUnity(typeof(Mis_Xoxa), "Chat_Xoxa2", "DefaultTalk_options_AddSexOption", false, true);
                    //}
                    //catch { }
                    try
                    {
                        if (addChatOptionToArmyBuildWorkers)
                            PatchHarmonyMethodUnity(typeof(job_ArmyBuildingWork), "Chat_ReceptionGuard", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToTheClinicDoctorMaylenne)
                            PatchHarmonyMethodUnity(typeof(job_Clinic), "Chat_Doctor", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToWar)
                            PatchHarmonyMethodUnity(typeof(Mis_Army), "Chat_War", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToHadley)
                            PatchHarmonyMethodUnity(typeof(Mis_Hadley), "Chat_Hadley", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToBeth)
                            PatchHarmonyMethodUnity(typeof(int_Vent), "BethTalk", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToPrisioner)
                            PatchHarmonyMethodUnity(typeof(job_CapturedHouse), "ChatPrisioner", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToPaintShopPerson)
                            PatchHarmonyMethodUnity(typeof(job_paintShop), "ChatShop", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToMisProst)
                            PatchHarmonyMethodUnity(typeof(Mis_Prost), "DeskChat", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToStripClubWorkers)
                            PatchHarmonyMethodUnity(typeof(job_StripClub), "StripChat", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToSia)
                            PatchHarmonyMethodUnity(typeof(Mis_BackEntrance), "InteractWithSia", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToGuards)
                            PatchHarmonyMethodUnity(typeof(Mis_HardTutorial), "Day4_InteractWithGuard1", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToSarah)
                            PatchHarmonyMethodUnity(typeof(Mis_MedTutorial), "SarahChat", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToZea)
                            PatchHarmonyMethodUnity(typeof(Mis_Zea1), "ChatZea", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToZea)
                            PatchHarmonyMethodUnity(typeof(Mis_Zea2), "ChatZea", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToZea)
                            PatchHarmonyMethodUnity(typeof(Mis_ZeaMistake), "ChatZea1", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToSephie)
                            PatchHarmonyMethodUnity(typeof(Mis_Zea3), "ChatSephie", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToFollower)
                            PatchHarmonyMethodUnity(typeof(int_Person), "FollowingChat", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                    try
                    {
                        if (addChatOptionToLeashedPersons)
                            PatchHarmonyMethodUnity(typeof(int_Person), "RestrainedInteraction_options", "DefaultTalk_options_AddSexOption", false, true);
                    }
                    catch { }
                }
            } catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
            }
        }
		
		public static void PatchHarmonyMethodUnity(Type originalClass, string originalMethodName, string patchedMethodName, bool usePrefix, bool usePostfix, Type[] parameters = null)
        {
            // Create a new Harmony instance with a unique ID
            var harmony = new Harmony("com.wolfitdm.BitchlandLetsHaveSexHereChatBepInEx");

            if (originalClass == null)
            {
                Logger.LogInfo($"GetType originalClass == null");
                return;
            }

            // Or apply patches manually
            MethodInfo original = null;

            if (parameters == null)
            {
                original = AccessTools.Method(originalClass, originalMethodName);
            } else
            {
                original = AccessTools.Method(originalClass, originalMethodName, parameters);
            }

            if (original == null)
            {
                Logger.LogInfo($"AccessTool.Method original {originalMethodName} == null");
                return;
            }

            MethodInfo patched = AccessTools.Method(typeof(BitchlandLetsHaveSexHereChatBepInEx), patchedMethodName);

            if (patched == null)
            {
                Logger.LogInfo($"AccessTool.Method patched {patchedMethodName} == null");
                return;

            }

            HarmonyMethod patchedMethod = new HarmonyMethod(patched);
			
            var prefixMethod = usePrefix ? patchedMethod : null;
            var postfixMethod = usePostfix ? patchedMethod : null;

            harmony.Patch(original,
                prefix: prefixMethod,
                postfix: postfixMethod);
        }

        public static bool Chat_Xoxa(object __instance)
        {
            if (!enableMe)
            {
                return true;
            }

            Mis_Xoxa _this = (Mis_Xoxa)__instance;
            UI_Gameplay _gameplay = Main.Instance.GameplayMenu;
            Person person = _gameplay.PersonChattingTo;

            if (person.CurrentZone == _this.XoxaZone)
            {
                person.CurrentZone = null;
            }

            return true;
        }

        public static void DefaultTalk_options_AddFollowingSexOption(object __instance)
        {
            if (!enableMe)
            {
                return;
            }

            DefaultTalk_options_AddSexOption(__instance);
        }
        public static void DefaultTalk_options_AddSexOption(object __instance)
        {
            if (!enableMe)
            {
                return;
            }

            UI_Gameplay _gameplay = Main.Instance.GameplayMenu;
            int_Person _this = null;

            if (__instance is int_Person)
            {
                _this = (int_Person)__instance;
            }
            else
            {
                Person person = _gameplay.PersonChattingTo;
                _this = person != null ? person.ThisPersonInt : Main.Instance.Player.ThisPersonInt;
            }

            _gameplay.AddChatOption("Lets have sex here", (Action)(() =>
            {
                if (maxRelationShipIfYouHaveSex)
                    _this.ThisPerson.Favor += 10000;
                if (Main.Instance.Player.HasPenis)
                    Main.Instance.SexScene.SpawnSexScene(2, 0, Main.Instance.Player, _this.ThisPerson);
                else if (_this.ThisPerson.HasPenis)
                    Main.Instance.SexScene.SpawnSexScene(2, 0, _this.ThisPerson, Main.Instance.Player);
                else
                    Main.Instance.SexScene.SpawnSexScene(2, 0, Main.Instance.Player, _this.ThisPerson);
                _this.EndTheChat();
            }));
        }
    }
}