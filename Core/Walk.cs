using GorillaLocomotion;
using UnityEngine;
using System.Collections;
using ASTRAS_WALL_WALK_ALWAYS.Libs;


namespace ASTRAS_WALL_WALK_ALWAYS.Core
{

    public class Walk : MonoBehaviour
    {
        float speed = 0f;
        bool CONTROLLERn = false;
        
        void Update()
        {
            walk();
            CON();
        }
         
        

        public IEnumerator Start()
        {
            while (GameObject.Find("NOTIFICATIONLIB_HUD_OBJ") == null)
            {
                yield return null; 
            }

            NotifiLib.SendNotification("Hello, welcome to ASTRAS WALL WALK!");
            NotifiLib.SendNotification("Press both grips to wall walk.");
            NotifiLib.SendNotification("Press A to change Wall Walk Speed.");
            NotifiLib.SendNotification($"[WallWalk] Speed set to {speed}");
        }


        void walk() 
        {
            if (ControllerInputPoller.instance.rightGrab && ControllerInputPoller.instance.leftGrab)
            {
                GTPlayer.Instance.bodyCollider.attachedRigidbody.AddForce(
                    GTPlayer.Instance.bodyCollider.transform.forward * speed,
                    ForceMode.Acceleration
                );
            }
        }

        void CON()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton && !CONTROLLERn)
            {
                speed += 5f;
                if (speed >= 100f)
                {
                    speed = 0f;
                }
                NotifiLib.SendNotification($"[WallWalk] Speed set to {speed}");
            }
           
            CONTROLLERn = ControllerInputPoller.instance.rightControllerPrimaryButton;
        }



       
        


    }
}
