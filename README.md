# 🏦 Banking Management System — WinForms

> A desktop banking application built with **C# and Windows Forms (.NET)**, providing a simple graphical interface to create, deposit, withdraw, remove, and display bank accounts — all backed by flat-file persistence.

---

## 📖 Overview

This project simulates the core operations of a retail bank through a lightweight WinForms desktop app. Users interact through a central menu (`Form1`) that launches dedicated forms for each banking operation. Account data is held in memory during runtime and persisted to a local text file (`AccFile.txt`) using comma-separated values.

---

## ✨ Features

| Feature | Description |
|---|---|
| 🆕 **Create Account** | Register a new account with a unique account number and starting balance |
| 💵 **Deposit** | Add funds to an existing account |
| 💸 **Withdrawal** | Remove funds from an account (with insufficient-funds protection) |
| 🗑️ **Remove Account** | Delete an account by its index/number |
| 📋 **Display All** | View every active account in a `DataGridView` |
| 💾 **Save & Exit** | Persist all in-memory accounts to disk on exit |

---

## 🗂️ Project Structure

```
WinFormsBankingApp/
│
├── Program.cs                  # Application entry point
├── Form1.cs / .Designer.cs     # Main menu / dashboard
├── CreateAccountForm.cs        # Standalone account creation form
├── AddNewAccDisplay.cs         # Account creation form (launched from DisplayForm)
├── Deposit.cs / .Designer.cs   # Deposit funds form
├── Withdrawal.cs / .Designer.cs# Withdraw funds form
├── DisplayForm.cs / .Designer.cs # View all accounts (DataGridView + ListBox)
├── Account.cs                  # Account model/entity
└── Banking.cs                  # Static business-logic / data-access layer
```

---

## 🧩 Architecture

### Class Diagram (conceptual)

```
┌───────────────┐        uses         ┌──────────────────┐
│    Form1      │────────────────────▶│      Banking      │
│ (Main Menu)   │                     │  (static logic)   │
└───────┬───────┘                     └─────────┬──────────┘
        │ opens                                 │ manages
        ▼                                        ▼
┌────────────────────────────┐          ┌───────────────┐
│ CreateAccountForm           │          │    Account     │
│ Deposit                     │          │  (model)       │
│ Withdrawal                  │          └───────────────┘
│ DisplayForm ──▶ AddNewAccDisplay        Numbera, Balance
└────────────────────────────┘
```

### 🔑 Key Classes

#### `Account`
A simple data model representing a bank account.

- `Numbera` — account number (`string`)
- `Balance` — current balance (`int`)
- `Convert_To_Str()`, `GetBalance()`, `GetNumber()` — helper accessors

#### `Banking` (static class)
The application's data-access and business-logic layer. Holds the in-memory `List<Account> accounts` and handles:

- `Create(string, int)` — adds a new account, guards against duplicates, appends to file
- `Deposit(string, int)` — increases balance for a matched account
- `Withdrawal(string, int)` — decreases balance, blocking overdrafts
- `Remove(int)` — deletes an account by index
- `DisplayAll()` — returns account summaries as strings
- `ExitWithSave()` — writes all accounts back to `AccFile.txt`
- `LoadAccounts()` / `LoadAccountsIntoList()` — reads accounts from disk on startup

#### Forms
| Form | Purpose |
|---|---|
| `Form1` | Main dashboard with navigation buttons to every feature |
| `CreateAccountForm` | Collects account number + balance, calls `Banking.Create` |
| `AddNewAccDisplay` | A secondary "add account" dialog launched from `DisplayForm` |
| `Deposit` | Collects account number + amount, calls `Banking.Deposit` |
| `Withdrawal` | Collects account number + amount, calls `Banking.Withdrawal` |
| `DisplayForm` | Shows all accounts in a `DataGridView`, with a button to add new ones |

---

## 💾 Data Persistence

Accounts are stored as plain CSV lines in a local text file:

```
AccountNumber,Balance
1001,5000
1002,2500
```

The file path is currently **hardcoded** to a developer machine:

```csharp
static String Acc_File_Path = @"C:\Users\Muhammad.Abdullah.S\source\repos\WinFormsBankingApp\WinFormsBankingApp\AccFile.txt";
```

> ⚠️ **Note:** This path must be updated (ideally to a relative or `Application.StartupPath`-based path) before running on another machine.

---

## 🚀 Getting Started

### Prerequisites
- Windows OS
- [.NET SDK](https://dotnet.microsoft.com/) (Windows Forms support, `net6.0-windows` or later)
- Visual Studio 2022 (recommended) or `dotnet` CLI

### Run the App

```bash
git clone <your-repo-url>
cd WinFormsBankingApp
dotnet build
dotnet run
```

Or simply open the `.sln` file in Visual Studio and press **F5**.

### First-Time Setup
1. Update `Acc_File_Path` in `Banking.cs` to a valid path on your machine.
2. Ensure the target directory exists (or let `Banking.LoadAccounts()` create the file automatically).
3. Launch the app — the main menu appears with all banking actions.

---

## 🧭 User Flow

```
Form1 (Main Menu)
 ├── Create Account   → CreateAccountForm → Banking.Create()
 ├── Remove Account    → InputBox → Banking.Remove()
 ├── Display All       → DisplayForm → DataGridView
 │                         └── Add New → AddNewAccDisplay → Banking.Create()
 ├── Deposit Cash      → Deposit → Banking.Deposit()
 ├── Withdraw Cash      → Withdrawal → Banking.Withdrawal()
 └── Exit and Save     → Banking.ExitWithSave()
```

---

## ⚠️ Known Limitations

- 🔒 **Hardcoded file path** — not portable across machines out of the box
- 🧮 **No input validation UI feedback** for non-numeric balances beyond try/catch
- 🪪 **No duplicate-safe removal by account number** — `Remove()` works by list index, not account number
- 🔁 **Repeated file reads** — `DisplayForm_Load` and `BtnAddRecord_Click` call `LoadAccountsIntoList()` multiple times unnecessarily
- 🧵 **No concurrency/locking** protection for simultaneous file access
- 🕳️ **Silent exception swallowing** in `Banking.Withdrawal` (`catch` block intentionally empty, relying on UI-level try/catch)

---

## 🛠️ Suggested Improvements

-  Replace hardcoded path with `Path.Combine(Application.StartupPath, "AccFile.txt")`
-  Move to a real data store (SQLite/JSON) instead of raw CSV text
-  Add account-number based removal instead of index-based
-  Add input validation with inline error messages instead of `MessageBox` popups
-  Introduce unit tests for `Banking` logic, decoupled from `MessageBox`/UI calls

---

## 📜 License

This project is provided as-is for educational purposes. Add your preferred license here.

---

<div align="center">

**Built with ❤️ using C# WinForms**

</div>
