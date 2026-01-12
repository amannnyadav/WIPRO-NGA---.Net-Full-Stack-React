using BankAccountManagementSystem;
namespace BankAudit
//this is another assembly/project for 'BankAudit' to demonstrate internal access modifier.
{
    public  class CorporateAccount : BankAccountManagementSystem.BankAccount
    {
        public CorporateAccount(string accNumber, string pin, decimal interest, string branchCode)
            : base(accNumber, pin, interest, branchCode)
        {
            // Constructor calling base class constructor
            // Accessing protected internal member from base class
            //hence this will work as CorporateAccount is derived from BankAccount- Core banking assembly

        }

    }
}