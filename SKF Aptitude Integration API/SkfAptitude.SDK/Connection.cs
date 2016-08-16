using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKF.RS.AddOnSDK.CoreData;
namespace SkfAptitude.SDK
{
    public static class Connection
    {
        
        public static void Create()
        {
            string oConString;
            string oDbProvider;
            string oDbUser;
            string oDbPwd;
            // Remember to delete the reference to the code !!!!
            try
            {
                RSDatabase.Get_Connection_String(out oConString, out oDbProvider, out oDbUser, out oDbPwd);
            }
            catch (RSDbException ex)
            {
                // TODO logging!
            }
        }
    }
}
