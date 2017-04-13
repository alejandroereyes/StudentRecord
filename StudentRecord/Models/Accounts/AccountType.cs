using StudentRecord.Models.Accounts;
using System.Data.Entity;
using System.Linq;

namespace StudentRecord.Models
{
    public class AccountType : ActiveEntity
    {
        public virtual IDbSet<Account> Accounts { get; set; }
        public string Name { get; set; }

        public static AccountType Undergraduate()
        {
            return _ACTIVE_CONTEXT.AccountTypes.Where(accountType => accountType.Name == "Undergraduate").First();
        }
    }
}