﻿// 
using System;

namespace AddressBook_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO AddressBook Problems Using ADO.NET");

            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookRepo.DataBaseConnection();
        }
    }
}
