using System;

// Create and display Students
var s1 = new Student("2023308262", "Kristel Joy Seno", "BS Information Technology");
var s2 = new Student("2023020403", "Zaina Manheaven", "BS Information Technology");

s1.DisplayInfo();
s2.DisplayInfo();

// Create a BankAccount and perform transactions
var account = new BankAccount("00012345", "Kristel Joy Seno", 4000.00);
account.Deposit(1000.00);
account.Withdraw(500.00);
account.DisplayBalance();
