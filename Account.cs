﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{

    /// <summary>
    /// This is a bank Account where user can deposit and withdraw money from bank
    /// </summary>
    class Account
    {
        #region variable
        /// <summary>
        /// Autogenerate a account number 
        /// </summary>
        private static int lastAccountNumber = 0;
        
            
        #endregion

        #region Properties
        /// <summary>
        /// EmailAddress for the account
        /// </summary>
        public string AccountEmailAddress { get; set; }
        /// <summary>
        ///Autogenerated Account Number for the Account
        /// </summary>
        public int AccountNumber { get; }
        /// <summary>
        /// Account type for account
        /// </summary>
        public string  AccountType { get; set; }
        /// <summary>
        /// account balance for account
        /// </summary>
        public decimal AccountBalance { get; private set; }
        /// <summary>
        /// account create date for acoount
        /// </summary>
        public DateTime AccountCreateDate { get; private set; }
        #endregion
        #region Constructor
        public Account()
        {
            AccountNumber = lastAccountNumber++;
            AccountCreateDate = DateTime.Now;
        }

        #endregion

        #region Method
        /// <summary>
        /// Deposit money into the account
        /// </summary>
        /// <param name="amount to deposit"></param>
        public void Deposit(decimal amount)
        {
            AccountBalance += amount;
        }

        #endregion
    }
}
