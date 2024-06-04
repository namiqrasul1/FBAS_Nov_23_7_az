using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmHomework.Models
{
    internal class Bank
    {
        private readonly User[] users = [
            new User(name: "hakuna", surname: "matata", amount: 500, year: 3),
            new User(name: "john", surname: "doe", amount: 100, year: 2),
            new User(name: "kamil", surname: "kamilli", amount: 200, year: 1),
            new User(name: "fazil", surname: "fazil", amount: 300, year: 3),
            new User(name: "nazim", surname: "nazim", amount: 250, year: 4),
            ];
        public User? currentUser = null;

        public void ShowAllUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }

        public void Login(string pan, string pin)
        {
            foreach (var user in users)
            {
                if (user.CreditCard.Pan == pan && user.CreditCard.Pin == pin)
                {
                    currentUser = user;
                    return;
                }
            }
            throw new Exception("Wrong pan or pin");
        }

        public void Logout() => currentUser = null;


        public void Withdraw(int amount)
        {
            if (currentUser is null)
                throw new Exception();
            if (currentUser.CreditCard.Balance < amount)
                throw new ArgumentException("Not enough money");

            currentUser.CreditCard.Balance -= amount;
        }

        public decimal GetBalance()
        {
            return currentUser is null ? throw new Exception() : currentUser.CreditCard.Balance;
        }

        public void CardToCard(string recieverPan, int amount)
        {
            if (currentUser is null)
                throw new Exception();
            if (currentUser.CreditCard.Balance < amount)
                throw new ArgumentException("Not enough money");

            foreach (var user in users)
            {
                if(user.CreditCard.Pan == recieverPan)
                {
                    user.CreditCard.Balance += amount;
                    currentUser.CreditCard.Balance -= amount;
                    return;
                }
            }
            throw new ArgumentException("Reciever not found");
        }


    }
}
