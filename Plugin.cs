using UnityEngine;
using BepInEx;
using ASTRAS_WALL_WALK_ALWAYS.Core;
using ASTRAS_WALL_WALK_ALWAYS.Libs;
using ASTRAS_WALL_WALK_ALWAYS.Safe;

namespace ASTRAS_WALL_WALK_ALWAYS.Plugin;


[BepInPlugin(INFO.GUID, INFO.Name, INFO.Version)]
public class plugin : BaseUnityPlugin
{
    void Start()
    {
        BasicPATCH.ApplyPatch();
    }
     
    void Awake()
    {
        GameObject Walk = new GameObject(INFO.Name);
        Walk.AddComponent<CreditUI>();
        Walk.AddComponent<Walk>();
        Walk.AddComponent<NotifiLib>();
        DontDestroyOnLoad(Walk);
    }
}