# 🏦 Banking Management System — WinForms

> A desktop banking application built with **C# and Windows Forms (.NET)**, providing a simple graphical interface to create, deposit, withdraw, remove, and display bank accounts, all backed by flat-file persistence.

---

## 📖 Overview

This project simulates the core operations of a retail bank through a lightweight WinForms desktop app. Users interact through a central menu (`Form1`) that launches dedicated forms for each banking operation. Account data is held in memory during runtime and persisted to a local text file (`AccFile.txt`) using comma-separated values.

---

<img width="802" height="483" alt="image" src="https://github.com/user-attachments/assets/6b797a9f-eed0-4bae-9132-4b560040e284" />

---

## ✨ Features

| Feature | Description |
|---|---|
| 🆕 **Create Account** | Register a new account with a unique account number and starting balance |
| 💵 **Deposit** | Add funds to an existing account |
| 💸 **Withdrawal** | Remove funds from an account (with insufficient-funds protection) |
| ✏️ **Edit Account** | Update an existing account's balance/number directly from the grid |
| 🗑️ **Remove Account** | Delete an account by its index/number (from the main menu or the grid) |
| 📋 **Display All** | View every active account in a `DataGridView`, with inline edit/delete columns |
| 🧮 **Total Balance** | Automatically calculates and displays the bank's total holdings on load |
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
├── DisplayForm.cs / .Designer.cs # View all accounts (DataGridView + inline Edit/Delete buttons)
├── FormEditRecord.cs / .Designer.cs # Edit an existing account's number/balance
├── Account.cs                  # Account model/entity
├── Banking.cs                  # Static business-logic / data-access layer
└── AccFile.txt                 # Flat-file data store (CSV: AccountNumber,Balance)
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
│      └────────▶ FormEditRecord
└────────────────────────────┘
```

### 🔑 Key Classes

#### `Account`
A simple data model representing a bank account.

- `Numbera`: account number (`string`)
- `Balance`: current balance (`int`)
- `Convert_To_Str()`, `GetBalance()`, `GetNumber()`: helper accessors

#### `Banking` (static class)
The application's data-access and business-logic layer. Holds the in-memory `List<Account> accounts` and handles:

- `Create(string, int)`: adds a new account, guards against duplicates, appends to file
- `Deposit(string, int)`:  increases balance for a matched account
- `Withdrawal(string, int)`: decreases balance, blocking overdrafts
- `Remove(int)`: deletes an account by index
- `DisplayAll()`: returns account summaries as strings
- `ExitWithSave()`: writes all accounts back to `AccFile.txt`
- `LoadAccounts()` / `LoadAccountsIntoList()`: reads accounts from disk on startup

> Note: account **editing** (via `FormEditRecord`) doesn't go through a dedicated `Banking` method, it mutates `Banking.accounts` directly (`Banking.accounts[Index].Balance = ...`) and then calls `ExitWithSave()`.

#### Forms
| Form | Purpose |
|---|---|
| `Form1` | Main dashboard with navigation buttons to every feature |
| `CreateAccountForm` | Collects account number + balance, calls `Banking.Create` |
| `AddNewAccDisplay` | A secondary "add account" dialog launched from `DisplayForm` |
| `Deposit` | Collects account number + amount, calls `Banking.Deposit` |
| `Withdrawal` | Collects account number + amount, calls `Banking.Withdrawal` |
| `DisplayForm` | Shows all accounts in a `DataGridView` with **Edit**/**Delete** button columns, an "Add New" button, and a total-balance summary popup on load |
| `FormEditRecord` | Looks up an account by number and overwrites its number/balance, then saves |

---

## 💾 Data Persistence

Accounts are stored as plain CSV lines in a local text file (`AccFile.txt`). Example from the shipped sample data:

```
acc1,16976
acc2,150
acc3,150
acc4,2500
acc5,140
acc6,2670
acc7,1875
acc8,3500
acc9,1250
acc10,4453
acc11,8650
acc12,1000
acc13,2455
acc14,500
acc15,750
acc16,4000
acc17,5500
acc18,20000
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
3. Launch the app, the main menu appears with all banking actions.

---

## 🧭 User Flow

```
Form1 (Main Menu)
 ├── Create Account   → CreateAccountForm → Banking.Create()
 ├── Remove Account    → InputBox → Banking.Remove()
 ├── Display All       → DisplayForm → (on load) shows Total Balance popup → DataGridView
 │                         ├── Add New   → AddNewAccDisplay → Banking.Create()
 │                         ├── "Edit" column button   → FormEditRecord → mutates Banking.accounts → ExitWithSave()
 │                         └── "Delete" column button → InputBox → Banking.Remove()
 ├── Deposit Cash      → Deposit → Banking.Deposit()
 ├── Withdraw Cash      → Withdrawal → Banking.Withdrawal()
 └── Exit and Save     → Banking.ExitWithSave()
```

---

## ⚠️ Known Limitations

- 🔒 **Hardcoded file path**, not portable across machines out of the box
- 🧮 **No input validation UI feedback** for non-numeric balances beyond try/catch
- 🪪 **No duplicate-safe removal by account number**, `Remove()` and the grid's "Delete" button both work by list **index** (`acc1 == 1`), not the account's actual number string
- 🖱️ **Grid "Edit"/"Delete" buttons don't target the clicked row**, clicking either button opens an `InputBox`/`FormEditRecord` that asks the user to re-type the account index/number rather than acting on the row that was clicked
- 🔁 **Repeated file reads**, `DisplayForm_Load`, `BtnAddRecord_Click`, and the grid button handlers all call `LoadAccountsIntoList()` multiple times unnecessarily
- 📢 **Intrusive popups**, `DisplayForm_Load` shows a `MessageBox` with the total bank balance every single time the form opens, which interrupts the flow of just viewing accounts
- 🧵 **No concurrency/locking** protection for simultaneous file access
- 🕳️ **Silent exception swallowing** in `Banking.Withdrawal` (`catch` block intentionally empty, relying on UI-level try/catch)
- ✏️ **`FormEditRecord` has no pre-fill**, the form doesn't load the selected account's current number/balance into its text boxes, so the user must know and re-type the exact existing account number to edit it

---

## 🛠️ Suggested Improvements

-  Replace hardcoded path with `Path.Combine(Application.StartupPath, "AccFile.txt")`
-  Move to a real data store (SQLite/JSON) instead of raw CSV text
-  Add account-number based removal instead of index-based
-  Pass the clicked row's account data into `FormEditRecord`/delete flow instead of re-prompting via `InputBox`
-  Pre-fill `FormEditRecord`'s text boxes with the selected account's current values
-  Replace the total-balance `MessageBox` with an inline label on `DisplayForm`
-  Add input validation with inline error messages instead of `MessageBox` popups
-  Introduce unit tests for `Banking` logic, decoupled from `MessageBox`/UI calls

---

## 📜 License

This project is provided as-is for educational purposes. Add your preferred license here.

---

<div align="center">

**Built with ❤️ using C# WinForms**

</div>
