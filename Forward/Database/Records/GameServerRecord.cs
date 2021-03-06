﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Castle.ActiveRecord;

//@Author NightWolf
//This is a file from Project $safeprojectname$

namespace Crystal.RealmServer.Database.Records
{
    [ActiveRecord("gameservers")]
    public class GameServerRecord : ActiveRecordBase<GameServerRecord>
    {
        [PrimaryKey("Id")]
        public int ID
        {
            get;
            set;
        }

        [Property("ServerAdress")]
        public string Adress
        {
            get;
            set;
        }

        [Property("GamePort")]
        public int GamePort
        {
            get;
            set;
        }

        [Property("CommunicationPort")]
        public int CommunicationPort
        {
            get;
            set;
        }

        [Property("MaxConnectionAllowed")]
        public int MaxConnectionAllowed
        {
            get;
            set;
        }

        [Property("MininumLevelRequired")]
        public int MininumLevelRequired
        {
            get;
            set;
        }
    }
}
