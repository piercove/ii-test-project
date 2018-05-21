using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iibank.Application.Models;
using iibank.data;


namespace iibank.Application.Handlers
{
    public class TransactionHandler
    {
        public string Deposit(double amount, int accountId)
        {
            var account = GetAccount(accountId);
            var trans = new TransactionModel()
            {
                // TransactionId = GetNextTransactionId();
                TransactionType = "deposit",  // Normally strongly typed w/ Resource File
                ToAccountId = accountId,
                FromAccountId = 0,
                FromAccountBalance = 0,
                TransactionAmount = amount,
                ToAccountBalance = account.Balance + amount,
                TimeStamp = DateTime.Now
            };

            try
            {
                // Save to Data Layer
                return SaveTransaction(trans);
            }
            catch (Exception error)
            {
                // Write error to log
                return error.Message;
            }
        }

        public string Withdraw(double amount, int accountId)
        {
            var account = GetAccount(accountId);
            var trans = new TransactionModel()
            {
                // TransactionId = GetNextTransactionId();
                TransactionType = "withdraw",  // Normally strongly typed w/ Resource File
                ToAccountId = 0,
                ToAccountBalance = 0,
                FromAccountId = accountId,
                FromAccountTypeId = account.AccountTypeId,
                TransactionAmount = amount,
                FromAccountBalance = account.Balance - amount,
                TimeStamp = DateTime.Now
            };

            try
            {
                // Save to Data Layer
                return SaveTransaction(trans);
            }
            catch (Exception error)
            {
                // Write error to log
                return error.Message;
            }
        }

        public string Transfer(double amount, int toAccountId, int fromAccountId)
        {
            var account1 = GetAccount(toAccountId);
            var account2 = GetAccount(fromAccountId);
            var trans = new TransactionModel()
            {
                // TransactionId = GetNextTransactionId();
                TransactionType = "transfer",  // Normally strongly typed w/ Resource File
                TransactionAmount = amount,
                ToAccountId = toAccountId,
                ToAccountTypeId = account1.AccountTypeId,
                ToAccountBalance = account1.Balance + amount,
                FromAccountId = fromAccountId,
                FromAccountTypeId = account2.AccountTypeId,
                FromAccountBalance = account2.Balance - amount,
                TimeStamp = DateTime.Now
            };

            try
            {
                // Save to Data Layer
                return SaveTransaction(trans);
            }
            catch (Exception error)
            {
                // Write error to log
                return error.Message;
            }
        }


        public AccountModel GetAccount(int accountId)
        {
            var account = new AccountModel();
            var _account = new FakeAccountData().accounts.First(x => x.AccountId == accountId);
            if (_account != null)
            {
                // Normally we would use AutoMapper or equivalent
                account.AccountId = _account.AccountId;
                account.Balance = _account.Balance;
                account.AccountTypeId = _account.AccountTypeId;
                account.BankId = _account.BankId;
            }
            return account;
        }

        public string SaveTransaction(TransactionModel transaction)
        {
            // Check New Balance
            if (transaction.ToAccountBalance < 0 || transaction.FromAccountBalance < 0)
            {
                // Throw and bubble error since overdrafts are not allowed
                return "Account Balance cannot be less than zero on any account";
            }

            // Save Transaction
            switch (transaction.TransactionType)
            {
                case "deposit":
                    // SaveDeposit(transaction);
                    break;
                case "withdraw":
                    if (transaction.FromAccountTypeId == 3 && transaction.TransactionAmount > 1000)
                    {
                        // Throw and bubble error
                        return "Cannot withdraw more than $1,000 per transaction";
                    }
                    // SaveWithdraw(transaction);
                    break;
                case "transfer":
                    // SaveTransfer(transaction);
                    break;
            }

            return "Success"; // Normally part of the methods above and not done in this manner
        }
    }
}
