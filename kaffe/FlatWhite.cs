﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    class FlatWhite : Kaffe , Imælk
    {
        public override int Pris()
        {
            return 45;
        }


        public override string Styrke()
        {
            return "Mild";
        }

        public int MlMælk()
        {
            return 160;
        }

    }
}

