﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
       

        private double balance;

        public BankAccount(double amount)
        {
            balance = amount;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }



    }
}
