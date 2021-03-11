using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        void Delete(User user);
        void Update(User user);
        User GetByMail(string email);
    }
}