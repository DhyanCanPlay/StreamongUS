using HarmonyLib;
using UnityEngine;

namespace StreamongUS.Patches
{
    /// <summary>
    /// Patch for MeetingHud to change local imposter name color to white
    /// This prevents stream sniping by hiding the red imposter name color
    /// </summary>
    [HarmonyPatch(typeof(MeetingHud))]
    public static class MeetingHudPatch
    {
        /// <summary>
        /// Postfix patch for MeetingHud.Update to continuously update name colors
        /// </summary>
        [HarmonyPatch(nameof(MeetingHud.Update))]
        [HarmonyPostfix]
        public static void UpdatePostfix(MeetingHud __instance)
        {
            // Safety checks
            if (__instance == null)
                return;
            
            // Only process if we're in a meeting (any active state)
            if (__instance.state != MeetingHud.VoteStates.Discussion && 
                __instance.state != MeetingHud.VoteStates.Voted && 
                __instance.state != MeetingHud.VoteStates.NotVoted)
                return;

            // Get local player
            var localPlayer = PlayerControl.LocalPlayer;
            if (localPlayer == null || localPlayer.Data == null || localPlayer.Data.Role == null)
                return;

            // Check if local player is an imposter
            if (!localPlayer.Data.Role.IsImpostor)
                return;

            // Find the local player's vote area (their name display in the meeting)
            if (__instance.playerStates == null)
                return;
                
            foreach (var playerVoteArea in __instance.playerStates)
            {
                if (playerVoteArea == null)
                    continue;

                // Check if this vote area belongs to the local player
                if (playerVoteArea.TargetPlayerId == localPlayer.PlayerId)
                {
                    // Change the name text color to white
                    if (playerVoteArea.NameText != null)
                    {
                        playerVoteArea.NameText.color = Color.white;
                    }
                    
                    break; // Found and updated local player, exit loop
                }
            }
        }
    }
}
