﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//@Author NightWolf
//This is a file from Project $safeprojectname$

namespace Crystal.WorldServer.Database.Cache
{
    public static class NpcPositionCache
    {
        public static List<Records.NpcPositionRecord> Cache = new List<Records.NpcPositionRecord>();

        public static void Init()
        {
            Cache = Records.NpcPositionRecord.FindAll().ToList();
            foreach (Records.NpcPositionRecord npc in Cache)
            {
                try{
                    World.Helper.MapHelper.FindMap(npc.MapId).Engine.AddNpc(npc);
                   }
                    catch{}
            }      
        }
    }
}
