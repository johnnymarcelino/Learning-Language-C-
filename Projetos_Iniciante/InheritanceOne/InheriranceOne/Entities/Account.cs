﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheriranceOne.Entities
{
    internal class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

    }
}
