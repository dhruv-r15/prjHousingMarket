﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjHousingMarket
{
    public class Agent
    {
        private int ID = -1;
        private String strName = "";
        private String strSurname = "";
        private bool bDriver = false;
        private String strRace = "";



        public Agent(int v, string? agentName)
        {

        }

        public Agent(int iD, string strName, string strSurname, bool bDriver, string strRace)
        {
            ID = iD;
            this.strName = strName;
            this.strSurname = strSurname;
            this.bDriver = bDriver;
            this.strRace = strRace;

        }

        public override String ToString()
        {
            return "ID :" + ID + "\nName: " + strName
                + "\nSurname: " + strSurname + "\nHas their license: " + bDriver + "\nRace: " + strRace + "\n";

        }
    }
}
