using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.Entities.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.DataAccess.Repositories
{
    class test2
    {
        public test2()
        {
            context = new ChoirContext();

            context.ClotheType.Add(new ClotheTypes("asdasd"));
        }

        ChoirContext context;
    }
}
