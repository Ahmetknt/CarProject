using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //2.05 kaldın
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
