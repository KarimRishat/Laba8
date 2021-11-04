using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metodichka
{
    public enum AccountType { Current, Saving, IncorrectInput };
    class BankAccount
    {

        private uint number;
        private decimal balance;
        private AccountType type;
        private static uint genNum = 1;
        private Queue<BankTransaction> transactions;
        public void GetInfo()
        {
            Console.WriteLine($"\nНомер счета: {number},\nТип счета: {type},\nБаланс счета: {balance}");
        }
        public BankAccount() { number = genNum++; type = AccountType.Current; balance = 0; transactions = new Queue<BankTransaction>(); }
        public BankAccount(decimal sum) { number = genNum++; type = AccountType.Current; balance = sum; transactions = new Queue<BankTransaction>(); }
        public BankAccount(int x) { number = genNum++; type = (AccountType)x; balance = 0; transactions = new Queue<BankTransaction>(); }
        public BankAccount(int x, decimal sum) { number = genNum++; type = (AccountType)x; balance = sum; transactions = new Queue<BankTransaction>(); }

        public void Withdraw(decimal take)
        {
            if (balance - take < 0)
            {
                Console.WriteLine("Снять со счета эту сумму нельзя");
            }
            else
            {
                balance -= take;
                transactions.Enqueue(new BankTransaction(-take));
            }
        }
        public void AddMoney(decimal add)
        {
            balance += add;
            transactions.Enqueue(new BankTransaction(add));
        }
        public void TakeFrom(BankAccount account, decimal sum)
        {
            if (sum>account.balance)
            {
                Console.WriteLine("С этого аккаунта нельзя перевести такую сумму");
            }
            else
            {
                account.Withdraw(sum);
                AddMoney(sum);
            }

        }
        public void Dispose(string file)
        {
            StreamWriter stream = new StreamWriter(file);
            foreach (BankTransaction item in transactions)
            {
                stream.WriteLine(item.ToString());
            }
            stream.Close();
            GC.SuppressFinalize(stream);
        }
    }
}
