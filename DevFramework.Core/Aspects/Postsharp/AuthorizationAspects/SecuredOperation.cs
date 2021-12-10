using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Aspects.Postsharp.AuthorizationAspects
{
    [Serializable]
    public class SecuredOperation : OnMethodBoundaryAspect
    {
        public string Roles { get; set; }

        public override void OnEntry(MethodExecutionArgs args)//methoda girildiğinde
        {
            string[] roles = Roles.Split(',');//Rolesteki rolleri alıp virgül ile ayırarak (roles)diziye atadı
            bool isAuthorized = false;
            for (int i = 0; i < roles.Length; i++)
            {
                if (System.Threading.Thread.CurrentPrincipal.IsInRole(roles[i]))//kullanıcı rollerden birine sahipse
                {
                    isAuthorized = true;
                }
            }
            if (isAuthorized==false)
            {
                throw new SecurityException("You are not authorized!");
            }

        }
    }
}
