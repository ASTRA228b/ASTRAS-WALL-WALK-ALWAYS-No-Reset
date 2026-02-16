using HarmonyLib;


namespace ASTRAS_WALL_WALK_ALWAYS.Safe;

public class BasicPATCH
{
    public static void ApplyPatch()
    {
        var harmony = new Harmony(INFO.GUID);
        harmony.PatchAll();
    }

     
}