using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        WinnersModel createWinners(WinnersModel model);
        TeamMember createPerson(TeamMember model);



    }
}
